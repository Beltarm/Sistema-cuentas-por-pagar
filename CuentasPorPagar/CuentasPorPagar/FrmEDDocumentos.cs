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
    public partial class FrmEDDocumentos : Form
    {
        public string modo { get; set; }
        public SqlConnection conn { get; set; }
        public string Num_Documento { get; set; }
        public string Num_Factura { get; set; }
        public string Id_Concepto_Pago { get; set; }
        public string Fecha_Documento { get; set; }
        public string Monto { get; set; }
        public string Fecha_Registro { get; set; }
        public string Id_Proveedor { get; set; }
        public string Estado { get; set; }

        public FrmEDDocumentos()
        {
            InitializeComponent();
        }

        private void FrmEDDocumentos_Load(object sender, EventArgs e)
        {

            try
            {
                consultaProveedores();
                consultaConceptos();
                txtNumDocumento.Text = Num_Documento;
                txtNumFactura.Text = Num_Factura;
                mtxFechaDocumento.Text = Fecha_Documento;
                mtxFechaRegistro.Text = Fecha_Registro;
                txtMonto.Text = Monto;
                cbxEstado.Text = Estado;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al asignar valores " + ex.Message);
            }
        }

        private void consultaProveedores()
        {
            try
            {
                
                string sql = "SELECT Nombre from Proveedores ORDER BY Id_Proveedor";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string lectura = reader["Nombre"].ToString();
                            cbxProveedor.Items.Add(lectura);
                        }
                    }
                    reader.Close();
                    
                }       

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los datos" + ex.Message);
            }
        }

        private void consultaConceptos()
        {
            try
            {

                string sql = "SELECT Descripcion from Concepto_Pago ORDER BY Id_Concepto_Pago";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string lectura = reader["Descripcion"].ToString();
                            cbxConcepto.Items.Add(lectura);
                        }
                    }
                    reader.Close();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los datos" + ex.Message);
            }
        }
    }

  }

