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

                if (validaCedula(txtCedula.Text))
                {
                  
                    SqlCommand cnd = new SqlCommand(sql, conn);
                    cnd.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cédula incorrecta");
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

                string sql = "DELETE PROVEEDORES WHERE ID_PROVEEDOR = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado con exito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
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
        public static bool validaCedula(string pCedula)



        {

            int vnTotal = 0;

            string vcCedula = pCedula.Replace("-", "");

            int pLongCed = vcCedula.Trim().Length;

            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };



            if (pLongCed < 11 || pLongCed > 11)

                return false;



            for (int vDig = 1; vDig <= pLongCed; vDig++)

            {

                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];

                if (vCalculo < 10)

                    vnTotal += vCalculo;

                else

                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));

            }



            if (vnTotal % 10 == 0)

                return true;

            else

                return false;

        }
    }
}
 
