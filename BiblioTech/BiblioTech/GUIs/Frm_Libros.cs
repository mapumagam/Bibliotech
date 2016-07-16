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
using BiblioTech.Entity;

namespace BiblioTech.GUIs
{
    public partial class Frm_Libros : XtraForm
    {
        private BibliotecaEntities Contexto;
        public Frm_Libros()
        {
            InitializeComponent();
        }

        private void Frm_Libros_Load(object sender, EventArgs e)
        {
            Contexto = new BibliotecaEntities();            
        }

        private void InicializarCombos()
        {
            List<catalogos> lstCatalogos = Contexto.catalogos.ToList();

            cmbArea.DataSource = lstCatalogos.FindAll(o => o.tipo == "AR").OrderBy(o=>o.descripcion).ToList();
            cmbArea.DisplayMember = "descripcion";
            cmbAutor.DataSource = lstCatalogos.FindAll(o => o.tipo == "AU").OrderBy(o => o.descripcion).ToList();
            cmbAutor.DisplayMember = "descripcion";
            cmbEditorial.DataSource = lstCatalogos.FindAll(o => o.tipo == "ED").OrderBy(o => o.descripcion).ToList();
            cmbEditorial.DisplayMember = "descripcion";
        }

        private void cmiNuevo_Click(object sender, EventArgs e)
        {
            new Frm_Catalogo(TipoCatalogo.Editorial, TipoVentana.Alta).ShowDialog();
        }

        private void cmiAbrir_Click(object sender, EventArgs e)
        {
            new Frm_Catalogo(TipoCatalogo.Editorial, TipoVentana.Modificacion).ShowDialog();
        }

        private void cmiNuevoAU_Click(object sender, EventArgs e)
        {
            new Frm_Catalogo(TipoCatalogo.Autor, TipoVentana.Alta).ShowDialog();
        }

        private void cmiAbrirAU_Click(object sender, EventArgs e)
        {
            new Frm_Catalogo(TipoCatalogo.Autor, TipoVentana.Modificacion).ShowDialog();
        }

        private void cmiNuevaAR_Click(object sender, EventArgs e)
        {
            new Frm_Catalogo(TipoCatalogo.Area, TipoVentana.Alta).ShowDialog();
        }

        private void cmiAbrirAR_Click(object sender, EventArgs e)
        {
            new Frm_Catalogo(TipoCatalogo.Area, TipoVentana.Modificacion).ShowDialog();
        }

        private void Frm_Libros_Shown(object sender, EventArgs e)
        {
            InicializarCombos();
        }
    }
}