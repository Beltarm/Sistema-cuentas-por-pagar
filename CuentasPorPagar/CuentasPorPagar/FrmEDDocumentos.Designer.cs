namespace CuentasPorPagar
{
    partial class FrmEDDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEDDocumentos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.mtxFechaRegistro = new System.Windows.Forms.MaskedTextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.mtxFechaDocumento = new System.Windows.Forms.MaskedTextBox();
            this.cbxConcepto = new System.Windows.Forms.ComboBox();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxEstado);
            this.panel1.Controls.Add(this.cbxProveedor);
            this.panel1.Controls.Add(this.mtxFechaRegistro);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.mtxFechaDocumento);
            this.panel1.Controls.Add(this.cbxConcepto);
            this.panel1.Controls.Add(this.txtNumFactura);
            this.panel1.Controls.Add(this.txtNumDocumento);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 332);
            this.panel1.TabIndex = 0;
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Pagado"});
            this.cbxEstado.Location = new System.Drawing.Point(180, 249);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(158, 29);
            this.cbxEstado.TabIndex = 4;
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(521, 82);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(148, 29);
            this.cbxProveedor.TabIndex = 6;
            // 
            // mtxFechaRegistro
            // 
            this.mtxFechaRegistro.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.mtxFechaRegistro.Location = new System.Drawing.Point(521, 25);
            this.mtxFechaRegistro.Mask = "00/00/0000";
            this.mtxFechaRegistro.Name = "mtxFechaRegistro";
            this.mtxFechaRegistro.Size = new System.Drawing.Size(148, 27);
            this.mtxFechaRegistro.TabIndex = 5;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtMonto.Location = new System.Drawing.Point(521, 135);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(148, 27);
            this.txtMonto.TabIndex = 7;
            // 
            // mtxFechaDocumento
            // 
            this.mtxFechaDocumento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.mtxFechaDocumento.Location = new System.Drawing.Point(180, 188);
            this.mtxFechaDocumento.Mask = "00/00/0000";
            this.mtxFechaDocumento.Name = "mtxFechaDocumento";
            this.mtxFechaDocumento.Size = new System.Drawing.Size(158, 27);
            this.mtxFechaDocumento.TabIndex = 3;
            // 
            // cbxConcepto
            // 
            this.cbxConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConcepto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbxConcepto.FormattingEnabled = true;
            this.cbxConcepto.Location = new System.Drawing.Point(180, 130);
            this.cbxConcepto.Name = "cbxConcepto";
            this.cbxConcepto.Size = new System.Drawing.Size(158, 29);
            this.cbxConcepto.TabIndex = 2;
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNumFactura.Location = new System.Drawing.Point(180, 76);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(158, 27);
            this.txtNumFactura.TabIndex = 1;
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNumDocumento.Location = new System.Drawing.Point(180, 25);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.ReadOnly = true;
            this.txtNumDocumento.Size = new System.Drawing.Size(158, 27);
            this.txtNumDocumento.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre Proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Registro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conceto Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Documento";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.cmdGuardar.FlatAppearance.BorderSize = 3;
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGuardar.Location = new System.Drawing.Point(238, 365);
            this.cmdGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(112, 42);
            this.cmdGuardar.TabIndex = 8;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.cmdEliminar.FlatAppearance.BorderSize = 3;
            this.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.cmdEliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminar.Image")));
            this.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEliminar.Location = new System.Drawing.Point(400, 365);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(112, 42);
            this.cmdEliminar.TabIndex = 9;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // FrmEDDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 431);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmEDDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Documentos";
            this.Load += new System.EventHandler(this.FrmEDDocumentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.MaskedTextBox mtxFechaRegistro;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.MaskedTextBox mtxFechaDocumento;
        private System.Windows.Forms.ComboBox cbxConcepto;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdEliminar;
    }
}