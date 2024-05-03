namespace UIDeportes
{
    partial class FormBuscarUsuario
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
            this.lblIngreseDireccion = new System.Windows.Forms.Label();
            this.tboxDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngreseDireccion
            // 
            this.lblIngreseDireccion.AutoSize = true;
            this.lblIngreseDireccion.Location = new System.Drawing.Point(161, 98);
            this.lblIngreseDireccion.Name = "lblIngreseDireccion";
            this.lblIngreseDireccion.Size = new System.Drawing.Size(195, 20);
            this.lblIngreseDireccion.TabIndex = 24;
            this.lblIngreseDireccion.Text = "Ingrese el DNI del Usuario";
            // 
            // tboxDNI
            // 
            this.tboxDNI.Location = new System.Drawing.Point(229, 160);
            this.tboxDNI.Name = "tboxDNI";
            this.tboxDNI.Size = new System.Drawing.Size(225, 26);
            this.tboxDNI.TabIndex = 23;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(161, 166);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(37, 20);
            this.lblDNI.TabIndex = 22;
            this.lblDNI.Text = "DNI";
            this.lblDNI.Click += new System.EventHandler(this.lblDNI_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.Location = new System.Drawing.Point(389, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(172, 67);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(136, 280);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(172, 67);
            this.btnBuscarUsuario.TabIndex = 25;
            this.btnBuscarUsuario.Text = "Buscar Usuario";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // FormBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 490);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.lblIngreseDireccion);
            this.Controls.Add(this.tboxDNI);
            this.Controls.Add(this.lblDNI);
            this.Name = "FormBuscarUsuario";
            this.Text = "FormBuscarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseDireccion;
        private System.Windows.Forms.TextBox tboxDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarUsuario;
    }
}