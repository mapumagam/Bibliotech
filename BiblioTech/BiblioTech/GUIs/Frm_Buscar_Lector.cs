using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Entity;
using BiblioTech.Modelos;

namespace BiblioTech.GUIs
{
    public partial class Frm_Buscar_Lector : DevExpress.XtraEditors.XtraForm
    {
        int iPaginaActual = 0, iPaginasTotales = 0;
        private BibliotecaEntities Contexto;
        private List<UsuarioBusqueda> lstUsuariosBusqueda = new List<UsuarioBusqueda>();
        public usuarios usuario;

        public Frm_Buscar_Lector()
        {
            InitializeComponent();
        }

        private void Frm_Buscar_Lector_Shown(object sender, EventArgs e)
        {
            Contexto = new BibliotecaEntities(Configuracion.ConnectionString);
            usuario = new usuarios();
            InicializarGrid();
        }

        private void InicializarGrid()
        {
            UsuarioBusqueda usuariobusqueda;
            List<usuarios> lstUsuarios = 
                Contexto.usuarios.ToList()
                    .FindAll(o => o.tipo_usuario != "SU")
                    .OrderBy(o => o.primer_nombre)
                    .ToList();

            foreach (usuarios lector in lstUsuarios)
            {
                usuariobusqueda = new UsuarioBusqueda();
                usuariobusqueda.Lector = lector;
                this.lstUsuariosBusqueda.Add(usuariobusqueda);
            }

            iPaginaActual = 0;
            if ((lstUsuariosBusqueda.Count % 100) != 0)
            {
                iPaginasTotales = (int)(lstUsuariosBusqueda.Count / 100);
                iPaginasTotales++;
            }
            else
            {
                iPaginasTotales = (int)(lstUsuariosBusqueda.Count / 100);
            }

            Paginar(iPaginaActual);
        }

        #region Paginación
            private void Paginar(int index)
            {
                int iSalto = index * 100;

                RevisarBotones();

                lblPaginacion.Text = string.Format("Página {0} de {1}", (index + 1), iPaginasTotales);

                gridLectores.DataSource = null;
                gridLectores.DataSource = lstUsuariosBusqueda.Skip(iSalto).Take(100);
                gvLectores.BestFitColumns();
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
        #endregion

        private void txbMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }            
        }

        private void ActualizarGrid()
        {
            string sBuscar = txbNombre.Text.ToUpper().Trim();
            List<UsuarioBusqueda> lstAuxiliar = lstUsuariosBusqueda.FindAll(o => o.NombreLector.ToUpper().Contains(sBuscar)).ToList();
            gridLectores.DataSource = lstAuxiliar;
            gvLectores.BestFitColumns();
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SeleccionarLector();
        }

        private void SeleccionarLector()
        {
            int[] iIndicesSeleccionados = gvLectores.GetSelectedRows();
            var RenglonGrid = gvLectores.GetRow(iIndicesSeleccionados[0]);
            var usuarioEncontrado = (UsuarioBusqueda)RenglonGrid;
            usuario = usuarioEncontrado.Lector;
            this.Close();
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