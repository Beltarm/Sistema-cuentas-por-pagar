namespace CuentasPorPagar
{
    partial class FrmProveedores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdAgregar);
            this.panel1.Controls.Add(this.cmdBuscar);
            this.panel1.Controls.Add(this.cbxCriterio);
            this.panel1.Controls.Add(this.txtConcepto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(106, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criterio";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(241, 41);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(137, 27);
            this.txtConcepto.TabIndex = 2;
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "Cédula",
            "Tipo de persona",
            "Balance",
            "Estado"});
            this.cbxCriterio.Location = new System.Drawing.Point(97, 41);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 29);
            this.cbxCriterio.TabIndex = 3;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(484, 43);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 5;
            this.cmdAgregar.Text = "button1";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProveedores);
            this.panel2.Location = new System.Drawing.Point(106, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 255);
            this.panel2.TabIndex = 1;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(19, 12);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(553, 229);
            this.dgvProveedores.TabIndex = 0;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(394, 43);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 4;
            this.cmdBuscar.Text = "button1";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button cmdBuscar;
    }
}