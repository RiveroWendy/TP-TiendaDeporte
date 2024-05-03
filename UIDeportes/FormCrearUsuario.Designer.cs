namespace UIDeportes
{
    partial class FormCrearUsuario
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
            this.lblCargos = new System.Windows.Forms.Label();
            this.cboxCargos = new System.Windows.Forms.ComboBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.tboxDNI = new System.Windows.Forms.TextBox();
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxApellido = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tboxCP = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.tboxAlturaCalle = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.tboxNombreCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblIngreseDireccion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCargos
            // 
            this.lblCargos.AutoSize = true;
            this.lblCargos.Location = new System.Drawing.Point(63, 366);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(150, 20);
            this.lblCargos.TabIndex = 0;
            this.lblCargos.Text = "Seleccione el Cargo";
            // 
            // cboxCargos
            // 
            this.cboxCargos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboxCargos.FormattingEnabled = true;
            this.cboxCargos.Items.AddRange(new object[] {
            "Administrativo",
            "Vendedor",
            "Cajero",
            "Encargado de Deposito",
            "Gerente"});
            this.cboxCargos.Location = new System.Drawing.Point(294, 366);
            this.cboxCargos.Name = "cboxCargos";
            this.cboxCargos.Size = new System.Drawing.Size(225, 28);
            this.cboxCargos.TabIndex = 2;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(63, 152);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(37, 20);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "DNI";
            // 
            // tboxDNI
            // 
            this.tboxDNI.Location = new System.Drawing.Point(294, 146);
            this.tboxDNI.Name = "tboxDNI";
            this.tboxDNI.Size = new System.Drawing.Size(225, 26);
            this.tboxDNI.TabIndex = 5;
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.Location = new System.Drawing.Point(509, 46);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(145, 20);
            this.lblNuevoUsuario.TabIndex = 6;
            this.lblNuevoUsuario.Text = "NUEVO USUARIO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(63, 199);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre/s";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(63, 250);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(77, 20);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido/s";
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(294, 193);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(225, 26);
            this.tboxNombre.TabIndex = 9;
            // 
            // tboxApellido
            // 
            this.tboxApellido.Location = new System.Drawing.Point(294, 247);
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(225, 26);
            this.tboxApellido.TabIndex = 10;
            // 
            // tboxEmail
            // 
            this.tboxEmail.Location = new System.Drawing.Point(294, 305);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(225, 26);
            this.tboxEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(63, 308);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(140, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Correo Electrónico";
            // 
            // tboxCP
            // 
            this.tboxCP.Location = new System.Drawing.Point(792, 302);
            this.tboxCP.Name = "tboxCP";
            this.tboxCP.Size = new System.Drawing.Size(255, 26);
            this.tboxCP.TabIndex = 20;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(618, 302);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(107, 20);
            this.lblCP.TabIndex = 19;
            this.lblCP.Text = "Código Postal";
            // 
            // tboxAlturaCalle
            // 
            this.tboxAlturaCalle.Location = new System.Drawing.Point(792, 248);
            this.tboxAlturaCalle.Name = "tboxAlturaCalle";
            this.tboxAlturaCalle.Size = new System.Drawing.Size(255, 26);
            this.tboxAlturaCalle.TabIndex = 18;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(618, 248);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(90, 20);
            this.lblAltura.TabIndex = 17;
            this.lblAltura.Text = "Altura Calle";
            // 
            // tboxNombreCalle
            // 
            this.tboxNombreCalle.Location = new System.Drawing.Point(792, 193);
            this.tboxNombreCalle.Name = "tboxNombreCalle";
            this.tboxNombreCalle.Size = new System.Drawing.Size(255, 26);
            this.tboxNombreCalle.TabIndex = 16;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(618, 193);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(104, 20);
            this.lblCalle.TabIndex = 15;
            this.lblCalle.Text = "Nombre Calle";
            // 
            // lblIngreseDireccion
            // 
            this.lblIngreseDireccion.AutoSize = true;
            this.lblIngreseDireccion.Location = new System.Drawing.Point(618, 146);
            this.lblIngreseDireccion.Name = "lblIngreseDireccion";
            this.lblIngreseDireccion.Size = new System.Drawing.Size(149, 20);
            this.lblIngreseDireccion.TabIndex = 21;
            this.lblIngreseDireccion.Text = "Ingrese la Dirección";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.Location = new System.Drawing.Point(875, 493);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(172, 67);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(622, 493);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(172, 67);
            this.btnGuardarUsuario.TabIndex = 22;
            this.btnGuardarUsuario.Text = "Guardar Usuario";
            this.btnGuardarUsuario.UseVisualStyleBackColor = false;
            // 
            // FormCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 637);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.lblIngreseDireccion);
            this.Controls.Add(this.tboxCP);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.tboxAlturaCalle);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.tboxNombreCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tboxApellido);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNuevoUsuario);
            this.Controls.Add(this.tboxDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.cboxCargos);
            this.Controls.Add(this.lblCargos);
            this.Name = "FormCrearUsuario";
            this.Text = "FormCrearUsuario";
            this.Load += new System.EventHandler(this.FormCrearUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargos;
        private System.Windows.Forms.ComboBox cboxCargos;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox tboxDNI;
        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxApellido;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tboxCP;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox tboxAlturaCalle;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox tboxNombreCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblIngreseDireccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarUsuario;
    }
}