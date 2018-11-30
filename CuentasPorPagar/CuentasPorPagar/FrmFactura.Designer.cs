namespace CuentasPorPagar
{
    partial class FrmFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdSolicitud = new System.Windows.Forms.TextBox();
            this.txtIdDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID solicitud";
            // 
            // txtIdSolicitud
            // 
            this.txtIdSolicitud.Location = new System.Drawing.Point(176, 83);
            this.txtIdSolicitud.Name = "txtIdSolicitud";
            this.txtIdSolicitud.Size = new System.Drawing.Size(271, 22);
            this.txtIdSolicitud.TabIndex = 1;
            // 
            // txtIdDocumento
            // 
            this.txtIdDocumento.Location = new System.Drawing.Point(176, 135);
            this.txtIdDocumento.Name = "txtIdDocumento";
            this.txtIdDocumento.Size = new System.Drawing.Size(271, 22);
            this.txtIdDocumento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID documento";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(176, 181);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(271, 22);
            this.txtNumFactura.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero factura";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(176, 233);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(271, 22);
            this.txtFecha.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(176, 283);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(271, 22);
            this.txtMonto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(568, 179);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(101, 71);
            this.btnPagar.TabIndex = 12;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdSolicitud);
            this.Controls.Add(this.label1);
            this.Name = "FrmFactura";
            this.Text = "FrmFactura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdSolicitud;
        private System.Windows.Forms.TextBox txtIdDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPagar;
    }
}