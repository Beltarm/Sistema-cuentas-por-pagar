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
   
    public partial class FrmEdProveedores : Form
    {
        Validaciones v = new Validaciones();
        public SqlConnection conn { get; set; }
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Tipo_Persona { get; set; }
        public string Balance { get; set; }
        public string Estado { get; set; }
        public string modo { get; set; }
        public FrmEdProveedores()
        {
            InitializeComponent();
            cbxIdentificacion.SelectedIndex = 0;


        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (modo.Equals("C"))
                {
                    sql = "INSERT INTO PROVEEDORES VALUES('";
                    sql += txtNombre.Text + "', '" + txtCedula.Text + "', '" + cbxTipo.Text + "', '" +
                    txtBalance.Text + "', '" + cbxEstado.Text + "')";
                }
                else
                {
                    sql = "UPDATE PROVEEDORES SET ";
                    sql += "NOMBRE = '" + txtNombre.Text + "', CEDULA = '" + txtCedula.Text + "', TIPO_PERSONA = '" + cbxTipo.Text + "', BALANCE = '" + txtBalance.Text + "', ESTADO = '" + cbxEstado.Text + "'";
                    sql += "WHERE ID_PROVEEDOR = " + ID;
                }

                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtBalance.Text) || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(cbxEstado.Text) || string.IsNullOrEmpty(cbxTipo.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
                else
                {
                    if (cbxIdentificacion.SelectedItem.Equals("Cédula"))
                    {
                        v.validaCedula(txtCedula.Text);
                        if (v.validaCedula(txtCedula.Text))
                        {

                            SqlCommand cnd = new SqlCommand(sql, conn);
                            cnd.ExecuteNonQuery();
                            MessageBox.Show("Datos guardados con éxito");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cédula incorrecta");
                        }
                    }
                    else
                    {
                        v.esUnRNCValido(txtCedula.Text);
                        if (v.esUnRNCValido(txtCedula.Text))
                        {

                            SqlCommand cnd = new SqlCommand(sql, conn);
                            cnd.ExecuteNonQuery();
                            MessageBox.Show("Datos guardados con éxito");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("RNC incorrecto");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtBalance.Text) || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(cbxEstado.Text) || string.IsNullOrEmpty(cbxTipo.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
                else
                {

                    var confirmResult = MessageBox.Show("¿Estás seguro(a) que quieres eliminar este registro?", "Confirme", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        string sql = "DELETE PROVEEDORES WHERE ID_PROVEEDOR = '" + ID + "'";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al eliminar: " + ex.Message);
            }
        }

        private void FrmEdProveedores_Load(object sender, EventArgs e)
        {

            try
            {
                txtID.Text = ID;
                txtNombre.Text = Nombre;
                txtCedula.Text = Cedula;
                cbxTipo.Text = Tipo_Persona;
                txtBalance.Text = Balance;
                cbxEstado.Text = Estado;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar valores " + ex.Message);
            }

        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);

        }
   
        private void txtCedula_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


