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
    public partial class SolicitudPago : Form
    {
        private Cuentas_por_pagarEntities1 entities = new Cuentas_por_pagarEntities1();
        public Documentos_Pagar documentos { get; set; }
        public Solicitud_Pago_Proveedor solicitud { get; set; }
        public SolicitudPago()
        {
            InitializeComponent();
        }

        private void SolicitudPago_Load(object sender, EventArgs e)
        {

        }
    }
}
