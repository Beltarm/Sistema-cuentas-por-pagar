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
    public partial class pnPagos : UserControl
    {
        Cuentas_por_pagarEntities1 entities = new Cuentas_por_pagarEntities1();
        public pnPagos()
        {
            InitializeComponent();
        }

        private void pnPagos_Load(object sender, EventArgs e)
        {
            DgbDeudas.DataSource = entities.Documentos_Pagar.Select(u => new
            {
                ID = u.Num_Documento,
                Factura = u.Num_Factura,
                Monto = u.Monto
            }).ToList();
        }

        private void DgbDeudas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DgbDeudas.SelectedRows[0];
            int id = Int32.Parse(row.Cells[0].Value.ToString());
            var u = (from doc in entities.Documentos_Pagar
                     where doc.Id_Concepto_Pago == id
                     select doc);
            SolicitudPago solicitudPago = new SolicitudPago();
            solicitudPago.documentos = u.FirstOrDefault();
            solicitudPago.ShowDialog();
        }
    }
}
