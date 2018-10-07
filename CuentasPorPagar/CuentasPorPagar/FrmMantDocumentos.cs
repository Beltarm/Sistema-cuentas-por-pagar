using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CuentasPorPagar
{
    public partial class FrmMantDocumentos : Form
    {
        SqlConnection conn = null;
        public FrmMantDocumentos()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void FrmMantDocumentos_Load(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void ejecutarConsulta()
        {
            try
            {
                /****************CONSULTA********************/
                conn = new SqlConnection("Data Source=ana-alex-brian.database.windows.net;Initial Catalog=Cuentas_por_pagar;User ID=propietaria;Password=#Seguridad1");
                conn.Open();
                string sql = "select Documentos_Pagar.Num_Documento as [Numero Documento],Documentos_Pagar.Num_Factura as [Numero Factura], + Concepto_Pago.Descripcion as [Concepto de pago]";
                sql += ", Documentos_Pagar.Fecha_Documento as [Fecha Documento],  Documentos_Pagar.Monto, Documentos_Pagar.Fecha_Registro as [Fecha Registro],";
                sql += " Proveedores.Nombre as [Nombre Proveedor],  Documentos_Pagar.Estado from Documentos_Pagar INNER JOIN Concepto_Pago ON";
                sql += " Documentos_Pagar.Id_Concepto_Pago = Concepto_Pago.Id_Concepto_Pago INNER JOIN Proveedores ON Documentos_Pagar.Id_Proveedor = Proveedores.Id_Proveedor;";

                if (cbxCriterio.Text.Length > 0 )
                {

                }
                /*******************************************/
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvResultados.DataSource = dt;
                dgvResultados.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
            }
        }

        /****************ESTILOS PARA EL DATAGRIDVIEW********************/
        private void aplicarEstilos(DataGridView dataGrid)
        {
            dgvResultados.Columns[0].HeaderText = "ID";
            dgvResultados.ClearSelection();
            dataGrid.RowsDefaultCellStyle.BackColor = Color.White;
            dataGrid.RowHeadersDefaultCellStyle.BackColor = Color.White;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
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
