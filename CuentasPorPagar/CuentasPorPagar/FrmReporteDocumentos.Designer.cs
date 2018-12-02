namespace CuentasPorPagar
{
    partial class FrmReporteDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteDocumentos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtbRegistroHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtbRegistroDesde = new System.Windows.Forms.MaskedTextBox();
            this.mtbDocumentoHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtbDocumentoDesde = new System.Windows.Forms.MaskedTextBox();
            this.rbtPagado = new System.Windows.Forms.RadioButton();
            this.rbtPendiente = new System.Windows.Forms.RadioButton();
            this.txtMontoHasta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMontoDesde = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFacturaHasta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFacturaDesde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConceptoPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdReporte = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtbRegistroHasta);
            this.panel1.Controls.Add(this.mtbRegistroDesde);
            this.panel1.Controls.Add(this.mtbDocumentoHasta);
            this.panel1.Controls.Add(this.mtbDocumentoDesde);
            this.panel1.Controls.Add(this.rbtPagado);
            this.panel1.Controls.Add(this.rbtPendiente);
            this.panel1.Controls.Add(this.txtMontoHasta);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtMontoDesde);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtFacturaHasta);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtFacturaDesde);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtConceptoPago);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombreProveedor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 431);
            this.panel1.TabIndex = 0;
            // 
            // mtbRegistroHasta
            // 
            this.mtbRegistroHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbRegistroHasta.Location = new System.Drawing.Point(467, 294);
            this.mtbRegistroHasta.Mask = "00/00/0000";
            this.mtbRegistroHasta.Name = "mtbRegistroHasta";
            this.mtbRegistroHasta.Size = new System.Drawing.Size(120, 26);
            this.mtbRegistroHasta.TabIndex = 37;
            this.mtbRegistroHasta.ValidatingType = typeof(System.DateTime);
            this.mtbRegistroHasta.Click += new System.EventHandler(this.mtbRegistroHasta_Click);
            // 
            // mtbRegistroDesde
            // 
            this.mtbRegistroDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbRegistroDesde.Location = new System.Drawing.Point(267, 294);
            this.mtbRegistroDesde.Mask = "00/00/0000";
            this.mtbRegistroDesde.Name = "mtbRegistroDesde";
            this.mtbRegistroDesde.Size = new System.Drawing.Size(120, 26);
            this.mtbRegistroDesde.TabIndex = 36;
            this.mtbRegistroDesde.ValidatingType = typeof(System.DateTime);
            this.mtbRegistroDesde.Click += new System.EventHandler(this.mtbRegistroDesde_Click);
            // 
            // mtbDocumentoHasta
            // 
            this.mtbDocumentoHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDocumentoHasta.Location = new System.Drawing.Point(478, 235);
            this.mtbDocumentoHasta.Mask = "00/00/0000";
            this.mtbDocumentoHasta.Name = "mtbDocumentoHasta";
            this.mtbDocumentoHasta.Size = new System.Drawing.Size(120, 26);
            this.mtbDocumentoHasta.TabIndex = 35;
            this.mtbDocumentoHasta.ValidatingType = typeof(System.DateTime);
            this.mtbDocumentoHasta.Click += new System.EventHandler(this.mtbDocumentoHasta_Click);
            // 
            // mtbDocumentoDesde
            // 
            this.mtbDocumentoDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDocumentoDesde.Location = new System.Drawing.Point(276, 235);
            this.mtbDocumentoDesde.Mask = "00/00/0000";
            this.mtbDocumentoDesde.Name = "mtbDocumentoDesde";
            this.mtbDocumentoDesde.Size = new System.Drawing.Size(120, 26);
            this.mtbDocumentoDesde.TabIndex = 34;
            this.mtbDocumentoDesde.ValidatingType = typeof(System.DateTime);
            this.mtbDocumentoDesde.Click += new System.EventHandler(this.mtbDocumentoDesde_Click);
            // 
            // rbtPagado
            // 
            this.rbtPagado.AutoSize = true;
            this.rbtPagado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPagado.Location = new System.Drawing.Point(255, 127);
            this.rbtPagado.Name = "rbtPagado";
            this.rbtPagado.Size = new System.Drawing.Size(91, 25);
            this.rbtPagado.TabIndex = 33;
            this.rbtPagado.TabStop = true;
            this.rbtPagado.Text = "Pagado";
            this.rbtPagado.UseVisualStyleBackColor = true;
            // 
            // rbtPendiente
            // 
            this.rbtPendiente.AutoSize = true;
            this.rbtPendiente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPendiente.Location = new System.Drawing.Point(123, 127);
            this.rbtPendiente.Name = "rbtPendiente";
            this.rbtPendiente.Size = new System.Drawing.Size(108, 25);
            this.rbtPendiente.TabIndex = 32;
            this.rbtPendiente.TabStop = true;
            this.rbtPendiente.Text = "Pendiente";
            this.rbtPendiente.UseVisualStyleBackColor = true;
            // 
            // txtMontoHasta
            // 
            this.txtMontoHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoHasta.Location = new System.Drawing.Point(402, 344);
            this.txtMontoHasta.MaxLength = 7;
            this.txtMontoHasta.Multiline = true;
            this.txtMontoHasta.Name = "txtMontoHasta";
            this.txtMontoHasta.Size = new System.Drawing.Size(120, 27);
            this.txtMontoHasta.TabIndex = 27;
            this.txtMontoHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoHasta_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(336, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 21);
            this.label13.TabIndex = 26;
            this.label13.Text = "Hasta:";
            // 
            // txtMontoDesde
            // 
            this.txtMontoDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoDesde.Location = new System.Drawing.Point(188, 344);
            this.txtMontoDesde.MaxLength = 7;
            this.txtMontoDesde.Multiline = true;
            this.txtMontoDesde.Name = "txtMontoDesde";
            this.txtMontoDesde.Size = new System.Drawing.Size(120, 27);
            this.txtMontoDesde.TabIndex = 25;
            this.txtMontoDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoDesde_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(119, 347);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 21);
            this.label14.TabIndex = 24;
            this.label14.Text = "Desde:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 347);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 21);
            this.label15.TabIndex = 23;
            this.label15.Text = "Monto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(401, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Hasta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(207, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Desde:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "Fecha de Registro\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(412, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hasta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(217, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Desde:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Fecha de Documento";
            // 
            // txtFacturaHasta
            // 
            this.txtFacturaHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturaHasta.Location = new System.Drawing.Point(467, 183);
            this.txtFacturaHasta.MaxLength = 70;
            this.txtFacturaHasta.Multiline = true;
            this.txtFacturaHasta.Name = "txtFacturaHasta";
            this.txtFacturaHasta.Size = new System.Drawing.Size(120, 27);
            this.txtFacturaHasta.TabIndex = 12;
            this.txtFacturaHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFacturaHasta_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(401, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hasta:";
            // 
            // txtFacturaDesde
            // 
            this.txtFacturaDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturaDesde.Location = new System.Drawing.Point(267, 183);
            this.txtFacturaDesde.MaxLength = 70;
            this.txtFacturaDesde.Multiline = true;
            this.txtFacturaDesde.Name = "txtFacturaDesde";
            this.txtFacturaDesde.Size = new System.Drawing.Size(120, 27);
            this.txtFacturaDesde.TabIndex = 10;
            this.txtFacturaDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFacturaDesde_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(207, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número de factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado";
            // 
            // txtConceptoPago
            // 
            this.txtConceptoPago.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConceptoPago.Location = new System.Drawing.Point(195, 83);
            this.txtConceptoPago.Multiline = true;
            this.txtConceptoPago.Name = "txtConceptoPago";
            this.txtConceptoPago.Size = new System.Drawing.Size(232, 27);
            this.txtConceptoPago.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Concepto de pago";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(195, 31);
            this.txtNombreProveedor.MaxLength = 50;
            this.txtNombreProveedor.Multiline = true;
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(232, 27);
            this.txtNombreProveedor.TabIndex = 1;
            this.txtNombreProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProveedor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Proveedor";
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("cmdLimpiar.Image")));
            this.cmdLimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdLimpiar.Location = new System.Drawing.Point(352, 452);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(145, 93);
            this.cmdLimpiar.TabIndex = 2;
            this.cmdLimpiar.Text = "Limpiar campos";
            this.cmdLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdReporte
            // 
            this.cmdReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReporte.Image = ((System.Drawing.Image)(resources.GetObject("cmdReporte.Image")));
            this.cmdReporte.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdReporte.Location = new System.Drawing.Point(117, 452);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(139, 96);
            this.cmdReporte.TabIndex = 3;
            this.cmdReporte.Text = "Hacer Reporte";
            this.cmdReporte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdReporte.UseVisualStyleBackColor = true;
            this.cmdReporte.Click += new System.EventHandler(this.cmdReporte_Click);
            // 
            // FrmReporteDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 560);
            this.Controls.Add(this.cmdReporte);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReporteDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parámetros reporte de documentos";
            this.Load += new System.EventHandler(this.FrmReporteDocumentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConceptoPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFacturaHasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFacturaDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMontoHasta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMontoDesde;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button cmdReporte;
        private System.Windows.Forms.RadioButton rbtPagado;
        private System.Windows.Forms.RadioButton rbtPendiente;
        private System.Windows.Forms.MaskedTextBox mtbDocumentoDesde;
        private System.Windows.Forms.MaskedTextBox mtbRegistroHasta;
        private System.Windows.Forms.MaskedTextBox mtbRegistroDesde;
        private System.Windows.Forms.MaskedTextBox mtbDocumentoHasta;
    }
}