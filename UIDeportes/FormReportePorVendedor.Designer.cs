namespace UIDeportes
{
    partial class FormReportePorVendedor
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
            this.btnBuscarVendedor = new System.Windows.Forms.Button();
            this.lblIngresarDNI = new System.Windows.Forms.Label();
            this.tboxIngresarDNI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuscarVendedor
            // 
            this.btnBuscarVendedor.Location = new System.Drawing.Point(105, 175);
            this.btnBuscarVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarVendedor.Name = "btnBuscarVendedor";
            this.btnBuscarVendedor.Size = new System.Drawing.Size(139, 42);
            this.btnBuscarVendedor.TabIndex = 0;
            this.btnBuscarVendedor.Text = "Buscar";
            this.btnBuscarVendedor.UseVisualStyleBackColor = true;
            // 
            // lblIngresarDNI
            // 
            this.lblIngresarDNI.AutoSize = true;
            this.lblIngresarDNI.Location = new System.Drawing.Point(103, 107);
            this.lblIngresarDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngresarDNI.Name = "lblIngresarDNI";
            this.lblIngresarDNI.Size = new System.Drawing.Size(116, 13);
            this.lblIngresarDNI.TabIndex = 1;
            this.lblIngresarDNI.Text = "Ingresar DNI Vendedor";
            // 
            // tboxIngresarDNI
            // 
            this.tboxIngresarDNI.Location = new System.Drawing.Point(105, 133);
            this.tboxIngresarDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxIngresarDNI.Name = "tboxIngresarDNI";
            this.tboxIngresarDNI.Size = new System.Drawing.Size(136, 20);
            this.tboxIngresarDNI.TabIndex = 2;
            // 
            // FormReportePorVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.tboxIngresarDNI);
            this.Controls.Add(this.lblIngresarDNI);
            this.Controls.Add(this.btnBuscarVendedor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormReportePorVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportePorVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarVendedor;
        private System.Windows.Forms.Label lblIngresarDNI;
        private System.Windows.Forms.TextBox tboxIngresarDNI;
    }
}