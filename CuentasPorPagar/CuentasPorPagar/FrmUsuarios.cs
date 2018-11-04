using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //var buscarRol = (from r in entities.ROL
            //                 where r.NOMBRE_ROL == cmbRol.SelectedValue.ToString()
            //                 select r);

            var rol = entities.ROL.FirstOrDefault(r => r.NOMBRE_ROL == cmbRol.Text);
            entities.Usuario.Add(new Usuario
            {
                ID_USUARIO = 0,
                NOMBRE_USUARIO = txtNombre.Text,
                ESTADO_USUARIO = cmbEstado.Text,
                CLAVE_USUARIO = txtClave.Text,
                ROL = {rol}
            });

            entities.SaveChanges();
            MessageBox.Show("Datos guardados con exito");
            this.Close();
        }
    }
}
