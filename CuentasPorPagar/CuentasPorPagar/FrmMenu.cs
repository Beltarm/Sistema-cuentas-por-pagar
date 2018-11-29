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
    public partial class FrmMenu : Form
    {
        public int xClick = 0, yClick = 0;
        public string modo = "";

        public FrmMenu()
        {
            InitializeComponent();
            Selector.Height = btnPanelPrincipal.Height;
            Selector.Top = btnPanelPrincipal.Top;
            pnPrincipal.BringToFront();
            
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if (modo == "user")
            {
                btnConfiguracion.Enabled = false;
                btnPanelMantenimientos.Enabled = false;
                pnPrincipal.modo = "user";
                
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClick = e.X; yClick = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - xClick);
                this.Top = this.Top + (e.Y - yClick);
            }
        }

        private void btnPanelPrincipal_Click(object sender, EventArgs e)
        {
            Selector.Height = btnPanelPrincipal.Height;
            Selector.Top = btnPanelPrincipal.Top;
            pnPrincipal.BringToFront();
        }

        private void btnPanelMantenimientos_Click(object sender, EventArgs e)
        {
            Selector.Height = btnPanelMantenimientos.Height;
            Selector.Top = btnPanelMantenimientos.Top;
            pnMantenimientos1.BringToFront();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Selector.Height = btnConfiguracion.Height;
            Selector.Top = btnConfiguracion.Top;
            pnConfiguracion1.BringToFront();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Selector.Height = btnReportes.Height;
            Selector.Top = btnReportes.Top;
            pnReportes1.BringToFront();
            
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            Selector.Height = btnReportes.Height;
            Selector.Top = btnReportes.Top;
            pnReportes1.BringToFront();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
    }
}
