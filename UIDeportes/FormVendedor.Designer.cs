namespace UIDeportes
{
    partial class FormVendedor
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
            this.btnGenerarVenta = new System.Windows.Forms.Button();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnGenerarReporteVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.Location = new System.Drawing.Point(128, 61);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(283, 68);
            this.btnGenerarVenta.TabIndex = 0;
            this.btnGenerarVenta.Text = "Generar Venta";
            this.btnGenerarVenta.UseVisualStyleBackColor = true;
            this.btnGenerarVenta.Click += new System.EventHandler(this.btnGenerarVenta_Click);
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Location = new System.Drawing.Point(128, 353);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(283, 68);
            this.btnBuscarVenta.TabIndex = 1;
            this.btnBuscarVenta.Text = "Buscar Venta";
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(128, 250);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(283, 68);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(128, 156);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(283, 68);
            this.btnAltaCliente.TabIndex = 3;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnGenerarReporteVenta
            // 
            this.btnGenerarReporteVenta.Location = new System.Drawing.Point(128, 459);
            this.btnGenerarReporteVenta.Name = "btnGenerarReporteVenta";
            this.btnGenerarReporteVenta.Size = new System.Drawing.Size(283, 68);
            this.btnGenerarReporteVenta.TabIndex = 4;
            this.btnGenerarReporteVenta.Text = "Generar Reporte de Venta";
            this.btnGenerarReporteVenta.UseVisualStyleBackColor = true;
            // 
            // FormVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 714);
            this.Controls.Add(this.btnGenerarReporteVenta);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnBuscarVenta);
            this.Controls.Add(this.btnGenerarVenta);
            this.Name = "FormVendedor";
            this.Text = "FormVendedor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarVenta;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnGenerarReporteVenta;
    }
}