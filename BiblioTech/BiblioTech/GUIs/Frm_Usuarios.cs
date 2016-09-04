using System;
using BiblioTech.Modelos;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using BiblioTech.Entity;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections.Generic;

namespace BiblioTech.GUIs
{
    public partial class Frm_Usuarios : XtraForm
    {
        private usuarios Lector;
        private List<usuarios> lstLectores;
        private TipoAccion tipoAccion;

        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        private void Frm_Usuarios_Shown(object sender, EventArgs e)
        {
            InicializarCombos();
        }

        private void InicializarCombos()
        {
            cmbTipoLector.DataSource = Enum.GetValues(typeof(TipoLector));
        }
        private void inicializarComboLectores()
        {
            lstLectores = new List<usuarios>();
            using (var Contexto = new BibliotecaEntities(Configuracion.ConnectionString))
            {
                lstLectores = Contexto.usuarios.ToList().FindAll(o => o.tipo_usuario != "SU").ToList();
            }

            if (lstLectores.Count != 0)
            {
                cmbMatricula.DataSource = null;
                cmbMatricula.DataSource = lstLectores;
                cmbMatricula.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbMatricula.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbMatricula.DisplayMember = "matricula";
                cmbMatricula.ValueMember = "matricula";
            }
            else
            {
                XtraMessageBox.Show("Primero debe dar de alta al menos un lector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HabilitadoDeControles(false);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabilitadoDeControles(bool activado)
        {
            cmbMatricula.Enabled = activado;
            txbPrimerNombre.Enabled = activado;
            txbSegundoNombre.Enabled = activado;
            txbApellidoPaterno.Enabled = activado;
            txbApellidoMaterno.Enabled = activado;
            cmbTipoLector.Enabled = activado;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipoAccion = TipoAccion.Nuevo;
            cmbMatricula.DropDownStyle = ComboBoxStyle.Simple;
            HabilitadoDeControles(true);
            btnAccion.Text = "Guardar";
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipoAccion = TipoAccion.Modificar;
            cmbMatricula.DropDownStyle = ComboBoxStyle.DropDown;
            HabilitadoDeControles(true);
            inicializarComboLectores();
            btnAccion.Text = "Modificar";
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            switch (tipoAccion)
            {
                case TipoAccion.Nuevo: Nuevo();  break;
                case TipoAccion.Modificar: Modificar();  break;
            }
        }

        private void Nuevo()
        {
            try
            {
                DialogResult drRespuesta = XtraMessageBox.Show("¿Son datos correctos?", "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ValidarNuevo() == true && drRespuesta == DialogResult.Yes)
                {
                    usuarios lectorNuevo = new usuarios();
                    lectorNuevo.matricula = cmbMatricula.Text.ToUpper();
                    lectorNuevo.primer_nombre = txbPrimerNombre.Text.ToUpper();
                    lectorNuevo.segundo_nombre = txbSegundoNombre.Text.ToUpper();
                    lectorNuevo.apellido_paterno = txbApellidoPaterno.Text.ToUpper();
                    lectorNuevo.apellido_materno = txbApellidoMaterno.Text.ToUpper();
                    lectorNuevo.tipo_usuario = ((TipoLector)cmbTipoLector.SelectedItem).ToString().ToUpper();

                    using (var Contexto = new BibliotecaEntities(Configuracion.ConnectionString))
                    {
                        Contexto.Connection.Open();
                        var Transaccion = Contexto.Connection.BeginTransaction();

                        try
                        {                            
                            Contexto.usuarios.AddObject(lectorNuevo);
                            Contexto.SaveChanges();

                            Transaccion.Commit();
                            Contexto.Connection.Close();
                        }
                        catch(Exception ex)
                        {
                            string sMensaje = string.Empty;
                            string tipoException = string.Empty;
                            while (ex != null)
                            {
                                sMensaje += string.Format("{0}{1}", ex.Message, Environment.NewLine);
                                tipoException = ex.GetType().ToString();
                                ex = ex.InnerException;
                            }

                            if (sMensaje.ToUpper().Contains("DUPLICATE"))
                            {
                                XtraMessageBox.Show ("Ya existe un lector con la matricula: " + lectorNuevo.matricula,
                                                     tipoException, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            Transaccion.Rollback();
                            Contexto.Connection.Close();
                            return;                            
                        }
                    }

                    XtraMessageBox.Show("El lector ha sido dado de alta.", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Configuracion.MostrarExcepcion(ex), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarNuevo()
        {
            if (cmbMatricula.Text.Trim().ToUpper() == string.Empty)
            {
                XtraMessageBox.Show("Debe teclear una matricula o un identificador para el lector...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbPrimerNombre.Text.Trim().ToUpper() == string.Empty)
            {
                XtraMessageBox.Show("El primer nombre del lector es obligatorio...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbApellidoMaterno.Text.Trim().ToUpper() == string.Empty)
            {
                XtraMessageBox.Show("El apellido materno es obligatorio...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Modificar()
        {
            try
            {
                DialogResult drRespuesta = XtraMessageBox.Show("¿Son datos correctos?", "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ValidarNuevo() == true && drRespuesta == DialogResult.Yes)
                {
                    using (var Contexto = new BibliotecaEntities(Configuracion.ConnectionString))
                    {
                        Contexto.Connection.Open();
                        var Transaccion = Contexto.Connection.BeginTransaction();

                        try
                        {
                            var lectorModificar = Contexto.usuarios.FirstOrDefault(o=>o.matricula == Lector.matricula);
                            lectorModificar.primer_nombre = txbPrimerNombre.Text.ToUpper();
                            lectorModificar.segundo_nombre = txbSegundoNombre.Text.ToUpper();
                            lectorModificar.apellido_paterno = txbApellidoPaterno.Text.ToUpper();
                            lectorModificar.apellido_materno = txbApellidoMaterno.Text.ToUpper();
                            
                            var tipoUsuario = (TipoLector)cmbTipoLector.SelectedItem;
                            if (tipoUsuario == TipoLector.Alumno)
                                lectorModificar.tipo_usuario = "AL";
                            else if (tipoUsuario == TipoLector.Profesor)
                                lectorModificar.tipo_usuario = "PR";
                            else
                                lectorModificar.tipo_usuario = "OT";
                            
                            Contexto.SaveChanges();
                            
                            Transaccion.Commit();
                            Contexto.Connection.Close();
                        }
                        catch(Exception ex)
                        {
                            XtraMessageBox.Show(Configuracion.MostrarExcepcion(ex), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Transaccion.Rollback();
                            Contexto.Connection.Close();
                            return;                            
                        }
                    }

                    XtraMessageBox.Show("El lector ha modificado con éxito.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inicializarComboLectores();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Configuracion.MostrarExcepcion(ex), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lector = (usuarios)cmbMatricula.SelectedItem;
            if (Lector != null)
            {
                txbPrimerNombre.Text = Lector.primer_nombre;
                txbSegundoNombre.Text = Lector.segundo_nombre;
                txbApellidoPaterno.Text = Lector.apellido_paterno;
                txbApellidoMaterno.Text = Lector.apellido_materno;
                if (Lector.tipo_usuario == "AL")
                    cmbTipoLector.SelectedItem = TipoLector.Alumno;
                else if (Lector.tipo_usuario == "PR")
                    cmbTipoLector.SelectedItem = TipoLector.Profesor;
                else
                    cmbTipoLector.SelectedItem = TipoLector.Otro;
            }
        }
    }
}