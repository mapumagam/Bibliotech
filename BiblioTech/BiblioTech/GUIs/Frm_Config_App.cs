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
using System.Data.Common;

namespace BiblioTech.GUIs
{
    public partial class Frm_Config_App : XtraForm
    {
        public Frm_Config_App()
        {
            InitializeComponent();
        }

        private void Frm_Config_App_Shown(object sender, EventArgs e)
        {
            var Configuracion = Properties.Settings.Default;

            txbServidor.Text = Configuracion.ServidorBD;
            txbUsuario.Text = Configuracion.UsuarioBD;
            txbContraseña.Text = Configuracion.ContraseñaDB;
            txbPuerto.Text = Configuracion.PuertoBD;
        }

        private void cmbBasesDeDatos_Click(object sender, EventArgs e)
        {
            PoblarComboBox();
        }
        private void PoblarComboBox()
        {
            var localConfiguracion = Properties.Settings.Default;

            localConfiguracion.ServidorBD = txbServidor.Text;
            localConfiguracion.UsuarioBD = txbUsuario.Text;
            localConfiguracion.ContraseñaDB = txbContraseña.Text;
            localConfiguracion.PuertoBD = txbPuerto.Text;
            localConfiguracion.Save();

            if (ProbarConexion() == true)
            {
                BibliotecaEntities Contexto = new BibliotecaEntities(Configuracion.ConnectionString);
                Contexto.ExecuteStoreCommand("Show Databases", null);
                Contexto.Dispose();
            }
        }

        private bool ProbarConexion()
        {
            try
            {
                BibliotecaEntities Contexto = new BibliotecaEntities(Configuracion.ConnectionString);

                Contexto.Connection.Open();
                var comm = Contexto.Connection.CreateCommand();
                
                comm.CommandText = "Show Databases";
                var reader = comm.ExecuteReader();

                List<string> lstReader = new List<string>();
                while (reader.NextResult() == true)
                {
                    lstReader.Add((string)reader.GetValue(0));
                }

                Contexto.Connection.Close();

                Contexto.Dispose();

                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}