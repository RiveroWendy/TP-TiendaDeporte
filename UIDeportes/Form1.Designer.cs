namespace UIDeportes
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
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.tboxNombreUsuario = new System.Windows.Forms.TextBox();
            this.tboxClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIniciarSesion.Location = new System.Drawing.Point(197, 402);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(178, 42);
            this.btnIniciarSesion.TabIndex = 0;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(452, 402);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(178, 42);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(193, 150);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(146, 20);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(194, 230);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(92, 20);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "Contraseña";
            // 
            // tboxNombreUsuario
            // 
            this.tboxNombreUsuario.Location = new System.Drawing.Point(455, 144);
            this.tboxNombreUsuario.Name = "tboxNombreUsuario";
            this.tboxNombreUsuario.Size = new System.Drawing.Size(175, 26);
            this.tboxNombreUsuario.TabIndex = 4;
            this.tboxNombreUsuario.TextChanged += new System.EventHandler(this.tboxNombreUsuario_TextChanged);
            // 
            // tboxClave
            // 
            this.tboxClave.Location = new System.Drawing.Point(455, 224);
            this.tboxClave.Name = "tboxClave";
            this.tboxClave.Size = new System.Drawing.Size(175, 26);
            this.tboxClave.TabIndex = 5;
            this.tboxClave.TextChanged += new System.EventHandler(this.tboxClave_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1175, 738);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxClave);
            this.Controls.Add(this.tboxNombreUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIniciarSesion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox tboxNombreUsuario;
        private System.Windows.Forms.TextBox tboxClave;
        private System.Windows.Forms.Label label1;
    }
}

