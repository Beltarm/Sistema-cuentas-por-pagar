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
    public partial class PnMantenimientos : UserControl
    {
        public PnMantenimientos()
        {
            InitializeComponent();
        }

        private void btnManConceptoPago_Click(object sender, EventArgs e)
        {
            frmManConceptoPago frm = new frmManConceptoPago();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.ShowDialog();
        }
    }
}
