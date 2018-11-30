using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorPagar
{
    public partial class pnPago : UserControl
    {
        Cuentas_por_pagarEntities1 entities = new Cuentas_por_pagarEntities1();
        public pnPago()
        {
            InitializeComponent();
        }

        private void pnPago_Load(object sender, EventArgs e)
        {
            DgbDeudas.DataSource = entities.Documentos_Pagar.Select(u => new
            {
                ID = u.Num_Documento,
                Factura = u.Num_Factura,
                Proveedor = u.Proveedores.Nombre
            }).ToList();
        }
    }
}
