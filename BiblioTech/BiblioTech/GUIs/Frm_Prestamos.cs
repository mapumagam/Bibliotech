using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BiblioTech.Entity;
using BiblioTech.Modelos;
using DevExpress.XtraEditors;

namespace BiblioTech.GUIs
{
    public partial class Frm_Prestamos : XtraForm
    {
        private BibliotecaEntities Contexto;
        private List<libros> lstLibros;
        private usuarios Lector;
        private libros Libro;

        public Frm_Prestamos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarLector_Click(object sender, EventArgs e)
        {
            BuscarLector();   
        }
        private void BuscarLector()
        {
            Frm_Buscar_Lector frmBuscarLector = new Frm_Buscar_Lector();
            frmBuscarLector.ShowDialog();
            Lector = frmBuscarLector.usuario;

            if (Lector != null)
            {
                txbMatricula.Text = Lector.matricula;
            }
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            Frm_Consultas frmConsultas = new Frm_Consultas();
            frmConsultas.ConBotones = true;
            frmConsultas.ShowDialog();
            Libro = frmConsultas.Libro;
            if (Libro != null)
            {
                txbTitulo.Text = Libro.titulo + " - " + Libro.autor.descripcion;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarALaLista();
        }
        private void AgregarALaLista()
        {
            if (Libro != null)
            {
                if (ValidarPrestamo(Libro) == true)
                {
                    var LibroYaAgregado = lstLibros.FindAll(o=>o.id_libro==Libro.id_libro).Count;
                    if (LibroYaAgregado == 0)
                    {
                        lstLibros.Add(Libro);

                        gridPrestamos.DataSource = lstLibros;
                        gvPrestamos.BestFitColumns();
                    }
                    else
                    {
                        XtraMessageBox.Show("El libro '" + Libro.titulo + "' ya fue agregado",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("No hay ejemplares disponibles del libro " + Libro.titulo,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Primero debe seleccionar un libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Prestamos_Shown(object sender, EventArgs e)
        {
            lstLibros = new List<libros>();
            Contexto = new BibliotecaEntities(Configuracion.ConnectionString);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                RealizarPrestamo();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Configuracion.MostrarExcepcion(ex), ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RealizarPrestamo()
        {
            if (Lector == null)
            {
                // Falta el lector
                XtraMessageBox.Show("Debe seleccionar un lector.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (gvPrestamos.DataRowCount == 0)
            {
                // No hay libros
                XtraMessageBox.Show("No se han seleccionado libros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Todo Okay
                DialogResult dr =
                    XtraMessageBox.Show("¿Son datos correctos?", "Prestamos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    foreach (libros libroAPrestar in lstLibros)
                    {
                        using (BibliotecaEntities ContextoParaGuardar = new BibliotecaEntities(Configuracion.ConnectionString))
                        {
                            prestamos prestamo = new prestamos();

                            prestamo.matricula = Lector.matricula;
                            prestamo.id_libro = libroAPrestar.id_libro;
                            prestamo.id_usuario_app = 1;
                            prestamo.fecha_prestamo = DateTime.Today;
                            prestamo.fecha_entrega_sugerida = DateTime.Today.AddDays(5);

                            ContextoParaGuardar.prestamos.AddObject(prestamo);
                            ContextoParaGuardar.SaveChanges();
                        }
                    }

                    LimpiarFormulario();

                    XtraMessageBox.Show("Prestamo realizado con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidarPrestamo(libros libro)
        {
            // Se regresará 'true' solo si los libros prestados no exede el número de ejemplares de ese libro.
            long ejemplares = libro.no_ejemplares;
            long prestados = 
                Contexto
                    .prestamos
                    .ToList()
                    .FindAll(o => o.id_libro == libro.id_libro 
                               && o.fecha_entrega_real == null)
                    .ToList()
                    .Count;
            if (prestados < ejemplares)
            {
                return true;
            }

            return false;
        }

        private void LimpiarFormulario()
        {
            this.Lector = null;
            this.Libro = null;
            gridPrestamos.DataSource = null;
            gvPrestamos.BestFitColumns();
            txbMatricula.Text = string.Empty;
            txbTitulo.Text = string.Empty;
            lstLibros = new List<libros>();
        }
    }
}