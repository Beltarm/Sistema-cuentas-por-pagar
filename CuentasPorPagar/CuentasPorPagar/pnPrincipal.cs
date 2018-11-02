using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorPagar
{
    public partial class pnPrincipal : UserControl
    {
        public string modo = "";
        public pnPrincipal()
        {
            InitializeComponent();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.modo = modo;
            frm.ShowDialog();
        }

        private void btnConceptos_Click(object sender, EventArgs e)
        {
            frmManConceptoPago frm = new frmManConceptoPago();
            frm.modo = modo;
            frm.ShowDialog();
        }
    }
}
