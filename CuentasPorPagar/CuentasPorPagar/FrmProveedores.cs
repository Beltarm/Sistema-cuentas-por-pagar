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
    public partial class FrmProveedores : Form
    {
        public int xClick = 0, yClick = 0;
        SqlConnection conn = null;
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
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
                string sql = "SELECT * FROM PROVEEDORES";
                if (cbxCriterio.Text.Length > 0)
                {
                    string criterio;
                    if (cbxCriterio.SelectedIndex == 0)
                    {
                        criterio = "Id_Proveedor";
                    }
                    else
                    {
                        criterio = cbxCriterio.Text;
                    }
                    sql += " WHERE " + criterio + " LIKE '%" + txtConcepto.Text + "%'";
                    sql += " ORDER BY " + criterio;
                }
                /*******************************************/

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProveedores.DataSource = dt;
                dgvProveedores.Refresh();
                aplicarEstilos(dgvProveedores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }
        private void aplicarEstilos(DataGridView dataGrid)
        {
            dgvProveedores.Columns[0].HeaderText = "ID";
            dgvProveedores.ClearSelection();
            dataGrid.RowsDefaultCellStyle.BackColor = Color.White;
            dataGrid.RowHeadersDefaultCellStyle.BackColor = Color.White;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdProveedores ff = new FrmEdProveedores();
            ff.modo = "C";
            ff.conn = conn;
            ff.ShowDialog();

        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }
    }
}
