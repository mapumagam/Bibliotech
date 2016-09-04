using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Entity;
using BiblioTech.Modelos;
using DevExpress.XtraEditors;

namespace BiblioTech.GUIs
{
    public partial class Frm_Consultas : XtraForm
    {
        int iPaginaActual = 0, iPaginasTotales = 0;
        BibliotecaEntities ContextoBusqueda;
        List<libros> lstLibros;
        private BibliotecaEntities Contexto;
        public libros Libro;
        public bool ConBotones;

        public Frm_Consultas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ContextoBusqueda = new BibliotecaEntities(Configuracion.ConnectionString);
                pbCargando.Visible = true;
                bgwBuscar.RunWorkerAsync();  
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Configuracion.MostrarExcepcion(ex), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BuscarLibros()
        {
            lstLibros = new List<libros>();
            var lstLibrosPorTitulo = new List<libros>();
            var lstLibrosPorAutor = new List<libros>();
            var lstLibrosPorArea = new List<libros>();

            var sTitulo = txbTitulo.Text.Trim().ToUpper();
            var sAutor = txbAutor.Text.Trim().ToUpper();
            var sArea = txbArea.Text.Trim().ToUpper();

            if ((sTitulo == string.Empty) && (sAutor == string.Empty) && (sArea == string.Empty))
            {
                lstLibros = ContextoBusqueda.libros.ToList();
                return;
            }

            if (sTitulo != string.Empty)
            {
                lstLibrosPorTitulo = ContextoBusqueda.libros.ToList().FindAll(o => o.titulo.Contains(sTitulo));
                lstLibros.AddRange(lstLibrosPorTitulo);
            }
            if (sAutor != string.Empty)
            {
                lstLibrosPorAutor = ContextoBusqueda.libros.ToList().FindAll(o => o.autor.descripcion.Contains(sAutor));
                lstLibros.AddRange(lstLibrosPorAutor);
            }
            if (sArea != string.Empty)
            {
                lstLibrosPorArea = ContextoBusqueda.libros.ToList().FindAll(o => o.area.descripcion.Contains(sArea));
                lstLibros.AddRange(lstLibrosPorArea);
            }
        }

        private void Frm_Consultas_Shown(object sender, EventArgs e)
        {
            Contexto = new BibliotecaEntities(Configuracion.ConnectionString);
            pnlBotones.Visible = this.ConBotones;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gridConsulta.ShowPrintPreview();
        //this.Close();
        }

        private void obtenerLibroSeleccionado()
        {
            if (gvConsulta.DataRowCount != 0)
            {
                int[] iIndicesSeleccionados = gvConsulta.GetSelectedRows();
                var RenglonGrid = gvConsulta.GetRow(iIndicesSeleccionados[0]);
                Libro = (libros)RenglonGrid;

                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Seleccione un libro por favor.", "Buscar Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            obtenerLibroSeleccionado();
        }

        private void bgwBuscar_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BuscarLibros();
        }

        private void bgwBuscar_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            lstLibros = lstLibros.OrderBy(o=>o.titulo).Distinct().ToList();

            if ((lstLibros.Count % 100) != 0)
            {
                iPaginasTotales = (int)(lstLibros.Count / 100);
                iPaginasTotales++;
            }
            else
            {
                iPaginasTotales = (int)(lstLibros.Count / 100);
            }

            iPaginaActual = 0;
            Paginar(iPaginaActual);

            lblCount.Text = "Libros encontrados: " + lstLibros.Count;
            pbCargando.Visible = false;
        }

        private void Paginar(int index)
        {
            int iSalto = index * 100;

            RevisarBotones();

            lblPaginacion.Text = string.Format("Página {0} de {1}", (index + 1), iPaginasTotales);

            gridConsulta.DataSource = null;
            gridConsulta.DataSource = lstLibros.Skip(iSalto).Take(100);
            gvConsulta.BestFitColumns();
        }

        private void RevisarBotones()
        {
            if (iPaginaActual == 0)
                btnAnterior.Enabled = false;
            else
                btnAnterior.Enabled = true;
            if ((iPaginaActual + 1) == iPaginasTotales)
                btnSiguiente.Enabled = false;
            else
                btnSiguiente.Enabled = true;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            PaginaAtras();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            PaginaSiguiente();
        }

        private void PaginaAtras()
        {
            iPaginaActual--;
            Paginar(iPaginaActual);
        }
        private void PaginaSiguiente()
        {
            iPaginaActual++;
            Paginar(iPaginaActual);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                if (btnAnterior.Enabled == true)
                {
                    PaginaAtras();
                }
                return true;
            }
            if (keyData == Keys.Right)
            {
                if (btnSiguiente.Enabled == true)
                {
                    PaginaSiguiente();
                } 
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}