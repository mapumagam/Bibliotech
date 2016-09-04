using System;
using BiblioTech.Modelos;
using DevExpress.XtraEditors;
using BiblioTech.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BiblioTech.GUIs
{
    public partial class Frm_Catalogo : XtraForm
    {
        private catalogos catalogo;
        public TipoCatalogo tipoCatalogo;
        public TipoVentana tipoVentana;

        public Frm_Catalogo(TipoCatalogo tipoCatalogo, TipoVentana tipoVentana, catalogos catalogo = null)
        {
            InitializeComponent();
            this.tipoCatalogo = tipoCatalogo;
            this.tipoVentana = tipoVentana;
            this.catalogo = catalogo;
        }

        private void Frm_Catalogo_Load(object sender, EventArgs e)
        {
            switch(tipoVentana)
            {
                case TipoVentana.Alta: NuevoCatalogo();
                    break;
                case TipoVentana.Modificacion: ModificarCatalogo();
                    break;
            }
        }
        private void NuevoCatalogo()
        {
            switch (tipoCatalogo)
            {
                case TipoCatalogo.Area:
                    Encabezados("Nueva Área", "Área:");
                    break;

                case TipoCatalogo.Autor:
                    Encabezados("Nuevo Autor", "Autor:");
                    break;

                case TipoCatalogo.Editorial:
                    Encabezados("Nueva Editorial", "Editorial:");
                    break;
            }
        }
        private void ModificarCatalogo()
        {
            txbDescripcion.Text = catalogo.descripcion.ToUpper();
            btnGuardar.Text = "Modificar";

            switch (tipoCatalogo)
            {
                case TipoCatalogo.Area:
                    Encabezados("Modificar Área", "Área:");
                    
                    break;

                case TipoCatalogo.Autor:
                    Encabezados("Modificar Autor", "Autor:");
                    break;

                case TipoCatalogo.Editorial:
                    Encabezados("Modificar Editorial", "Editorial:");
                    break;
            }            
        }

        private void Encabezados(string Titulo, string Etiqueta)
        {
            this.Text = Titulo;
            lblTitulo.Text = Titulo;
            lblCatalogo.Text = Etiqueta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (tipoVentana)
            {
                case TipoVentana.Alta:          Nuevo();        break;
                case TipoVentana.Modificacion:  Modificar();    break;
            }
        }
        private void Nuevo()
        {
            DialogResult drRespuesta = XtraMessageBox.Show("¿Son datos correctos?", "Validar", MessageBoxButtons.YesNo);

            if (drRespuesta == DialogResult.Yes)
            {
                using (var Contexto = new BibliotecaEntities(Configuracion.ConnectionString))
                {
                    catalogos nuevoCatalogo = new catalogos();
                    nuevoCatalogo.descripcion = txbDescripcion.Text.ToUpper();
                    switch (tipoCatalogo)
                    {
                        case TipoCatalogo.Area:         nuevoCatalogo.tipo = "AR";      break;
                        case TipoCatalogo.Autor:        nuevoCatalogo.tipo = "AU";      break;
                        case TipoCatalogo.Editorial:    nuevoCatalogo.tipo = "ED";      break;
                    }

                    Contexto.catalogos.AddObject(nuevoCatalogo);                    
                    Contexto.SaveChanges();
                    
                    XtraMessageBox.Show("El alta se ha realizado con éxito.", "Nuevo", MessageBoxButtons.OK);
                }
            }
        }
        private void Modificar()
        {
            DialogResult drRespuesta = XtraMessageBox.Show("¿Seguro que desea modificar el catalogo?", "Validar", MessageBoxButtons.YesNo);

            if (drRespuesta == DialogResult.Yes)
            {
                using (var Contexto = new BibliotecaEntities(Configuracion.ConnectionString))
                {
                    catalogos catalogoModificar = Contexto.catalogos.FirstOrDefault(o => o.id_catalogo == catalogo.id_catalogo);
                    catalogoModificar.descripcion = txbDescripcion.Text.ToUpper();

                    Contexto.SaveChanges();

                    XtraMessageBox.Show("Modificación relizada con éxito.", "Modificar", MessageBoxButtons.OK);
                }
            }
        }
    }
}