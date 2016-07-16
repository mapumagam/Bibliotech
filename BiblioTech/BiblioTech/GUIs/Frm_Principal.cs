using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;

namespace BiblioTech.GUIs
{
    public partial class Frm_Principal : XtraForm
    {
        private Frm_Libros frmLibros;
        private Frm_Usuarios frmUsuarios;
        private Frm_Perdidos frmPerdidos;
        private Frm_Consultas frmConsultas;
        private Frm_Prestamos frmPrestamos;
        private Frm_Config_App frmConfigApp;
        private Frm_Devoluciones frmDevoluciones;

        public Frm_Principal()
        {
            InitializeComponent();
        }
        private void CrearFormulario<T>(ref T Frm) where T : new()
        {
            Frm = new T();

            Type thisType = Frm.GetType();
            MethodInfo theMethod = thisType.GetMethod("Dispose"); 
            theMethod.Invoke(Frm, null); 
        }
        private void InicializarFormularios()
        {
            CrearFormulario(ref frmUsuarios);
            CrearFormulario(ref frmConsultas);
            CrearFormulario(ref frmLibros);
            CrearFormulario(ref frmPerdidos);
            CrearFormulario(ref frmPrestamos);
            CrearFormulario(ref frmConfigApp);
            CrearFormulario(ref frmDevoluciones);
        }
        private void MostrarFormulario<T>(ref T Frm) where T : new()
        {
            bool bIsDisposed = false;

            bIsDisposed = (bool)Frm.GetType().GetProperty("IsDisposed").GetValue(Frm, new Type[0]); 
            if (bIsDisposed)
            {
                Frm = new T();
                Frm.GetType().GetProperty("MdiParent").SetValue(Frm, this, new Type[0]);
                Frm.GetType().GetProperty("WindowState").SetValue(Frm, FormWindowState.Maximized, new Type[0]);
                Frm.GetType().GetMethod("Show", new Type[0]).Invoke(Frm, new object[0]);
            }
            else
            {
                Frm.GetType().GetProperty("WindowState").SetValue(Frm, FormWindowState.Maximized, new Type[0]);
            }
        }

        private void navItemUsuarios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MostrarFormulario(ref frmUsuarios);
        }
        private void navItemConsultar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MostrarFormulario(ref frmConsultas);
        }
        private void navItemLibros_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MostrarFormulario(ref frmLibros);
        }
        private void navItemPrestamo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MostrarFormulario(ref frmPrestamos);
        }
        private void navItemAplicacion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MostrarFormulario(ref frmConfigApp);
        }
        private void navItemPerdidos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MostrarFormulario(ref frmPerdidos);
        }
        private void navItemDevolucion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MostrarFormulario(ref frmDevoluciones);
        }

        private void Frm_Principal_Shown(object sender, EventArgs e)
        {
            InicializarFormularios();
            this.BackgroundImage = new Bitmap(@"./Resources/Library mini.jpg");
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}