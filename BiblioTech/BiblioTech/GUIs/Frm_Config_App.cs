using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BiblioTech.Modelos;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace BiblioTech.GUIs
{
    public partial class Frm_Config_App : XtraForm
    {
        private MySqlConnection MyConexion;
        private MySqlCommand MyComando;
        private MySqlDataAdapter MyAdapter;

        public Frm_Config_App()
        {
            InitializeComponent();
        }

        private void Frm_Config_App_Shown(object sender, EventArgs e)
        {
            MyConexion = new MySqlConnection();
            MyComando = new MySqlCommand();
            MyAdapter = new MySqlDataAdapter();

            var Configuracion = Properties.Settings.Default;

            txbServidor.Text = Configuracion.ServidorBD;
            txbUsuario.Text = Configuracion.UsuarioBD;
            txbContraseña.Text = Configuracion.ContraseñaDB;
            txbPuerto.Text = Configuracion.PuertoBD;
        }

        private string ObtenerStringDeConexion()
        {
            MySqlConnectionStringBuilder StringDeConexion = new MySqlConnectionStringBuilder();
            var Configuraciones = Properties.Settings.Default;

            StringDeConexion.Server = txbServidor.Text;
            StringDeConexion.UserID = txbUsuario.Text;
            StringDeConexion.Password = txbContraseña.Text;
            StringDeConexion.Port = Convert.ToUInt32(txbPuerto.Text);

            return StringDeConexion.ToString();
        }
        private void PoblarComboBox()
        {
            List<string> lstBasesDeDatos = new List<string>();
            MyConexion.ConnectionString = ObtenerStringDeConexion();
            try
            {
                MyConexion.Open();

                MyComando.Connection = MyConexion;
                MyComando.CommandText = "Show Databases";

                DataTable dtBasesDeDatos = new DataTable();
                MyAdapter.SelectCommand = MyComando;
                MyAdapter.Fill(dtBasesDeDatos);

                
                foreach (DataRow Fila in dtBasesDeDatos.Rows)
                {
                    lstBasesDeDatos.Add(Convert.ToString(Fila["Database"]));
                }             
            }
            catch
            {
                XtraMessageBox.Show("No se pudo abrir la conexión a la base de datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (MyConexion.State != ConnectionState.Closed)
            {
                MyConexion.Close();
            }

            cmbBasesDeDatos.DataSource = lstBasesDeDatos;
        }

        private void btn_CargarBases_Click(object sender, EventArgs e)
        {
            PoblarComboBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            string baseDedatos = string.Empty;
            if (cmbBasesDeDatos.Items.Count != 0)
                baseDedatos = Convert.ToString(cmbBasesDeDatos.SelectedItem);

            var Configuraciones = Properties.Settings.Default;
            Configuraciones.ServidorBD = txbServidor.Text;
            Configuraciones.UsuarioBD = txbUsuario.Text;
            Configuraciones.ContraseñaDB = txbContraseña.Text;
            Configuraciones.PuertoBD = txbPuerto.Text;
            Configuraciones.BaseDeDatos = baseDedatos;
            Configuraciones.Save();

            XtraMessageBox.Show("Los datos fueron guardados con exito.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txbPuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}