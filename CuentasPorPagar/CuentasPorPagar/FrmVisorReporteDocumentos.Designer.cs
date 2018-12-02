namespace CuentasPorPagar
{
    partial class FrmVisorReporteDocumentos
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
            this.Reporte_DocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDocumentos = new CuentasPorPagar.DataSetDocumentos();
            this.rpvDocumentos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reporte_DocumentosTableAdapter = new CuentasPorPagar.DataSetDocumentosTableAdapters.Reporte_DocumentosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_DocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // Reporte_DocumentosBindingSource
            // 
            this.Reporte_DocumentosBindingSource.DataMember = "Reporte_Documentos";
            this.Reporte_DocumentosBindingSource.DataSource = this.DataSetDocumentos;
            // 
            // DataSetDocumentos
            // 
            this.DataSetDocumentos.DataSetName = "DataSetDocumentos";
            this.DataSetDocumentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvDocumentos
            // 
            this.rpvDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDocumentos";
            reportDataSource1.Value = this.Reporte_DocumentosBindingSource;
            this.rpvDocumentos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDocumentos.LocalReport.ReportEmbeddedResource = "CuentasPorPagar.ReporteDocumentos.rdlc";
            this.rpvDocumentos.Location = new System.Drawing.Point(0, 0);
            this.rpvDocumentos.Name = "rpvDocumentos";
            this.rpvDocumentos.ServerReport.BearerToken = null;
            this.rpvDocumentos.Size = new System.Drawing.Size(800, 450);
            this.rpvDocumentos.TabIndex = 0;
            // 
            // Reporte_DocumentosTableAdapter
            // 
            this.Reporte_DocumentosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVisorReporteDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvDocumentos);
            this.Name = "FrmVisorReporteDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Documentos";
            this.Load += new System.EventHandler(this.FrmVisorReporteDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_DocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDocumentos;
        private System.Windows.Forms.BindingSource Reporte_DocumentosBindingSource;
        private DataSetDocumentos DataSetDocumentos;
        private DataSetDocumentosTableAdapters.Reporte_DocumentosTableAdapter Reporte_DocumentosTableAdapter;
    }
}