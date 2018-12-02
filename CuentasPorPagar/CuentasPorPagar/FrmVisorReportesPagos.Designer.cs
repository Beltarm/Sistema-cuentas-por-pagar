namespace CuentasPorPagar
{
    partial class FrmVisorReportesPagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvPagos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetPagos = new CuentasPorPagar.DataSetPagos();
            this.Solicitud_Pago_ProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Solicitud_Pago_ProveedorTableAdapter = new CuentasPorPagar.DataSetPagosTableAdapters.Solicitud_Pago_ProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Solicitud_Pago_ProveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvPagos
            // 
            this.rpvPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPagos";
            reportDataSource1.Value = this.Solicitud_Pago_ProveedorBindingSource;
            this.rpvPagos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvPagos.LocalReport.ReportEmbeddedResource = "CuentasPorPagar.ReportePagos.rdlc";
            this.rpvPagos.Location = new System.Drawing.Point(0, 0);
            this.rpvPagos.Name = "rpvPagos";
            this.rpvPagos.ServerReport.BearerToken = null;
            this.rpvPagos.Size = new System.Drawing.Size(800, 450);
            this.rpvPagos.TabIndex = 0;
            // 
            // DataSetPagos
            // 
            this.DataSetPagos.DataSetName = "DataSetPagos";
            this.DataSetPagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Solicitud_Pago_ProveedorBindingSource
            // 
            this.Solicitud_Pago_ProveedorBindingSource.DataMember = "Solicitud_Pago_Proveedor";
            this.Solicitud_Pago_ProveedorBindingSource.DataSource = this.DataSetPagos;
            // 
            // Solicitud_Pago_ProveedorTableAdapter
            // 
            this.Solicitud_Pago_ProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVisorReportesPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvPagos);
            this.Name = "FrmVisorReportesPagos";
            this.Text = "Reporte de Pagos";
            this.Load += new System.EventHandler(this.FrmVisorReportesPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Solicitud_Pago_ProveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPagos;
        private System.Windows.Forms.BindingSource Solicitud_Pago_ProveedorBindingSource;
        private DataSetPagos DataSetPagos;
        private DataSetPagosTableAdapters.Solicitud_Pago_ProveedorTableAdapter Solicitud_Pago_ProveedorTableAdapter;
    }
}