using System;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Entity;
using BiblioTech.Modelos;
using DevExpress.XtraEditors;

namespace BiblioTech.GUIs
{
    public partial class Frm_Login : XtraForm
    {
        BibliotecaEntities Contexto = new BibliotecaEntities(Configuracion.ConnectionString);
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
            IniciarSesion();
        }
        private void IniciarSesion()
        {
            Frm_Principal frmPrincipal = new Frm_Principal();

            try
            {
                string username = txbUsername.Text.ToUpper();
                string password = Configuracion.ObtenerMd5Hash(txbPassword.Text.ToUpper()).ToUpper();

                using (var Contexto = new BibliotecaEntities(Configuracion.ConnectionString))
                {
                    usuarios_app usuarioApp =
                        Contexto.usuarios_app.FirstOrDefault(o => o.nombre_usuario == username
                                                               && o.contrasenia == password
                                                               && o.estado == true);
                    if (usuarioApp != null)
                    {
                        Configuracion.usuarioApp = usuarioApp;
                        this.Hide();
                        frmPrincipal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Error en nombre de usuario o contraseña...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Configuracion.MostrarExcepcion(ex), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmPrincipal.ShowDialog();
            }
        }
        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            new Frm_Config_App().ShowDialog();
        }
    }
}