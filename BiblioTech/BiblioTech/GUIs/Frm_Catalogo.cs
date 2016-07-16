using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BiblioTech.Modelos;

namespace BiblioTech.GUIs
{
    public partial class Frm_Catalogo : XtraForm
    {
        public TipoCatalogo tipoCatalogo;
        public TipoVentana tipoVentana;

        public Frm_Catalogo(TipoCatalogo tipoCatalogo, TipoVentana tipoVentana)
        {
            InitializeComponent();
            this.tipoCatalogo = tipoCatalogo;
            this.tipoVentana = tipoVentana;
        }

        private void Frm_Catalogo_Load(object sender, EventArgs e)
        {
            switch(tipoVentana)
            {
                case TipoVentana.Alta: AbrirCatalogo();
                    break;
                case TipoVentana.Modificacion: ModificarCatalogo();
                    break;
            }
        }
        private void AbrirCatalogo()
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
    }
}