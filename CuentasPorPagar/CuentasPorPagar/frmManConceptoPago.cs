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

        private void ejecutarConsulta()
        {
            try
            {
                conn = new SqlConnection("Data Source=ana-alex-brian.database.windows.net;Initial Catalog=Cuentas_por_pagar;User ID=propietaria;Password=#Seguridad1");
                conn.Open();

                /***************CONSULTA*****************/
                string sql = "SELECT * FROM CONCEPTO_PAGO";
                string criterio;
                if (cbxCriterio.Text.Length > 0)
                {
                    if(cbxCriterio.SelectedIndex == 0)
                    {
                        criterio = "Id_Concepto_Pago";
                    }
                    else
                    {
                        criterio = cbxCriterio.Text;
                    }
                    sql += " WHERE " + criterio + " LIKE '%" + txtBuscar.Text + "%'";
                    sql += " ORDER BY " + criterio;
                }
                /*******************************************/

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgbConceptoDePago.DataSource = dt;
                DgbConceptoDePago.Refresh();
                alternarColor(DgbConceptoDePago);
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

        private void alternarColor(DataGridView dataGrid)
        {
            dataGrid.RowsDefaultCellStyle.BackColor = Color.White;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(234, 235, 237);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            frmConceptoPago frm = new frmConceptoPago();
            frm.modo = "C";
            frm.conn = conn;
            frm.ShowDialog();
        }

        private void frmManEstudiante_Activated(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void DgbConceptoDePago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DgbConceptoDePago.SelectedRows[0];
                frmConceptoPago frm = new frmConceptoPago();
                frm.ID = row.Cells[0].Value.ToString();
                frm.Descripcion = row.Cells[1].Value.ToString();
                frm.Estado = row.Cells[2].Value.ToString();
                frm.modo = "U";
                frm.conn = conn;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar registro " + ex.Message);
            }
        }
    }
}
