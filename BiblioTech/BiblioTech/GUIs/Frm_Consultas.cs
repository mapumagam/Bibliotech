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

namespace BiblioTech.GUIs
{
    public partial class Frm_Consultas : XtraForm
    {
        private BibliotecaEntities ent = new BibliotecaEntities();

        public Frm_Consultas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<libros> lstLibros = ent.libros.ToList();
            gridConsulta.DataSource = lstLibros;
            gvConsulta.BestFitColumns();
        }


    }
}