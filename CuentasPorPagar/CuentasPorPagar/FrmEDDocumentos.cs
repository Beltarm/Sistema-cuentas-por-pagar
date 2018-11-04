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
        Validaciones v = new Validaciones();
        public string modo { get; set; }
        public SqlConnection conn { get; set; }
        public string Num_Documento { get; set; }
        public string Num_Factura { get; set; }
        public string concepto_pago { get; set; }
        public string Fecha_Documento { get; set; }
        public string Monto { get; set; }
        public string Fecha_Registro { get; set; }
        public string nombre_proveedor { get; set; }
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
                cbxConcepto.Text = concepto_pago;
                cbxProveedor.Text = nombre_proveedor;

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

       private int  InsertProveedores()
        {
            try
            {
                int id_proveedor = 0;
                string Nombre_Provedor = cbxProveedor.SelectedItem.ToString();
                string sql = "select Id_Proveedor from Proveedores where nombre like '%" + Nombre_Provedor + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            id_proveedor = Convert.ToInt32(reader.GetValue(i));
                        }
                    }
                }
                return id_proveedor;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los datos" + ex.Message);
                return 0;
            }
            
        }
        public void consultaConceptos()
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

        public int insertConceptos()
        {
            try
            {
                int id_concepto = 0;
                string Nombre_Concepto = cbxConcepto.SelectedItem.ToString();
                string sql = "select id_concepto_pago from Concepto_Pago where Descripcion like '%" + Nombre_Concepto + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                   while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            id_concepto = Convert.ToInt32(reader.GetValue(i));
                            
                        }
                    }
                }      
                
                return id_concepto;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los datos" + ex.Message);
                return 0;
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (validarVacio() == "")
            {
                try
                {
                    string sql = "";
                    if (modo.Equals("C"))
                    {
                        sql = "INSERT INTO Documentos_Pagar VALUES ('";
                        sql += txtNumFactura.Text + "', " + insertConceptos() + ", '" + mtxFechaDocumento.Text + "', ";
                        sql += txtMonto.Text + ", '" + mtxFechaRegistro.Text + "', " + InsertProveedores() + ", '" + cbxEstado.SelectedItem + "') ";
                    }
                    else
                    {
                        sql = "UPDATE Documentos_Pagar SET";
                        sql += " Num_Factura = '" + txtNumFactura.Text + "', Id_Concepto_Pago = " + insertConceptos() + ", Fecha_Documento = '";
                        sql += mtxFechaDocumento.Text + "', Monto =  " + txtMonto.Text + ", Fecha_Registro = '" + mtxFechaRegistro.Text + "' , Id_Proveedor =  ";
                        sql += InsertProveedores() + ", Estado = '" + cbxEstado.SelectedItem + "' ";
                        sql += "WHERE Num_Documento = " + txtNumDocumento.Text;

                    }

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado con exito");
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al ingresar el registro : " + ex.Message);
                }
            }
            
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("¿Estás seguro(a) que quieres eliminar este registro?", "Confirme", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string sql = "DELETE Documentos_Pagar WHERE Num_Documento = '" + Num_Documento + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Datos intactos");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string validarVacio()
        {
            var emptyornull = Controls.OfType<TextBox>().Where(box => box.Name.StartsWith("txt")).OrderBy(box => box.TabIndex);

            foreach (var test in emptyornull)
            {
                if (string.IsNullOrEmpty(test.Text))
                {
                    this.errorProvider.SetError((Control)test,"Campo vacío");
                    return "vacio";
                }

                this.errorProvider.SetError((Control)test,(string)null);
                return "";
            }

            return "";
        }

        private void txtNumFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }
    }

  }

