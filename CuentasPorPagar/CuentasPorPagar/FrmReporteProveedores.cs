using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorPagar
{
    public partial class FrmReporteProveedores : Form
    {
        public FrmReporteProveedores()
        {
            InitializeComponent();
        }

        private void FrmReporteProveedores_Load(object sender, EventArgs e)
        {

        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            FrmVisorReporteProveedores frm = new FrmVisorReporteProveedores();
            frm.Nombre = txtNombre.Text;
            if(txtBalanceDesde.TextLength > 0)
            {
                frm.BalanceDesde = double.Parse(txtBalanceDesde.Text);
            }
            if(txtBalanceHasta.TextLength > 0)
            {
                frm.BalanceHasta = double.Parse(txtBalanceHasta.Text);
            }
            frm.TipoPersona = "";
            if (rbtFisica.Checked)
            {
                frm.TipoPersona = "F";
            }
            if (rbtJuridica.Checked)
            {
                frm.TipoPersona = "J";
            }
              
            frm.Estado = "";
            if (rbtActivo.Checked)
            {
                frm.Estado = "A";
            }
            if (rbtInactivo.Checked)
            {
                frm.Estado = "I";
            }
                
            frm.ShowDialog();
        }
    }
}
