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
    public partial class pnReportes : UserControl
    {
        public pnReportes()
        {
            InitializeComponent();
        }

        private void cmdProveedores_Click(object sender, EventArgs e)
        {
            FrmReporteProveedores frm = new FrmReporteProveedores();
            frm.ShowDialog();
        }

        private void pnReportes_Load(object sender, EventArgs e)
        {

        }

        private void cmdDocumentos_Click(object sender, EventArgs e)
        {
            FrmReporteDocumentos frm = new FrmReporteDocumentos();
            frm.ShowDialog();
        }

        private void cmdConceptos_Click(object sender, EventArgs e)
        {
            FrmReportePagos frm = new FrmReportePagos();
            frm.ShowDialog();
        }
    }
}
