namespace CuentasPorPagar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnPrincipal = new CuentasPorPagar.pnPrincipal();
            this.btnPanelMantenimientos = new System.Windows.Forms.Button();
            this.Selector = new System.Windows.Forms.Panel();
            this.btnPanelPrincipal = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnMantenimientos1 = new CuentasPorPagar.PnMantenimientos();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 731);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.btnPanelMantenimientos);
            this.panel5.Controls.Add(this.Selector);
            this.panel5.Controls.Add(this.btnPanelPrincipal);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(257, 731);
            this.panel5.TabIndex = 4;
            // 
            // pnPrincipal1
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pnPrincipal.Location = new System.Drawing.Point(263, 147);
            this.pnPrincipal.Name = "pnPrincipal1";
            this.pnPrincipal.Size = new System.Drawing.Size(891, 572);
            this.pnPrincipal.TabIndex = 5;
            // 
            // btnPanelMantenimientos
            // 
            this.btnPanelMantenimientos.FlatAppearance.BorderSize = 0;
            this.btnPanelMantenimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelMantenimientos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelMantenimientos.ForeColor = System.Drawing.Color.White;
            this.btnPanelMantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelMantenimientos.Image")));
            this.btnPanelMantenimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelMantenimientos.Location = new System.Drawing.Point(12, 194);
            this.btnPanelMantenimientos.Name = "btnPanelMantenimientos";
            this.btnPanelMantenimientos.Size = new System.Drawing.Size(245, 86);
            this.btnPanelMantenimientos.TabIndex = 4;
            this.btnPanelMantenimientos.Text = "        Mantenimientos";
            this.btnPanelMantenimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelMantenimientos.UseVisualStyleBackColor = true;
            this.btnPanelMantenimientos.Click += new System.EventHandler(this.btnPanelMantenimientos_Click);
            // 
            // Selector
            // 
            this.Selector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Selector.Location = new System.Drawing.Point(0, 102);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(15, 86);
            this.Selector.TabIndex = 3;
            // 
            // btnPanelPrincipal
            // 
            this.btnPanelPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPanelPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelPrincipal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnPanelPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelPrincipal.Image")));
            this.btnPanelPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelPrincipal.Location = new System.Drawing.Point(12, 102);
            this.btnPanelPrincipal.Name = "btnPanelPrincipal";
            this.btnPanelPrincipal.Size = new System.Drawing.Size(245, 86);
            this.btnPanelPrincipal.TabIndex = 0;
            this.btnPanelPrincipal.Text = "        Principal";
            this.btnPanelPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelPrincipal.UseVisualStyleBackColor = true;
            this.btnPanelPrincipal.Click += new System.EventHandler(this.btnPanelPrincipal_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Location = new System.Drawing.Point(0, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 86);
            this.panel4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "        Principal";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(257, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 21);
            this.panel2.TabIndex = 1;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Location = new System.Drawing.Point(316, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 133);
            this.panel3.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1071, 36);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(59, 50);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnMantenimientos1
            // 
            this.pnMantenimientos1.Location = new System.Drawing.Point(263, 147);
            this.pnMantenimientos1.Name = "pnMantenimientos1";
            this.pnMantenimientos1.Size = new System.Drawing.Size(891, 572);
            this.pnMantenimientos1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 731);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.pnMantenimientos1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnPanelMantenimientos;
        private System.Windows.Forms.Panel Selector;
        private System.Windows.Forms.Button btnPanelPrincipal;
        private System.Windows.Forms.Button btnCerrar;
        private PnMantenimientos pnMantenimientos1;
        private pnPrincipal pnPrincipal;
    }
}

