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
    public partial class FrmVisorReporteDocumentos : Form
    {

        public string NombreProveedor { get; set; }
        public string ConceptoPago { get; set; }
        public string Estado { get; set; }
        public string NumFacturaDesde { get; set; }
        public string NumFacturaHasta { get; set; }
        public string FechaDocumentoDesde { get; set; }
        public string FechaDocumentoHasta{ get; set; }
        public string FechaRegistroDesde { get; set; }
        public string FechaRegistroHasta { get; set; }
        public int MontoDesde { get; set; }
        public int MontoHasta { get; set; }

        public FrmVisorReporteDocumentos()
        {
            InitializeComponent();
        }


        private void FrmVisorReporteDocumentos_Load(object sender, EventArgs e)
        {

            SqlConnection ocon = new SqlConnection("Data Source=ana-alex-brian.database.windows.net;Initial Catalog=Cuentas_por_pagar;Persist Security Info=True;User ID=propietaria;Password=#Seguridad1");
            ocon.Open();
            string sSQL = "select * from Reporte_Documentos where 1 = 1";

            if (NombreProveedor.Trim().Length > 0)
            {
                sSQL += " and Nombre_Proveedor LIKE '%" + NombreProveedor + "%'";
            }

            if (ConceptoPago.Trim().Length > 0)
            {
                sSQL += " and  Concepto_Pago = '" + ConceptoPago + "'";
            }

            if (Estado.Trim().Length > 0)
            {
                sSQL += " and Estado = '" + Estado + "'";
            }

            if (NumFacturaDesde.Trim().Length > 0 && NumFacturaHasta.Trim().Length > 0)
            {
                sSQL += " and Numero_Factura between '" + NumFacturaDesde + "' and '" + NumFacturaHasta + "'";
            }
            else if (NumFacturaDesde.Trim().Length > 0)
            {
                sSQL += " and Numero_Factura > '" + NumFacturaDesde + "'";
            }
            else if(NumFacturaHasta.Trim().Length > 0)
            {
                sSQL += " and Numero_Factura < '" + NumFacturaHasta + "'";
            }

            if (FechaDocumentoDesde.Trim().Length > 0 && FechaDocumentoHasta.Trim().Length > 0 )
            {
                sSQL += " and Fecha_Documento between '" + FechaDocumentoDesde + "' and '" + FechaDocumentoHasta + "'";
            }
            else if (FechaDocumentoDesde.Trim().Length > 0)
            {
                sSQL += " and Fecha_Documento > '" + FechaDocumentoDesde + "'";
            }
            else if (FechaDocumentoHasta.Trim().Length > 0)
            {
                sSQL += " and Fecha_Documento < '" + FechaDocumentoHasta + "'";
            }

            if (FechaRegistroDesde.Trim().Length > 0 && FechaRegistroHasta.Trim().Length > 0)
            {
                sSQL += " and Fecha_Registro between '" + FechaRegistroDesde + "' and '" + FechaRegistroHasta + "'";
            }
            else if (FechaRegistroDesde.Trim().Length > 0)
            {
                sSQL += " and Fecha_Registro > '" + FechaRegistroDesde + "'";
            }
            else if (FechaRegistroHasta.Trim().Length > 0)
            {
                sSQL += " and Fecha_Registro < '" + FechaRegistroHasta + "'";
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
            rds.Name = "DataSetDocumentos";
            rpvDocumentos.LocalReport.DataSources.Clear();
            rpvDocumentos.LocalReport.DataSources.Add(rds);
            rpvDocumentos.LocalReport.ReportEmbeddedResource = "ReporteDocumentos.rdlc";
            rpvDocumentos.LocalReport.ReportPath = @"../../ReporteDocumentos.rdlc";
            rpvDocumentos.RefreshReport();
            // TODO: This line of code loads data into the 'DataSetDocumentos.Reporte_Documentos' table. You can move, or remove it, as needed.
            //this.Reporte_DocumentosTableAdapter.Fill(this.DataSetDocumentos.Reporte_Documentos);

            //this.rpvDocumentos.RefreshReport();
        }
    }
}
