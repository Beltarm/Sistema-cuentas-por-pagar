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
                Monto = u.Monto,
                Proveedor = u.Proveedores.Nombre,
                Estado = u.Estado
            }).Where(u => u.Estado == "Pendiente").ToList();
        }

        private void DgbDeudas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DgbDeudas.SelectedRows[0];
            int id = Int32.Parse(row.Cells[0].Value.ToString());
            var d = (from doc in entities.Documentos_Pagar
                     where doc.Num_Documento == id
                     select doc);
            FrmFactura frm = new FrmFactura();
            frm.documento = d.FirstOrDefault();
            frm.ShowDialog();
        }
    }
}
