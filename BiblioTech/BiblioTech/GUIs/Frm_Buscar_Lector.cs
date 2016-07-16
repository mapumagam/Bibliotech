using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BiblioTech.Entity;
using BiblioTech.Modelos;

namespace BiblioTech.GUIs
{
    public partial class Frm_Buscar_Lector : DevExpress.XtraEditors.XtraForm
    {
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
            List<usuarios> lstUsuarios = Contexto.usuarios.OrderBy(o=>o.primer_nombre).ToList();

            foreach (usuarios lector in lstUsuarios)
            {
                usuariobusqueda = new UsuarioBusqueda();
                usuariobusqueda.Lector = lector;
                this.lstUsuariosBusqueda.Add(usuariobusqueda);
            }

            gridLectores.DataSource = lstUsuariosBusqueda;
            gvLectores.BestFitColumns();
        }

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
    }
}