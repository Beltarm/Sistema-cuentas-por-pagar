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
    public partial class FrmReportePagos : Form
    {
        Validaciones validar = new Validaciones();
        public FrmReportePagos()
        {
            InitializeComponent();
        }


        private void cmdReporte_Click(object sender, EventArgs e)
        {
            FrmVisorReportesPagos frm = new FrmVisorReportesPagos();
            frm.Estado = "";
            if (rbtActivo.Checked)
            {
                frm.Estado = "Activo";
            }
            if (rbtInactivo.Checked)
            {
                frm.Estado = "Inactivo";
            }

       
            if (txtDocumentoDesde.TextLength > 0)
            {
                frm.NumeroDocumentoDesde = int.Parse(txtDocumentoDesde.Text);
            }
            if (txtDocumentoHasta.TextLength > 0)
            {
                frm.NumeroDocumentoHasta = int.Parse(txtDocumentoHasta.Text);
            }

            frm.NumeroFacturaPagarDesde = "";
            if (txtFacturaDesde.TextLength > 0)
            {
                frm.NumeroFacturaPagarDesde = txtFacturaDesde.Text;
            }
            frm.NumeroFacturaPagarHasta = "";
            if (txtFacturaHasta.TextLength > 0)
            {
                frm.NumeroFacturaPagarHasta = txtFacturaHasta.Text;
            }

            frm.FechaSolicitudDesde = "";
            if (mtbSolicitudDesde.MaskFull)
            {
                frm.FechaSolicitudDesde = mtbSolicitudDesde.Text;
            }

            frm.FechaSolicitudHasta = "";
            if (mtbSolicitudHasta.MaskFull)
            {
                frm.FechaSolicitudHasta = mtbSolicitudHasta.Text;
            }

            if (txtMontoDesde.TextLength > 0)
            {
                frm.MontoDesde = int.Parse(txtMontoDesde.Text);
            }
            if (txtMontoHasta.TextLength > 0)
            {
                frm.MontoHasta = int.Parse(txtMontoHasta.Text);
            }

            frm.ShowDialog();

        }

        private void txtDocumentoDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtDocumentoHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtFacturaDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtFacturaHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtMontoDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtMontoHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void mtbSolicitudDesde_Click(object sender, EventArgs e)
        {
            validar.validar_mask(mtbSolicitudDesde);
        }

        private void mtbSolicitudHasta_Click(object sender, EventArgs e)
        {
            validar.validar_mask(mtbSolicitudHasta);
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar_Campos_Reportes();
        }

        private void Limpiar_Campos_Reportes()
        {
            foreach (var item in panel1.Controls)
            {
                if (item is TextBoxBase)
                {
                    ((TextBoxBase)item).Text = String.Empty;
                }

                if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }

            }
        }
    }
}
