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
    public partial class FrmMantUsuarios : Form
    {
        Cuentas_por_pagarEntities1 entities = new Cuentas_por_pagarEntities1();
        public FrmMantUsuarios()
        {
            InitializeComponent();
        }

        private void FrmMantUsuarios_Load(object sender, EventArgs e)
        {
            consultarUsuarios();
        }

        private void consultarUsuarios()
        {
            ////var query =
            ////from usuario in entities.Usuario
            ////where usuario.ID_USUARIO > 0
            ////select new { ID = usuario.ID_USUARIO, Nombre = usuario.NOMBRE_USUARIO, Estado = usuario.ESTADO_USUARIO, Rol = usuario.ROL.FirstOrDefault().NOMBRE_ROL };

            ////DgbUsuarios.DataSource = query.ToList();

            DgbUsuarios.DataSource = entities.Usuario.Select(u => new
            {
                ID = u.ID_USUARIO,
                Nombre = u.NOMBRE_USUARIO,
                Estado = u.ESTADO_USUARIO,
                Rol = u.ROL.FirstOrDefault().NOMBRE_ROL
            }).ToList();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            filtrarUsuarios();
        }

        private void filtrarUsuarios()
        {
            var query = from u in entities.Usuario
                            where (u.ID_USUARIO.ToString().Contains(txtBuscar.Text) ||
                            u.NOMBRE_USUARIO.StartsWith(txtBuscar.Text) ||
                            u.ESTADO_USUARIO.ToString().StartsWith(txtBuscar.Text)
                            )
                            select new
                            {
                                ID = u.ID_USUARIO,
                                Nombre = u.NOMBRE_USUARIO,
                                Estado = u.ESTADO_USUARIO,
                                Rol = u.ROL.FirstOrDefault().NOMBRE_ROL
                            };
            DgbUsuarios.DataSource = query.ToList();
        }

        private void DgbUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
