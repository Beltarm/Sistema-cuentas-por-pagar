using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorPagar
{
    public partial class FrmUsuarios : Form
    {
        public Usuario usuario { get; set; }
        private Cuentas_por_pagarEntities1 entities = new Cuentas_por_pagarEntities1();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                txtID.Text = usuario.ID_USUARIO.ToString();
                txtNombre.Text = usuario.NOMBRE_USUARIO;
                cmbEstado.Text = usuario.ESTADO_USUARIO;
                cmbRol.Text = usuario.ROL.FirstOrDefault().NOMBRE_ROL;
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            var rol = entities.ROL.FirstOrDefault(r => r.NOMBRE_ROL == cmbRol.Text);
            if (usuario != null)
            {
                Usuario usuarioAGuardar = entities.Usuario.Find(Int32.Parse(txtID.Text));
                usuarioAGuardar.NOMBRE_USUARIO = txtNombre.Text;
                usuarioAGuardar.ESTADO_USUARIO = cmbEstado.Text;

                usuarioAGuardar.ROL.Clear();
                usuarioAGuardar.ROL.Add(rol);

            }
            else
            {
                entities.Usuario.Add(new Usuario
                {
                    NOMBRE_USUARIO = txtNombre.Text,
                    ESTADO_USUARIO = cmbEstado.Text,
                    CLAVE_USUARIO = txtClave.Text,
                    ROL = { rol }
                });
            }

            entities.SaveChanges();
            MessageBox.Show("Datos guardados con éxito");
            this.Close();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Usuario usuario = entities.Usuario.Find(Int32.Parse(txtID.Text));
            if (usuario != null)
            {
                entities.Usuario.Remove(usuario);
                entities.SaveChanges();
                MessageBox.Show("Empleado eliminado con éxito");
            }
            else
            {
                MessageBox.Show("Empleado no existe");
            }
        }
    }
}
