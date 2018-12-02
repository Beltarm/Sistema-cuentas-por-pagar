namespace CuentasPorPagar
{
    partial class FrmVisorReporteProveedores
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
            this.ProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CuentasPorPagarDataSet = new CuentasPorPagar.CuentasPorPagarDataSet();
            this.rpvReporteProveedores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProveedoresTableAdapter = new CuentasPorPagar.CuentasPorPagarDataSetTableAdapters.ProveedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuentasPorPagarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProveedoresBindingSource
            // 
            this.ProveedoresBindingSource.DataMember = "Proveedores";
            this.ProveedoresBindingSource.DataSource = this.CuentasPorPagarDataSet;
            // 
            // CuentasPorPagarDataSet
            // 
            this.CuentasPorPagarDataSet.DataSetName = "CuentasPorPagarDataSet";
            this.CuentasPorPagarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvReporteProveedores
            // 
            this.rpvReporteProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetProveedores";
            reportDataSource1.Value = this.ProveedoresBindingSource;
            this.rpvReporteProveedores.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvReporteProveedores.LocalReport.ReportEmbeddedResource = "CuentasPorPagar.ReporteProveedores.rdlc";
            this.rpvReporteProveedores.Location = new System.Drawing.Point(0, 0);
            this.rpvReporteProveedores.Name = "rpvReporteProveedores";
            this.rpvReporteProveedores.ServerReport.BearerToken = null;
            this.rpvReporteProveedores.Size = new System.Drawing.Size(800, 450);
            this.rpvReporteProveedores.TabIndex = 0;
            this.rpvReporteProveedores.Load += new System.EventHandler(this.rpvReporteProveedores_Load);
            // 
            // ProveedoresTableAdapter
            // 
            this.ProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVisorReporteProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvReporteProveedores);
            this.Name = "FrmVisorReporteProveedores";
            this.Text = "Reporte de Proveedores";
            this.Load += new System.EventHandler(this.FrmVisorReporteProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuentasPorPagarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvReporteProveedores;
        private System.Windows.Forms.BindingSource ProveedoresBindingSource;
        private CuentasPorPagarDataSet CuentasPorPagarDataSet;
        private CuentasPorPagarDataSetTableAdapters.ProveedoresTableAdapter ProveedoresTableAdapter;
    }
}