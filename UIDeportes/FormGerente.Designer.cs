namespace UIDeportes
{
    partial class FormGerente
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
            this.btnRepVendedor = new System.Windows.Forms.Button();
            this.btnRepGralVtas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRepVendedor
            // 
            this.btnRepVendedor.Location = new System.Drawing.Point(261, 222);
            this.btnRepVendedor.Name = "btnRepVendedor";
            this.btnRepVendedor.Size = new System.Drawing.Size(256, 97);
            this.btnRepVendedor.TabIndex = 1;
            this.btnRepVendedor.Text = "Reporte de Ventas por Vendedor";
            this.btnRepVendedor.UseVisualStyleBackColor = true;
            this.btnRepVendedor.Click += new System.EventHandler(this.btnRepVendedor_Click);
            // 
            // btnRepGralVtas
            // 
            this.btnRepGralVtas.Location = new System.Drawing.Point(261, 81);
            this.btnRepGralVtas.Name = "btnRepGralVtas";
            this.btnRepGralVtas.Size = new System.Drawing.Size(256, 97);
            this.btnRepGralVtas.TabIndex = 2;
            this.btnRepGralVtas.Text = "Reporte General de Ventas";
            this.btnRepGralVtas.UseVisualStyleBackColor = true;
            this.btnRepGralVtas.Click += new System.EventHandler(this.btnRepGralVtas_Click);
            // 
            // FormGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRepGralVtas);
            this.Controls.Add(this.btnRepVendedor);
            this.Name = "FormGerente";
            this.Text = "FormGerente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRepVendedor;
        private System.Windows.Forms.Button btnRepGralVtas;
    }
}