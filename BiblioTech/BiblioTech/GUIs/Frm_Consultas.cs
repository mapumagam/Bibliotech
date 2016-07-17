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
    public partial class Frm_Consultas : XtraForm
    {
        BibliotecaEntities Contexto;

        public Frm_Consultas(int i)
        {
            InitializeComponent();
        }

        public Frm_Consultas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<libros> lstLibros = Contexto.libros.ToList();
            gridConsulta.DataSource = lstLibros;
            gvConsulta.BestFitColumns();
        }

        private void Frm_Consultas_Shown(object sender, EventArgs e)
        {
            Contexto = new BibliotecaEntities(Configuracion.ConnectionString);
        }


    }
}