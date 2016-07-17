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
    public partial class Frm_Login : XtraForm
    {
        BibliotecaEntities Contexto;

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Frm_Principal().ShowDialog();
            this.Close();
        }

        private void Frm_Login_Shown(object sender, EventArgs e)
        {
            try
            {
                Contexto = new BibliotecaEntities(Configuracion.ConnectionString);
                Contexto.Connection.Open();
                Contexto.Connection.Close();
            }
                
            catch (EntityException enex)
            {
                pbCargando.Visible = true;
                Application.DoEvents();

                DialogResult dr =
                MessageBox.Show("No fue posible conectar con el servidor de base de datos... por favor configure la aplicación para lograr el acceso.", 
                                "Configurar", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dr == DialogResult.Yes)
                    new Frm_Config_App().ShowDialog();

                pbCargando.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}