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
    public partial class frmConceptoPago : Form
    {
        public SqlConnection conn { get; set; }
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string modo { get; set; }

        public frmConceptoPago()
        {
            InitializeComponent();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (modo.Equals("C"))
                {
                    sql = "INSERT INTO CONCEPTO_PAGO VALUES('";
                    sql += txtDescripcion.Text + "', '" + txtEstado.Text + "')";
                }
                else
                {
                    sql = "UPDATE CONCEPTO_PAGO SET ";
                    sql += "DESCRIPCION = '" + txtDescripcion.Text + "', ESTADO = '" + txtEstado.Text + "'";
                    sql += "WHERE ID_CONCEPTO_PAGO = " + ID;
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado con exito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al guardar: " + ex.Message);
            }
        }

        private void frmConceptoPago_Load(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = ID;
                txtDescripcion.Text = Descripcion;
                txtEstado.Text = Estado;
                txtID.Enabled = modo.Equals("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar valores " + ex.Message);
            }
        }
    }
}
