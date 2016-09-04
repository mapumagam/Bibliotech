using System;
using System.Collections.Generic;
using System.Linq;
using BiblioTech.Entity;
using BiblioTech.Modelos;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace BiblioTech.GUIs
{
    public partial class Frm_Libros : XtraForm
    {
        TipoAccion tipoAccion;
        private libros Libro;

        public Frm_Libros()
        {
            InitializeComponent();
        }

        private void Frm_Libros_Load(object sender, EventArgs e)
        {         
        }

        private void InicializarCombos()
        {
            using (BibliotecaEntities Contexto = new BibliotecaEntities(Configuracion.ConnectionString))
            {
                List<catalogos> lstCatalogos = Contexto.catalogos.ToList();

                cmbArea.DataSource = lstCatalogos.FindAll(o => o.tipo == "AR").OrderBy(o => o.descripcion).ToList();
                cmbArea.DisplayMember = "descripcion";
                cmbArea.ValueMember = "id_catalogo";
                cmbAutor.DataSource = lstCatalogos.FindAll(o => o.tipo == "AU").OrderBy(o => o.descripcion).ToList();
                cmbAutor.DisplayMember = "descripcion";
                cmbAutor.ValueMember = "id_catalogo";
                cmbEditorial.DataSource = lstCatalogos.FindAll(o => o.tipo == "ED").OrderBy(o => o.descripcion).ToList();
                cmbEditorial.DisplayMember = "descripcion";
                cmbEditorial.ValueMember = "id_catalogo";
            }
        }

        private void cmiNuevo_Click(object sender, EventArgs e)
        {
            new Frm_Catalogo(TipoCatalogo.Editorial, TipoVentana.Alta).ShowDialog();
            InicializarCombos();
        }
        private void cmiAbrir_Click(object sender, EventArgs e)
        {
            catalogos catalogo = (catalogos)cmbEditorial.SelectedItem;
            new Frm_Catalogo(TipoCatalogo.Editorial, TipoVentana.Modificacion, catalogo).ShowDialog();
            InicializarCombos();
        }
        private void cmiNuevoAU_Click(object sender, EventArgs e)
        {
            new Frm_Catalogo(TipoCatalogo.Autor, TipoVentana.Alta).ShowDialog();
            InicializarCombos();
        }
        private void cmiAbrirAU_Click(object sender, EventArgs e)
        {
            catalogos catalogo = (catalogos)cmbAutor.SelectedItem;
            new Frm_Catalogo(TipoCatalogo.Autor, TipoVentana.Modificacion, catalogo).ShowDialog();
            InicializarCombos();
        }
        private void cmiNuevaAR_Click(object sender, EventArgs e)
        {
            new Frm_Catalogo(TipoCatalogo.Area, TipoVentana.Alta).ShowDialog();
            InicializarCombos();
        }
        private void cmiAbrirAR_Click(object sender, EventArgs e)
        {
            catalogos catalogo = (catalogos)cmbArea.SelectedItem;
            new Frm_Catalogo(TipoCatalogo.Area, TipoVentana.Modificacion, catalogo).ShowDialog();
            InicializarCombos();
        }
        
        private void Frm_Libros_Shown(object sender, EventArgs e)
        {
            InicializarCombos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicializarControlesNuevo();
        }

        private void InicializarControlesNuevo()
        {
            tipoAccion = TipoAccion.Nuevo;
            txbClave.Text = string.Empty;            txbClave.Enabled = true;
            txbTitulo.Text = string.Empty;           txbTitulo.Enabled = true;
            txbEdicion.Text = string.Empty;          txbEdicion.Enabled = true;
            txbAnio.Text = string.Empty;             txbAnio.Enabled = true;
            txbEjemplares.Text = string.Empty;       txbEjemplares.Enabled = true;

            cmbArea.Enabled = true;
            cmbAutor.Enabled = true;
            cmbEditorial.Enabled = true;

            btnGuardar.Enabled = true;
            btnBuscarLibro.Visible = false;
        }
        private void InicializarControlesModificar()
        {
            tipoAccion = TipoAccion.Modificar;
            txbClave.Text = string.Empty;           txbClave.Enabled = false;
            txbTitulo.Text = string.Empty;          txbTitulo.Enabled = true;
            txbEdicion.Text = string.Empty;         txbEdicion.Enabled = true;
            txbAnio.Text = string.Empty;            txbAnio.Enabled = true;
            txbEjemplares.Text = string.Empty;      txbEjemplares.Enabled = true;

            cmbArea.Enabled = true;
            cmbAutor.Enabled = true;
            cmbEditorial.Enabled = true;

            btnGuardar.Enabled = true;
            btnBuscarLibro.Visible = true;
        }
        private void BloquearControlesNuevo()
        {
            txbClave.Text = string.Empty; txbClave.Enabled = false;
            txbTitulo.Text = string.Empty; txbTitulo.Enabled = false;
            txbEdicion.Text = string.Empty; txbEdicion.Enabled = false;
            txbAnio.Text = string.Empty; txbAnio.Enabled = false;
            txbEjemplares.Text = string.Empty; txbEjemplares.Enabled = false;

            cmbArea.Enabled = false;
            cmbAutor.Enabled = false;
            cmbEditorial.Enabled = false;

            btnGuardar.Enabled = false;
            btnBuscarLibro.Visible = false;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicializarControlesModificar();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            BuscarLibro();
        }
        private void BuscarLibro()
        {
            Frm_Consultas frmConsultas = new Frm_Consultas();
            frmConsultas.ConBotones = true;
            frmConsultas.ShowDialog();
            Libro = frmConsultas.Libro;

            if (Libro != null)
            {
                txbClave.Text = Libro.clave;
                txbTitulo.Text = Libro.titulo;
                cmbAutor.SelectedValue = Libro.autor.id_catalogo;
                cmbArea.SelectedValue = Libro.area.id_catalogo;
                cmbEditorial.SelectedValue = Libro.editorial.id_catalogo;
                txbEdicion.Text = Libro.edicion;
                txbEjemplares.Text = Libro.no_ejemplares.ToString();
                txbAnio.Text = Libro.anio;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (tipoAccion)
            {
                case TipoAccion.Nuevo:
                    GuardarNuevo();
                    break;
                case TipoAccion.Modificar:
                    GuardarModificacion();
                    break;
            }
        }
        private void GuardarNuevo()
        {
            try
            {
                DialogResult drRespuesta = XtraMessageBox.Show("¿Son datos correctos?", "Nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ValidarNuevo() == true && drRespuesta == DialogResult.Yes)
                {
                    libros nuevoLibro = new libros();
                    nuevoLibro.clave = txbClave.Text.ToUpper();
                    nuevoLibro.titulo = txbTitulo.Text.ToUpper();
                    nuevoLibro.id_autor = Convert.ToInt32(cmbAutor.SelectedValue);
                    nuevoLibro.id_editorial = Convert.ToInt32(cmbEditorial.SelectedValue);
                    nuevoLibro.id_area = Convert.ToInt32(cmbArea.SelectedValue);
                    nuevoLibro.edicion = txbEdicion.Text.ToUpper();
                    nuevoLibro.anio = txbAnio.Text.ToUpper();
                    nuevoLibro.no_ejemplares = Convert.ToInt32(txbEjemplares.Text.ToUpper());

                    using (var Contexto = new BibliotecaEntities(Configuracion.ConnectionString))
                    {
                        Contexto.libros.AddObject(nuevoLibro);
                        Contexto.SaveChanges();
                    }

                    XtraMessageBox.Show("El libro fue agregado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Configuracion.MostrarExcepcion(ex), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarNuevo()
        {            
            if (txbClave.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("La clave no puede estar en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbTitulo.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("El titulo no puede estar en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbEdicion.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("La edición no puede estar en blanco", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbAnio.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("El año no puede estar en blanco", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbEjemplares.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("El numero ejemplares no puede estar en blanco", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void GuardarModificacion()
        {
            try
            {
                if (Libro == null)
                {
                    XtraMessageBox.Show("Seleccione un libro...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult drRespuesta = XtraMessageBox.Show("¿Son datos correctos?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ValidarNuevo() == true && drRespuesta == DialogResult.Yes)
                {
                    using (var Contexto = new BibliotecaEntities(Configuracion.ConnectionString))
                    {
                        libros libroModificado = Contexto.libros.FirstOrDefault(o => o.id_libro == Libro.id_libro);
                        if (libroModificado != null)
                        {
                            libroModificado.titulo = txbTitulo.Text.Trim().ToUpper();
                            libroModificado.id_autor = Convert.ToInt32(cmbAutor.SelectedValue);
                            libroModificado.id_editorial = Convert.ToInt32(cmbEditorial.SelectedValue);
                            libroModificado.id_area = Convert.ToInt32(cmbArea.SelectedValue);
                            libroModificado.edicion = txbEdicion.Text.Trim().ToUpper();
                            libroModificado.anio = txbAnio.Text.Trim().ToUpper();
                            libroModificado.no_ejemplares = Convert.ToInt32(txbEjemplares.Text.Trim().ToUpper());

                            Contexto.SaveChanges();

                            XtraMessageBox.Show("Modificación exitosa", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Configuracion.MostrarExcepcion(ex), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txbEjemplares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}