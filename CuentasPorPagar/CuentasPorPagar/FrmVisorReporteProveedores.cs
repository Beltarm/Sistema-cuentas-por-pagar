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
    public partial class FrmVisorReporteProveedores : Form
    {
        public string Nombre { get; set; }
        public double BalanceDesde { get; set; }
        public double BalanceHasta { get; set; }
        public string TipoPersona { get; set; }
        public string Estado { get; set; }


        public FrmVisorReporteProveedores()
        {
            InitializeComponent();
        }

        private void FrmVisorReporteProveedores_Load(object sender, EventArgs e)
        {

            SqlConnection ocon = new SqlConnection("Data Source=ana-alex-brian.database.windows.net;Initial Catalog=Cuentas_por_pagar;Persist Security Info=True;User ID=propietaria;Password=#Seguridad1");
            ocon.Open();
            string sSQL = "select * from Proveedores ";
            sSQL += " where 1 =1 ";

            if (Nombre.Trim().Length > 0)
                sSQL += " and Nombre LIKE '%" + Nombre + "%'";

            if (TipoPersona.Trim().Length > 0)
                sSQL += " and Tipo_Persona like '" + TipoPersona + "%'";

            if (Estado.Trim().Length > 0)
                sSQL += " and Estado like '" + Estado + "%'";

            if (BalanceDesde.ToString().Trim().Length > 0 && BalanceHasta.ToString().Trim().Length > 0)
                sSQL += " and Balance between '" + BalanceDesde + "' and '" + BalanceHasta + "'";

            DataTable odt = new DataTable();
            SqlDataAdapter oda = new SqlDataAdapter(sSQL, ocon);
            oda.Fill(odt);

            ReportDataSource rds = new ReportDataSource();
            rds.Value = odt;
            rds.Name = "DataSetProveedores";
            rpvReporteProveedores.LocalReport.DataSources.Clear();
            rpvReporteProveedores.LocalReport.DataSources.Add(rds);
            rpvReporteProveedores.LocalReport.ReportEmbeddedResource = "ReporteProveedores.rdlc";
            rpvReporteProveedores.LocalReport.ReportPath = @"ReporteProveedores.rdlc";
            rpvReporteProveedores.RefreshReport();

            // TODO: This line of code loads data into the 'CuentasPorPagarDataSet.Proveedores' table. You can move, or remove it, as needed.
            //this.ProveedoresTableAdapter.Fill(this.CuentasPorPagarDataSet.Proveedores);

            //this.reportViewer1.RefreshReport();


        }
    }
}
