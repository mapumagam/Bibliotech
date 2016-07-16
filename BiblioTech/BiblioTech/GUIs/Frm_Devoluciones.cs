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
    public partial class Frm_Devoluciones : XtraForm
    {
        usuarios Lector;
        BibliotecaEntities Contexto = new BibliotecaEntities();

        public Frm_Devoluciones()
        {
            InitializeComponent();
        }

        private void btnBuscarLector_Click(object sender, EventArgs e)
        {
            Lector = ObtenerLector();

            if (Lector != null)
            {
                ActualizarGrid(Lector);
            }
        }

        private usuarios ObtenerLector()
        {
            Frm_Buscar_Lector frmBuscarLector = new Frm_Buscar_Lector();
            frmBuscarLector.ShowDialog();

            usuarios usuario = frmBuscarLector.usuario;
            txbMatricula.Text = usuario.matricula + " - " + usuario.primer_nombre + " " +
                                usuario.segundo_nombre + " " + usuario.apellido_paterno + " " + usuario.apellido_materno;
            return usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                Devolver();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Devolver()
        {
            DialogResult dr = MessageBox.Show("¿Los datos son correctos?", "Devolver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                List<LibroDevolucion> lstLibrosSeleccionados = ObtenerLibrosSeleccionados();
                foreach(LibroDevolucion Devolucion in lstLibrosSeleccionados)
                {
                    prestamos libro = Contexto.prestamos.FirstOrDefault(o => o.id_libro == Devolucion.Libro.id_libro);
                    libro.fecha_entrega_real = DateTime.Today;
                }
                Contexto.SaveChanges();

                MessageBox.Show("¡La devolucion se ha efectuado con exito!");


                Lector = Contexto.usuarios.FirstOrDefault(o => o.matricula == Lector.matricula);
                ActualizarGrid(Lector);
            }
        }

        private List<LibroDevolucion> ObtenerLibrosSeleccionados()
        {
            List<LibroDevolucion> lstLibrosTotal = (List<LibroDevolucion>)gridConsulta.DataSource;
            List<LibroDevolucion> lstLibrosSeleccionados = lstLibrosTotal.FindAll(o => o.Seleccionado == true);

            return (lstLibrosSeleccionados);
        }

        private void ActualizarGrid(usuarios Lector)
        {
            LibroDevolucion PrestamosGrid;
            List<LibroDevolucion> LstPrestamosGrid = new List<LibroDevolucion>();
            var LibrosPrestados = Lector.prestamos.ToList().FindAll(o => o.fecha_entrega_real == null).ToList();

            foreach (prestamos prestamo in LibrosPrestados)
            {
                PrestamosGrid = new LibroDevolucion();
                PrestamosGrid.Libro = prestamo.libros;
                LstPrestamosGrid.Add(PrestamosGrid);
            }

            gridConsulta.DataSource = LstPrestamosGrid;
            gvConsulta.BestFitColumns();
        }

        private void Frm_Devoluciones_Load(object sender, EventArgs e)
        {
            Contexto = new BibliotecaEntities(Configuracion.ConnectionString);
        }
    }
}