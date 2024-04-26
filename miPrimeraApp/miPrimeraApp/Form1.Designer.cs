namespace miPrimeraApp
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
            this.tbnIniciarSesion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tboxUser = new System.Windows.Forms.TextBox();
            this.tboxPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbnIniciarSesion
            // 
            this.tbnIniciarSesion.Location = new System.Drawing.Point(26, 243);
            this.tbnIniciarSesion.Name = "tbnIniciarSesion";
            this.tbnIniciarSesion.Size = new System.Drawing.Size(102, 23);
            this.tbnIniciarSesion.TabIndex = 0;
            this.tbnIniciarSesion.Text = "Iniciar Sesion";
            this.tbnIniciarSesion.UseVisualStyleBackColor = true;
            this.tbnIniciarSesion.Click += new System.EventHandler(this.tbnIniciarSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(268, 243);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(23, 117);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(23, 174);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(61, 13);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Contraseña";
            // 
            // tboxUser
            // 
            this.tboxUser.Location = new System.Drawing.Point(104, 110);
            this.tboxUser.Name = "tboxUser";
            this.tboxUser.Size = new System.Drawing.Size(239, 20);
            this.tboxUser.TabIndex = 4;
            this.tboxUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tboxPass
            // 
            this.tboxPass.Location = new System.Drawing.Point(104, 167);
            this.tboxPass.Name = "tboxPass";
            this.tboxPass.Size = new System.Drawing.Size(239, 20);
            this.tboxPass.TabIndex = 5;
            this.tboxPass.TextChanged += new System.EventHandler(this.tboxPass_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 318);
            this.Controls.Add(this.tboxPass);
            this.Controls.Add(this.tboxUser);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tbnIniciarSesion);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbnIniciarSesion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tboxUser;
        private System.Windows.Forms.TextBox tboxPass;
    }
}

