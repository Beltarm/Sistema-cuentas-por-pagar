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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNumFactura.Location = new System.Drawing.Point(164, 25);
            this.txtNumFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.ReadOnly = true;
            this.txtNumFactura.Size = new System.Drawing.Size(204, 27);
            this.txtNumFactura.TabIndex = 5;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtFecha.Location = new System.Drawing.Point(164, 77);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(204, 27);
            this.txtFecha.TabIndex = 7;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtMonto.Location = new System.Drawing.Point(164, 135);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(204, 27);
            this.txtMonto.TabIndex = 9;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // btnPagar
            // 
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnPagar.Image")));
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagar.Location = new System.Drawing.Point(144, 182);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(128, 96);
            this.btnPagar.TabIndex = 12;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Número factura";
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 289);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNumFactura);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plataforma de pago";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}