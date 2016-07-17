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
using MySql.Data.MySqlClient;

namespace BiblioTech.GUIs
{
    public partial class Frm_Config_App : XtraForm
    {
        List<string> lstDatabases;

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
                CargarBasesDeDatos();
        }

        private bool ProbarConexion()
        {
            try
            {
                cmbBasesDeDatos.Items.Clear();
                var localConfiguracion = Properties.Settings.Default;

                MySqlConnection MyConnection = new MySqlConnection();
                MySqlCommand MyCommand = new MySqlCommand();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                
                MySqlConnectionStringBuilder MyStringBuilder = new MySqlConnectionStringBuilder();
                MyStringBuilder.Server = localConfiguracion.ServidorBD;
                MyStringBuilder.UserID  = localConfiguracion.UsuarioBD;
                MyStringBuilder.Password = localConfiguracion.ContraseñaDB;
                MyStringBuilder.Port = Convert.ToUInt32(localConfiguracion.PuertoBD);

                MyConnection.ConnectionString = MyStringBuilder.ToString();
                MyConnection.Open();
                MyConnection.Close();
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void CargarBasesDeDatos()
        {
            try
            {
                cmbBasesDeDatos.Items.Clear();
                var localConfiguracion = Properties.Settings.Default;

                MySqlConnection MyConnection = new MySqlConnection();
                MySqlCommand MyCommand = new MySqlCommand();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();

                MySqlConnectionStringBuilder MyStringBuilder = new MySqlConnectionStringBuilder();
                MyStringBuilder.Server = localConfiguracion.ServidorBD;
                MyStringBuilder.UserID = localConfiguracion.UsuarioBD;
                MyStringBuilder.Password = localConfiguracion.ContraseñaDB;
                MyStringBuilder.Port = Convert.ToUInt32(localConfiguracion.PuertoBD);

                MyConnection.ConnectionString = MyStringBuilder.ToString();
                MyConnection.Open();

                MyCommand.Connection = MyConnection;
                MyCommand.CommandText = "SHOW DATABASES";

                MyAdapter.SelectCommand = MyCommand;
                DataTable TableDatabases = new DataTable();
                MyAdapter.Fill(TableDatabases);

                lstDatabases = new List<string>();
                foreach (DataRow Fila in TableDatabases.Rows)
                {
                    cmbBasesDeDatos.Items.Add(Fila["Database"]);
                }

                MyConnection.Close();
            }
            catch
            {

            }
        }
    }
}