using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BiblioTech.Modelos;

namespace BiblioTech.GUIs
{
    public partial class Frm_Usuarios : XtraForm
    {
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
    }
}