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
    public partial class frmManConceptoPago : Form
    {
        SqlConnection conn = null;
        public frmManConceptoPago()
        {
            InitializeComponent();
        }

        private void frmManConceptoPago_Load(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void ejecutarConsulta()
        {
            try
            {
                conn = new SqlConnection("Data Source=ana-alex-brian.database.windows.net;Initial Catalog=Cuentas_por_pagar;User ID=propietaria;Password=#Seguridad1");
                conn.Open();

                /***************CONSULTA*****************/
                string sql = "SELECT * FROM CONCEPTO_PAGO";
                if (cbxCriterio.Text.Length > 0)
                {
                    sql += " WHERE " + cbxCriterio.Text + " LIKE '%" + txtBuscar.Text + "%'";
                    sql += " ORDER BY " + cbxCriterio.Text;
                }
                /*******************************************/

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgbConceptoDePago.DataSource = dt;
                DgbConceptoDePago.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }
    }
}
