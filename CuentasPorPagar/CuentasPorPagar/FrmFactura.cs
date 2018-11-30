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
    public partial class FrmFactura : Form
    {
        Cuentas_por_pagarEntities1 entities = new Cuentas_por_pagarEntities1();
        public Documentos_Pagar documento { get; set; }
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            txtIdSolicitud.Text = "ID";
            txtIdDocumento.Text = documento.Num_Documento.ToString();
            txtNumFactura.Text = documento.Num_Factura;
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            entities.Solicitud_Pago_Proveedor.Add(new Solicitud_Pago_Proveedor
            {
                Num_Documento = documento.Num_Documento,
                Num_Factura_Pagar = documento.Num_Factura,
                Fecha = DateTime.Now,
                Monto = Convert.ToInt32(txtMonto.Text),
                Estado = "Activo"
            });

            try
            {
                entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        
            MessageBox.Show("Proceso realizado correctamente");
            this.Close();
        }
    }
}
