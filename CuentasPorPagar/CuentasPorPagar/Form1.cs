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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Selector.Height = btnPanelPrincipal.Height;
            Selector.Top = btnPanelPrincipal.Top;
            pnPrincipal1.BringToFront();
        }

        private void btnPanelPrincipal_Click(object sender, EventArgs e)
        {
            Selector.Height = btnPanelPrincipal.Height;
            Selector.Top = btnPanelPrincipal.Top;
            pnPrincipal1.BringToFront();
        }

        private void btnPanelMantenimientos_Click(object sender, EventArgs e)
        {
            Selector.Height = btnPanelMantenimientos.Height;
            Selector.Top = btnPanelMantenimientos.Top;
            pnMantenimientos1.BringToFront();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}
