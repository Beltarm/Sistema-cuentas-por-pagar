namespace CuentasPorPagar
{
    partial class pnReportes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnReportes));
            this.cmdConceptos = new System.Windows.Forms.Button();
            this.cmdDocumentos = new System.Windows.Forms.Button();
            this.cmdProveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdConceptos
            // 
            this.cmdConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConceptos.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConceptos.Image = ((System.Drawing.Image)(resources.GetObject("cmdConceptos.Image")));
            this.cmdConceptos.Location = new System.Drawing.Point(461, 82);
            this.cmdConceptos.Margin = new System.Windows.Forms.Padding(2);
            this.cmdConceptos.Name = "cmdConceptos";
            this.cmdConceptos.Size = new System.Drawing.Size(188, 257);
            this.cmdConceptos.TabIndex = 4;
            this.cmdConceptos.Text = "Pagos";
            this.cmdConceptos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdConceptos.UseVisualStyleBackColor = true;
            this.cmdConceptos.Click += new System.EventHandler(this.cmdConceptos_Click);
            // 
            // cmdDocumentos
            // 
            this.cmdDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDocumentos.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDocumentos.Image = ((System.Drawing.Image)(resources.GetObject("cmdDocumentos.Image")));
            this.cmdDocumentos.Location = new System.Drawing.Point(241, 82);
            this.cmdDocumentos.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDocumentos.Name = "cmdDocumentos";
            this.cmdDocumentos.Size = new System.Drawing.Size(188, 257);
            this.cmdDocumentos.TabIndex = 3;
            this.cmdDocumentos.Text = "Documentos";
            this.cmdDocumentos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdDocumentos.UseVisualStyleBackColor = true;
            this.cmdDocumentos.Click += new System.EventHandler(this.cmdDocumentos_Click);
            // 
            // cmdProveedores
            // 
            this.cmdProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProveedores.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProveedores.Image = ((System.Drawing.Image)(resources.GetObject("cmdProveedores.Image")));
            this.cmdProveedores.Location = new System.Drawing.Point(29, 82);
            this.cmdProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.cmdProveedores.Name = "cmdProveedores";
            this.cmdProveedores.Size = new System.Drawing.Size(188, 257);
            this.cmdProveedores.TabIndex = 2;
            this.cmdProveedores.Text = "Proveedores";
            this.cmdProveedores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdProveedores.UseVisualStyleBackColor = true;
            this.cmdProveedores.Click += new System.EventHandler(this.cmdProveedores_Click);
            // 
            // pnReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdConceptos);
            this.Controls.Add(this.cmdDocumentos);
            this.Controls.Add(this.cmdProveedores);
            this.Name = "pnReportes";
            this.Size = new System.Drawing.Size(668, 465);
            this.Load += new System.EventHandler(this.pnReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdProveedores;
        private System.Windows.Forms.Button cmdDocumentos;
        private System.Windows.Forms.Button cmdConceptos;
    }
}
