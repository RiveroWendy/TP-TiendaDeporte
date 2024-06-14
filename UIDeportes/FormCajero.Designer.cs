namespace UIDeportes
{
    partial class FormCajero
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
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.btnEmitirFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Location = new System.Drawing.Point(251, 119);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(216, 98);
            this.btnBuscarVenta.TabIndex = 0;
            this.btnBuscarVenta.Text = "Buscar Venta";
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            // 
            // btnEmitirFactura
            // 
            this.btnEmitirFactura.Location = new System.Drawing.Point(251, 237);
            this.btnEmitirFactura.Name = "btnEmitirFactura";
            this.btnEmitirFactura.Size = new System.Drawing.Size(216, 98);
            this.btnEmitirFactura.TabIndex = 1;
            this.btnEmitirFactura.Text = "Emitir Factura";
            this.btnEmitirFactura.UseVisualStyleBackColor = true;
            // 
            // FormCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmitirFactura);
            this.Controls.Add(this.btnBuscarVenta);
            this.Name = "FormCajero";
            this.Text = "FormCajero";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Button btnEmitirFactura;
    }
}