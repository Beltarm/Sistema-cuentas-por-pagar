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
        FrmEDDocumentos form2 = new FrmEDDocumentos();
        public string modo = "";
        public FrmMantDocumentos()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEDDocumentos frm = new FrmEDDocumentos();
            frm.modo = "C";
            frm.conn = conn;
            frm.ShowDialog();
           
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void FrmMantDocumentos_Load(object sender, EventArgs e)
        {
            ejecutarConsulta();
            if(modo == "user")
            {
                cmdAgregar.Enabled = false;
            }
        }

        private void ejecutarConsulta()
        {
            try
            {
                /****************CONSULTA********************/
                conn = new SqlConnection("Data Source=ana-alex-brian.database.windows.net;Initial Catalog=Cuentas_por_pagar;User ID=propietaria;Password=#Seguridad1");
                conn.Open();
                string sql = "select Documentos_Pagar.Num_Documento as [Numero Documento], Documentos_Pagar.Num_Factura as [Numero Factura], + Concepto_Pago.Descripcion as [Concepto Pago]";
                sql += ", Documentos_Pagar.Fecha_Documento as [Fecha Documento],  Documentos_Pagar.Monto as Monto, Documentos_Pagar.Fecha_Registro as [Fecha Registro],";
                sql += " Proveedores.Nombre as [Nombre Proveedor],  Documentos_Pagar.Estado as Estado from Documentos_Pagar INNER JOIN Concepto_Pago ON";
                sql += " Documentos_Pagar.Id_Concepto_Pago = Concepto_Pago.Id_Concepto_Pago INNER JOIN Proveedores ON Documentos_Pagar.Id_Proveedor = Proveedores.Id_Proveedor ";

                string criterio = "";
                if (cbxCriterio.Text.Length > 0)
                {

                    //switch (cbxCriterio.Text)
                    //{
                    //    case "Numero Documento":
                    //        criterio = "Num_Documento";
                    //        break;
                    //    case "Numero Factura":
                    //        criterio = "Num_Factura";
                    //        break;
                    //    case "Concepto Pago":
                    //        criterio = "Concepto_Pago.Descripcion";
                    //        break;
                    //    case "Fecha Documento":
                    //        criterio = "Documentos_Pagar.Fecha_Documento";
                    //        break;
                    //    case "Monto":
                    //        criterio = "Documentos_Pagar.Monto";
                    //        break;
                    //    case "Fecha Registro":
                    //        criterio = "Documentos_Pagar.Fecha_Registro";
                    //        break;
                    //    case "Nombre Proveedor":
                    //        criterio = "Proveedores.Nombre";
                    //        break;
                    //    case "Estado":
                    //        criterio = "Documentos_Pagar.Estado";
                    //        break;

                    //    default:
                    //        break;
                    //}

                    switch (cbxCriterio.SelectedIndex)
                    {
                        case 0:
                            criterio = "Num_Documento";
                            break;
                        case 1:
                            criterio = "Num_Factura";
                            break;
                        case 2:
                            criterio = "Concepto_Pago.Descripcion";
                            break;
                        case 3:
                            criterio = "Documentos_Pagar.Fecha_Documento";
                            break;
                        case 4:
                            criterio = "Documentos_Pagar.Monto";
                            break;
                        case 5:
                            criterio = "Documentos_Pagar.Fecha_Registro";
                            break;
                        case 6:
                            criterio = "Proveedores.Nombre";
                            break;
                        case 7:
                            criterio = "Documentos_Pagar.Estado";
                            break;

                        default:
                            break;
                    }
                    
                    sql += "where " + criterio + " like '%" + txtBuscar.Text + "%'";
                    sql += " order by " +  criterio;
                }
              


                /*******************************************/
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvResultados.DataSource = dt;
                dgvResultados.Refresh();
                aplicarEstilos(dgvResultados);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
            }
        }

        /****************ESTILOS PARA EL DATAGRIDVIEW********************/
        private void aplicarEstilos(DataGridView dataGrid)
        {
            
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

        private void FrmMantDocumentos_Activated(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(modo != "user")
            {
                DataGridViewRow row = this.dgvResultados.SelectedRows[0];
                FrmEDDocumentos frm = new FrmEDDocumentos();
                frm.Num_Documento = row.Cells[0].Value.ToString();
                frm.Num_Factura = row.Cells[1].Value.ToString();
                frm.concepto_pago = row.Cells[2].Value.ToString();
                frm.Fecha_Documento = row.Cells[3].Value.ToString();
                frm.Monto = row.Cells[4].Value.ToString();
                frm.Fecha_Registro = row.Cells[5].Value.ToString();
                frm.nombre_proveedor = row.Cells[6].Value.ToString();
                frm.Estado = row.Cells[7].Value.ToString();
                frm.modo = "U";
                frm.conn = conn;
                frm.ShowDialog();
            }    
        }
    }
}
