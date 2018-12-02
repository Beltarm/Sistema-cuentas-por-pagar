using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorPagar
{
    public partial class FrmVisorReportesPagos : Form
    {
        public string Estado { get; set; }
        public int NumeroDocumentoDesde { get; set; }
        public int NumeroDocumentoHasta { get; set; }
        public string NumeroFacturaPagarDesde { get; set; }
        public string NumeroFacturaPagarHasta { get; set; }
        public string FechaSolicitudDesde { get; set; }
        public string FechaSolicitudHasta { get; set; }
        public int MontoDesde { get; set; }
        public int MontoHasta { get; set; }

        public FrmVisorReportesPagos()
        {
            InitializeComponent();
        }

        private void FrmVisorReportesPagos_Load(object sender, EventArgs e)
        {

            SqlConnection ocon = new SqlConnection("Data Source=ana-alex-brian.database.windows.net;Initial Catalog=Cuentas_por_pagar;Persist Security Info=True;User ID=propietaria;Password=#Seguridad1");
            ocon.Open();
            string sSQL = "select * from Solicitud_Pago_Proveedor where 1 = 1";

            if (Estado.Trim().Length > 0)
            {
                sSQL += " and Estado = '" + Estado + "'";
            }

            if (NumeroDocumentoDesde > 0 && NumeroDocumentoHasta > 0)
            {
                sSQL += " and Num_Documento between " + NumeroDocumentoDesde + " and " + NumeroDocumentoHasta;
            }
            else if (NumeroDocumentoDesde > 0)
            {
                sSQL += " and Num_Documento > " + NumeroDocumentoDesde;
            }
            else if (NumeroDocumentoHasta > 0)
            {
                sSQL += " and Num_Documento < " + NumeroDocumentoHasta;
            }


            if (NumeroFacturaPagarDesde.Trim().Length > 0 && NumeroFacturaPagarHasta.Trim().Length > 0)
            {
                sSQL += " and Num_Factura_Pagar between '" + NumeroFacturaPagarDesde + "' and '" + NumeroFacturaPagarHasta + "'";
            }
            else if (NumeroFacturaPagarDesde.Trim().Length > 0)
            {
                sSQL += " and Num_Factura_Pagar > '" + NumeroFacturaPagarDesde + "'";
            }
            else if (NumeroFacturaPagarHasta.Trim().Length > 0)
            {
                sSQL += " and Num_Factura_Pagar < '" + NumeroFacturaPagarHasta + "'";
            }

            if (FechaSolicitudDesde.Trim().Length > 0 && FechaSolicitudHasta.Trim().Length > 0)
            {
                sSQL += " and Fecha between '" + FechaSolicitudDesde + "' and '" + FechaSolicitudHasta + "'";
            }
            else if (FechaSolicitudDesde.Trim().Length > 0)
            {
                sSQL += " and Fecha > '" + FechaSolicitudDesde + "'";
            }
            else if (FechaSolicitudHasta.Trim().Length > 0)
            {
                sSQL += " and Fecha < '" + FechaSolicitudHasta + "'";
            }


            if (MontoDesde > 0 && MontoHasta > 0)
            {
                sSQL += " and Monto between " + MontoDesde + " and " + MontoHasta;
            }
            else if (MontoDesde > 0)
            {
                sSQL += " and Monto > " + MontoDesde;
            }
            else if (MontoHasta > 0)
            {
                sSQL += " and Monto < " + MontoHasta;
            }

            DataTable odt = new DataTable();
            SqlDataAdapter oda = new SqlDataAdapter(sSQL, ocon);
            oda.Fill(odt);

            ReportDataSource rds = new ReportDataSource();
            rds.Value = odt;
            rds.Name = "DataSetPagos";
            rpvPagos.LocalReport.DataSources.Clear();
            rpvPagos.LocalReport.DataSources.Add(rds);
            rpvPagos.LocalReport.ReportEmbeddedResource = "ReportePagos.rdlc";
            rpvPagos.LocalReport.ReportPath = @"../../ReportePagos.rdlc";
            rpvPagos.RefreshReport();
            //// TODO: This line of code loads data into the 'DataSetPagos.Solicitud_Pago_Proveedor' table. You can move, or remove it, as needed.
            //this.Solicitud_Pago_ProveedorTableAdapter.Fill(this.DataSetPagos.Solicitud_Pago_Proveedor);

            //this.reportViewer1.RefreshReport();
        }
    }
}
