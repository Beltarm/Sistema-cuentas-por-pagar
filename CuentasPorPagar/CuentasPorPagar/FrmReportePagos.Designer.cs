namespace CuentasPorPagar
{
    partial class FrmReportePagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportePagos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFacturaHasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFacturaDesde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbSolicitudHasta = new System.Windows.Forms.MaskedTextBox();
            this.mtbSolicitudDesde = new System.Windows.Forms.MaskedTextBox();
            this.txtMontoHasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoDesde = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDocumentoHasta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDocumentoDesde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdReporte = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFacturaHasta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFacturaDesde);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.rbtInactivo);
            this.panel1.Controls.Add(this.rbtActivo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mtbSolicitudHasta);
            this.panel1.Controls.Add(this.mtbSolicitudDesde);
            this.panel1.Controls.Add(this.txtMontoHasta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMontoDesde);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtDocumentoHasta);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDocumentoDesde);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 338);
            this.panel1.TabIndex = 0;
            // 
            // txtFacturaHasta
            // 
            this.txtFacturaHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturaHasta.Location = new System.Drawing.Point(482, 153);
            this.txtFacturaHasta.MaxLength = 70;
            this.txtFacturaHasta.Multiline = true;
            this.txtFacturaHasta.Name = "txtFacturaHasta";
            this.txtFacturaHasta.Size = new System.Drawing.Size(120, 27);
            this.txtFacturaHasta.TabIndex = 65;
            this.txtFacturaHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFacturaHasta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(416, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "Hasta:";
            // 
            // txtFacturaDesde
            // 
            this.txtFacturaDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturaDesde.Location = new System.Drawing.Point(290, 153);
            this.txtFacturaDesde.MaxLength = 70;
            this.txtFacturaDesde.Multiline = true;
            this.txtFacturaDesde.Name = "txtFacturaDesde";
            this.txtFacturaDesde.Size = new System.Drawing.Size(120, 27);
            this.txtFacturaDesde.TabIndex = 63;
            this.txtFacturaDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFacturaDesde_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(226, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 62;
            this.label4.Text = "Desde:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 21);
            this.label8.TabIndex = 61;
            this.label8.Text = "Número Factura a Pagar";
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtInactivo.Location = new System.Drawing.Point(239, 39);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(94, 25);
            this.rbtInactivo.TabIndex = 60;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtActivo.Location = new System.Drawing.Point(107, 39);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(81, 25);
            this.rbtActivo.TabIndex = 59;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 58;
            this.label3.Text = "Estado";
            // 
            // mtbSolicitudHasta
            // 
            this.mtbSolicitudHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbSolicitudHasta.Location = new System.Drawing.Point(451, 205);
            this.mtbSolicitudHasta.Mask = "00/00/0000";
            this.mtbSolicitudHasta.Name = "mtbSolicitudHasta";
            this.mtbSolicitudHasta.Size = new System.Drawing.Size(120, 26);
            this.mtbSolicitudHasta.TabIndex = 57;
            this.mtbSolicitudHasta.ValidatingType = typeof(System.DateTime);
            this.mtbSolicitudHasta.Click += new System.EventHandler(this.mtbSolicitudHasta_Click);
            // 
            // mtbSolicitudDesde
            // 
            this.mtbSolicitudDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbSolicitudDesde.Location = new System.Drawing.Point(259, 205);
            this.mtbSolicitudDesde.Mask = "00/00/0000";
            this.mtbSolicitudDesde.Name = "mtbSolicitudDesde";
            this.mtbSolicitudDesde.Size = new System.Drawing.Size(120, 26);
            this.mtbSolicitudDesde.TabIndex = 56;
            this.mtbSolicitudDesde.ValidatingType = typeof(System.DateTime);
            this.mtbSolicitudDesde.Click += new System.EventHandler(this.mtbSolicitudDesde_Click);
            // 
            // txtMontoHasta
            // 
            this.txtMontoHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoHasta.Location = new System.Drawing.Point(386, 260);
            this.txtMontoHasta.MaxLength = 7;
            this.txtMontoHasta.Multiline = true;
            this.txtMontoHasta.Name = "txtMontoHasta";
            this.txtMontoHasta.Size = new System.Drawing.Size(120, 27);
            this.txtMontoHasta.TabIndex = 53;
            this.txtMontoHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoHasta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(320, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Hasta:";
            // 
            // txtMontoDesde
            // 
            this.txtMontoDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoDesde.Location = new System.Drawing.Point(172, 260);
            this.txtMontoDesde.MaxLength = 7;
            this.txtMontoDesde.Multiline = true;
            this.txtMontoDesde.Name = "txtMontoDesde";
            this.txtMontoDesde.Size = new System.Drawing.Size(120, 27);
            this.txtMontoDesde.TabIndex = 51;
            this.txtMontoDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoDesde_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(103, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 21);
            this.label14.TabIndex = 50;
            this.label14.Text = "Desde:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 21);
            this.label15.TabIndex = 49;
            this.label15.Text = "Monto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(385, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 48;
            this.label10.Text = "Hasta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(191, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 21);
            this.label11.TabIndex = 47;
            this.label11.Text = "Desde:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 21);
            this.label12.TabIndex = 46;
            this.label12.Text = "Fecha de Solicitud";
            // 
            // txtDocumentoHasta
            // 
            this.txtDocumentoHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoHasta.Location = new System.Drawing.Point(476, 97);
            this.txtDocumentoHasta.MaxLength = 70;
            this.txtDocumentoHasta.Multiline = true;
            this.txtDocumentoHasta.Name = "txtDocumentoHasta";
            this.txtDocumentoHasta.Size = new System.Drawing.Size(120, 27);
            this.txtDocumentoHasta.TabIndex = 42;
            this.txtDocumentoHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumentoHasta_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(410, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Hasta:";
            // 
            // txtDocumentoDesde
            // 
            this.txtDocumentoDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoDesde.Location = new System.Drawing.Point(284, 97);
            this.txtDocumentoDesde.MaxLength = 70;
            this.txtDocumentoDesde.Multiline = true;
            this.txtDocumentoDesde.Name = "txtDocumentoDesde";
            this.txtDocumentoDesde.Size = new System.Drawing.Size(120, 27);
            this.txtDocumentoDesde.TabIndex = 40;
            this.txtDocumentoDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumentoDesde_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(215, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Número de documento";
            // 
            // cmdReporte
            // 
            this.cmdReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReporte.Image = ((System.Drawing.Image)(resources.GetObject("cmdReporte.Image")));
            this.cmdReporte.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdReporte.Location = new System.Drawing.Point(128, 364);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(139, 96);
            this.cmdReporte.TabIndex = 5;
            this.cmdReporte.Text = "Hacer Reporte";
            this.cmdReporte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdReporte.UseVisualStyleBackColor = true;
            this.cmdReporte.Click += new System.EventHandler(this.cmdReporte_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("cmdLimpiar.Image")));
            this.cmdLimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdLimpiar.Location = new System.Drawing.Point(363, 364);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(145, 93);
            this.cmdLimpiar.TabIndex = 4;
            this.cmdLimpiar.Text = "Limpiar campos";
            this.cmdLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // FrmReportePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 472);
            this.Controls.Add(this.cmdReporte);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReportePagos";
            this.Text = "Parámetros de pago";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtbSolicitudHasta;
        private System.Windows.Forms.MaskedTextBox mtbSolicitudDesde;
        private System.Windows.Forms.TextBox txtMontoHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoDesde;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDocumentoHasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDocumentoDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdReporte;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.TextBox txtFacturaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFacturaDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}