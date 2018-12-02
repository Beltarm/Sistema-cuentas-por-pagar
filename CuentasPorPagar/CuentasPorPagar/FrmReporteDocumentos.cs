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
    public partial class FrmReporteDocumentos : Form
    {
        Validaciones validar = new Validaciones();
        public FrmReporteDocumentos()
        {
            InitializeComponent();
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            FrmVisorReporteDocumentos frm = new FrmVisorReporteDocumentos();
            frm.NombreProveedor = txtNombreProveedor.Text;
            frm.ConceptoPago = txtConceptoPago.Text;
            frm.Estado = "";
            if (rbtPendiente.Checked)
            {
                frm.Estado = "Pendiente";
            }
            if (rbtPagado.Checked)
            {
                frm.Estado = "Pagado";
            }

            frm.NumFacturaDesde = "";
            if (txtFacturaDesde.TextLength > 0)
            {
                frm.NumFacturaDesde = txtFacturaDesde.Text;
            }
            frm.NumFacturaHasta = "";
            if (txtFacturaHasta.TextLength > 0)
            {
                frm.NumFacturaHasta = txtFacturaHasta.Text;
            }

            frm.FechaDocumentoDesde = "";
            if (mtbDocumentoDesde.MaskFull)
            {
                frm.FechaDocumentoDesde = mtbDocumentoDesde.Text;
            }

            frm.FechaDocumentoHasta = "";
            if (mtbDocumentoHasta.MaskFull)
            {
                frm.FechaDocumentoHasta = mtbDocumentoHasta.Text;
            }

            frm.FechaRegistroDesde = "";
            if (mtbRegistroDesde.MaskFull)
            {
                frm.FechaRegistroDesde = mtbRegistroDesde.Text;
            }

            frm.FechaRegistroHasta = "";
            if (mtbRegistroHasta.MaskFull)
            {
                frm.FechaRegistroHasta = mtbRegistroHasta.Text;
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

        private void FrmReporteDocumentos_Load(object sender, EventArgs e)
        {

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


        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
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

        private void mtbDocumentoDesde_Click(object sender, EventArgs e)
        {
            validar.validar_mask(mtbDocumentoDesde);
        }

        private void mtbRegistroDesde_Click(object sender, EventArgs e)
        {
            validar.validar_mask(mtbRegistroDesde);
        }

        private void mtbDocumentoHasta_Click(object sender, EventArgs e)
        {
            validar.validar_mask(mtbDocumentoHasta);
        }

        private void mtbRegistroHasta_Click(object sender, EventArgs e)
        {
            validar.validar_mask(mtbRegistroHasta);
        }
    }
}
