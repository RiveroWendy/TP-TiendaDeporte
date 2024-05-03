namespace UIDeportes
{
    partial class FormBuscarCliente
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
            this.tboxDNICliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblIngreseDNICliente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxDNICliente
            // 
            this.tboxDNICliente.Location = new System.Drawing.Point(331, 128);
            this.tboxDNICliente.Name = "tboxDNICliente";
            this.tboxDNICliente.Size = new System.Drawing.Size(332, 26);
            this.tboxDNICliente.TabIndex = 0;
            this.tboxDNICliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(331, 294);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(148, 50);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // lblIngreseDNICliente
            // 
            this.lblIngreseDNICliente.AutoSize = true;
            this.lblIngreseDNICliente.Location = new System.Drawing.Point(96, 134);
            this.lblIngreseDNICliente.Name = "lblIngreseDNICliente";
            this.lblIngreseDNICliente.Size = new System.Drawing.Size(189, 20);
            this.lblIngreseDNICliente.TabIndex = 2;
            this.lblIngreseDNICliente.Text = "Ingrese el DNI del Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(515, 294);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 50);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblIngreseDNICliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.tboxDNICliente);
            this.Name = "FormBuscarCliente";
            this.Text = "FormBuscarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxDNICliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblIngreseDNICliente;
        private System.Windows.Forms.Button btnCancelar;
    }
}