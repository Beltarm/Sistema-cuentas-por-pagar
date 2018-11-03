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
    public partial class pnConfiguracion : UserControl
    {
        public pnConfiguracion()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmMantUsuarios frm = new FrmMantUsuarios();
            frm.ShowDialog();
        }
    }
}
