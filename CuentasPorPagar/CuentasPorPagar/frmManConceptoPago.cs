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
        public int xClick = 0, yClick = 0;
        SqlConnection conn = null;
        public string modo = "";
        public frmManConceptoPago()
        {
            InitializeComponent();
        }

        private void frmManConceptoPago_Load(object sender, EventArgs e)
        {
            if (modo == "user")
            {
                cmdAgregar.Enabled = false;
            }
        }

        private void ejecutarConsulta()
        {
            try
            {
                //Data Source = DESKTOP - Q7VG5OH; Initial Catalog = Backup_Cuentas_por_pagar; Integrated Security = True
                conn = new SqlConnection("Data Source=ana-alex-brian.database.windows.net;Initial Catalog=Cuentas_por_pagar;User ID=propietaria;Password=#Seguridad1");
                conn.Open();

                /***************CONSULTA*****************/
                string sql = "SELECT * FROM CONCEPTO_PAGO";
                if (cbxCriterio.Text.Length > 0)
                {
                    string criterio;
                    if (cbxCriterio.SelectedIndex == 0)
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
                aplicarEstilos(DgbConceptoDePago);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }

        /****************ESTILOS PARA EL DATAGRIDVIEW********************/
        private void aplicarEstilos(DataGridView dataGrid)
        {
            DgbConceptoDePago.Columns[0].HeaderText = "ID";
            DgbConceptoDePago.ClearSelection();
            dataGrid.RowsDefaultCellStyle.BackColor = Color.White;
            dataGrid.RowHeadersDefaultCellStyle.BackColor = Color.White;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
        }


        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            ejecutarConsulta();
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
            if(modo != "user")
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
        /********************ANIMACION DE BOTON AGREGAR***********************/
        private void cmdAgregar_MouseLeave(object sender, EventArgs e)
        {
            cmdAgregar.BackColor = Color.Transparent;
            cmdAgregar.ForeColor = Color.SeaGreen;
            cmdAgregar.FlatAppearance.BorderColor = Color.SeaGreen;
        }

        private void cmdAgregar_MouseEnter(object sender, EventArgs e)
        {
            cmdAgregar.BackColor = Color.SeaGreen;
            cmdAgregar.ForeColor = Color.Transparent;
            cmdAgregar.FlatAppearance.BorderColor = Color.SeaGreen;
        }
        /***************************************************************************/

        /********************ANIMACION DE BOTON FILTRAR***********************/
        private void cmdBuscar_MouseEnter(object sender, EventArgs e)
        {
            cmdBuscar.BackColor = Color.FromArgb(66, 139, 202);
            cmdBuscar.ForeColor = Color.Transparent;
            cmdBuscar.FlatAppearance.BorderColor = Color.FromArgb(66, 139, 202);
        }

        private void cmdBuscar_MouseLeave(object sender, EventArgs e)
        {
            cmdBuscar.BackColor = Color.Transparent;
            cmdBuscar.ForeColor = Color.FromArgb(66, 139, 202);
            cmdBuscar.FlatAppearance.BorderColor = Color.FromArgb(66, 139, 202);
        }

    }
}
