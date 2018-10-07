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
                    sql += txtDescripcion.Text + "', '" + cmbEstado.Text + "')";
                }
                else
                {
                    sql = "UPDATE CONCEPTO_PAGO SET ";
                    sql += "DESCRIPCION = '" + txtDescripcion.Text + "', ESTADO = '" + cmbEstado.Text + "'";
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
                cmbEstado.Text = Estado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar valores " + ex.Message);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "DELETE CONCEPTO_PAGO WHERE ID_CONCEPTO_PAGO = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado con exito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al guardar: " + ex.Message);
            }
        }

        /********************ANIMACION DE BOTON GUARDAR***********************/
        private void cmdGuardar_MouseLeave(object sender, EventArgs e)
        {
            cmdGuardar.BackColor = Color.Transparent;
            cmdGuardar.ForeColor = Color.FromArgb(92, 184, 92);
            cmdGuardar.FlatAppearance.BorderColor = Color.FromArgb(92, 184, 92);
        }

        private void cmdGuardar_MouseEnter(object sender, EventArgs e)
        {
            cmdGuardar.BackColor = Color.FromArgb(92, 184, 92);
            cmdGuardar.ForeColor = Color.Transparent;
            cmdGuardar.FlatAppearance.BorderColor = Color.FromArgb(92, 184, 92);
        }

        /********************ANIMACION DE BOTON ELIMINAR***********************/
        private void cmdEliminar_MouseLeave(object sender, EventArgs e)
        {
            cmdEliminar.BackColor = Color.Transparent;
            cmdEliminar.ForeColor = Color.FromArgb(217, 83, 79);
            cmdEliminar.FlatAppearance.BorderColor = Color.FromArgb(217, 83, 79);
        }

        private void cmdEliminar_MouseEnter(object sender, EventArgs e)
        {
            cmdEliminar.BackColor = Color.FromArgb(217, 83, 79);
            cmdEliminar.ForeColor = Color.Transparent;
            cmdEliminar.FlatAppearance.BorderColor = Color.FromArgb(217, 83, 79);
        }
    }
}
