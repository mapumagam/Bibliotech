using System;
using System.Windows.Forms;
using BiblioTech.Modelos;
using DevExpress.XtraEditors;
using BiblioTech.Entity;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace BiblioTech.GUIs
{
    public partial class Frm_UsuariosApp : XtraForm
    {
        List<usuarios_app> lstUsuariosApp;
        TipoAccion tipoAccion;

        public Frm_UsuariosApp()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarControlesNuevo();
            InicializarNuevo();
        }
        private void InicializarNuevo()
        {
            cmbNombreCompleto.DataSource = null;
            cmbNombreCompleto.DropDownStyle = ComboBoxStyle.Simple;
            cmbNombreCompleto.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbNombreCompleto.Enabled = true;
            txbUsername.Enabled = true;
            txbPassword.Enabled = true;
            chkAdmin.Enabled = true;
            chkConsulta.Enabled = true;
            chkReportes.Enabled = true;

            btnAccion.Text = "Guardar";
            btnAccion.Visible = true;
            btnBorrar.Visible = false;
            tipoAccion = TipoAccion.Nuevo;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicializarModificar();
        }
        private void InicializarModificar()
        {
            cmbNombreCompleto.Enabled = true;
            cmbNombreCompleto.DropDownStyle = ComboBoxStyle.DropDown;
            InicializarComboBox();

            txbUsername.Enabled = false;
            txbPassword.Enabled = true;
            chkAdmin.Enabled = true;
            chkConsulta.Enabled = true;
            chkReportes.Enabled = true;

            btnAccion.Text = "Modificar";
            btnAccion.Visible = true;
            btnBorrar.Visible = true;
            tipoAccion = TipoAccion.Modificar;
        }
        private void InicializarComboBox()
        {
            using (BibliotecaEntities Contexto = new BibliotecaEntities(Configuracion.ConnectionString))
            {
                lstUsuariosApp = 
                    Contexto
                        .usuarios_app
                        .ToList()
                        .FindAll(o => o.estado == true 
                                   && o.id_usuario != 1 
                                   && o.id_usuario != Configuracion.usuarioApp.id_usuario)
                        .ToList();
            }

            if (lstUsuariosApp.Count != 0)
            {
                btnBorrar.Enabled = true;
                cmbNombreCompleto.DataSource = lstUsuariosApp;
                cmbNombreCompleto.DisplayMember = "nombre_completo";
                cmbNombreCompleto.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbNombreCompleto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbNombreCompleto.SelectedIndex = 0;
            }
            else
            {
                cmbNombreCompleto.DataSource = null;
                btnBorrar.Enabled = false;
            }
        }

        private void LimpiarControlesNuevo()
        {
            cmbNombreCompleto.Text = string.Empty;
            txbUsername.Text = string.Empty;
            txbPassword.Text = string.Empty;
            chkAdmin.Checked = false;
            chkConsulta.Checked = false;
            chkReportes.Checked = false;
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            switch (tipoAccion)
            {
                case TipoAccion.Nuevo:
                    try
                    {
                        if (ValidarNuevo() == true)
                        {
                            GuardarNuevo();
                            LimpiarControlesNuevo();
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(Configuracion.MostrarExcepcion(ex), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case TipoAccion.Modificar:
                    try
                    {
                        Modificar();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(Configuracion.MostrarExcepcion(ex), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void GuardarNuevo()
        {
            using (BibliotecaEntities Contexto = new BibliotecaEntities(Configuracion.ConnectionString))
            {
                usuarios_app usuario = new usuarios_app();
                usuario.nombre_completo = cmbNombreCompleto.Text.ToUpper();
                usuario.nombre_usuario = txbUsername.Text.ToUpper();
                usuario.contrasenia = Configuracion.ObtenerMd5Hash(txbPassword.Text.ToUpper()).ToUpper();
                usuario.permisos = ObtenerPermisos();
                usuario.estado = true;

                Contexto.usuarios_app.AddObject(usuario);
                Contexto.SaveChanges();
            }

            XtraMessageBox.Show("El alta se realizó con éxito.", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool ValidarNuevo()
        {
            if (cmbNombreCompleto.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Por favor teclee el nombre completo del usuario...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txbUsername.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Por favor teclee el nombre de usuario...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txbPassword.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Por favor teclee una contraseña...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if ((!chkAdmin.Checked) && (!chkConsulta.Checked) && (!chkReportes.Checked))
            {
                XtraMessageBox.Show("Por favor Seleccione al menos un permiso...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        
        private void Modificar()
        {
            if (cmbNombreCompleto.DataSource == null)
            {
                XtraMessageBox.Show("No hay usuarios para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var usuarioApp = (usuarios_app)cmbNombreCompleto.SelectedItem;

                DialogResult drRespuesta = 
                    XtraMessageBox.Show(string.Format("¿Desea modificar al usuario {0}?",usuarioApp.nombre_completo), "Modificar", 
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drRespuesta == DialogResult.Yes)
                {
                    using (var Contexto = new BibliotecaEntities(Configuracion.ConnectionString))
                    {
                        var usuarioAModificar = Contexto.usuarios_app.FirstOrDefault(o => o.id_usuario == usuarioApp.id_usuario);

                        if (txbPassword.Text.Trim() != string.Empty)
                            usuarioAModificar.contrasenia = Configuracion.ObtenerMd5Hash(usuarioApp.contrasenia);
                        
                        usuarioAModificar.permisos = ObtenerPermisos();

                        Contexto.SaveChanges();
                    }

                    XtraMessageBox.Show("Modificación exitosa.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private string ObtenerPermisos()
        {
            StringBuilder sbPermisos = new StringBuilder();

            if (chkAdmin.Checked) sbPermisos.Append("ADMINISTRACION");
            if (chkConsulta.Checked) sbPermisos.Append("CONSULTA");
            if (chkReportes.Checked) sbPermisos.Append("REPORTES");

            return sbPermisos.ToString();
        }

        private void Frm_UsuariosApp_Shown(object sender, EventArgs e)
        {
            lstUsuariosApp = new List<usuarios_app>();
        }

        private void cmbNombreCompleto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var usuairoApp = (usuarios_app)cmbNombreCompleto.SelectedItem;

            if (usuairoApp != null)
            {
                txbUsername.Text = usuairoApp.nombre_usuario.ToUpper();
                txbPassword.Text = string.Empty;

                if (usuairoApp.permisos.Contains("ADMINISTRACION")) { chkAdmin.Checked = true; }
                else { chkAdmin.Checked = false; }
                if (usuairoApp.permisos.Contains("CONSULTA")) { chkConsulta.Checked = true; }
                else { chkConsulta.Checked = false; }
                if (usuairoApp.permisos.Contains("REPORTES")) { chkReportes.Checked = true; }
                else { chkReportes.Checked = false; }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarUsuario();
        }
        private void BorrarUsuario()
        {
            try
            {
                usuarios_app usuarioApp = (usuarios_app)cmbNombreCompleto.SelectedItem;

                DialogResult drRespuesta =
                    XtraMessageBox.Show(string.Format("¿Desea eliminar al usuario {0}?", usuarioApp.nombre_completo), "Eliminar", 
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (drRespuesta == DialogResult.Yes)
                {
                    using (BibliotecaEntities Contexto = new BibliotecaEntities(Configuracion.ConnectionString))
                    {
                        var usuarioABorrar = Contexto.usuarios_app.FirstOrDefault(o => o.id_usuario == usuarioApp.id_usuario);
                        usuarioABorrar.estado = false;
                        Contexto.SaveChanges();
                    }

                    XtraMessageBox.Show("Usuario dado de baja", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarControlesNuevo();
                    InicializarComboBox();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Configuracion.MostrarExcepcion(ex), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}