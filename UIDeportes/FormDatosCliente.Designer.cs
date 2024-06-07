namespace UIDeportes
{
    partial class FormDatosCliente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tboxDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.tboxNumeroCalle = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.tboxNombreCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.tboxCorreo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tboxCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tboxLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(45, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(577, 343);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(172, 67);
            this.btnGuardarCliente.TabIndex = 1;
            this.btnGuardarCliente.Text = "Guardar Cliente";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(185, 61);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(255, 26);
            this.tboxNombre.TabIndex = 2;
            this.tboxNombre.TextChanged += new System.EventHandler(this.tboxNombre_TextChanged);
            // 
            // tboxApellido
            // 
            this.tboxApellido.Location = new System.Drawing.Point(185, 114);
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(255, 26);
            this.tboxApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(45, 114);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // tboxDNI
            // 
            this.tboxDNI.Location = new System.Drawing.Point(185, 169);
            this.tboxDNI.Name = "tboxDNI";
            this.tboxDNI.Size = new System.Drawing.Size(255, 26);
            this.tboxDNI.TabIndex = 6;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(45, 169);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(37, 20);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "DNI";
            // 
            // tboxNumeroCalle
            // 
            this.tboxNumeroCalle.Location = new System.Drawing.Point(747, 115);
            this.tboxNumeroCalle.Name = "tboxNumeroCalle";
            this.tboxNumeroCalle.Size = new System.Drawing.Size(255, 26);
            this.tboxNumeroCalle.TabIndex = 12;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(573, 115);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(104, 20);
            this.lblAltura.TabIndex = 11;
            this.lblAltura.Text = "Numero Calle";
            // 
            // tboxNombreCalle
            // 
            this.tboxNombreCalle.Location = new System.Drawing.Point(747, 60);
            this.tboxNombreCalle.Name = "tboxNombreCalle";
            this.tboxNombreCalle.Size = new System.Drawing.Size(255, 26);
            this.tboxNombreCalle.TabIndex = 10;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(573, 60);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(104, 20);
            this.lblCalle.TabIndex = 9;
            this.lblCalle.Text = "Nombre Calle";
            // 
            // tboxCorreo
            // 
            this.tboxCorreo.Location = new System.Drawing.Point(185, 223);
            this.tboxCorreo.Name = "tboxCorreo";
            this.tboxCorreo.Size = new System.Drawing.Size(255, 26);
            this.tboxCorreo.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 223);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(140, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Correo Electrónico";
            // 
            // tboxCodigoPostal
            // 
            this.tboxCodigoPostal.Location = new System.Drawing.Point(747, 169);
            this.tboxCodigoPostal.Name = "tboxCodigoPostal";
            this.tboxCodigoPostal.Size = new System.Drawing.Size(255, 26);
            this.tboxCodigoPostal.TabIndex = 14;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(573, 169);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(107, 20);
            this.lblCP.TabIndex = 13;
            this.lblCP.Text = "Código Postal";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(830, 343);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(172, 67);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tboxLocalidad
            // 
            this.tboxLocalidad.Location = new System.Drawing.Point(747, 223);
            this.tboxLocalidad.Name = "tboxLocalidad";
            this.tboxLocalidad.Size = new System.Drawing.Size(255, 26);
            this.tboxLocalidad.TabIndex = 17;
            this.tboxLocalidad.TextChanged += new System.EventHandler(this.tboxLocalidad_TextChanged);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(573, 223);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(77, 20);
            this.lblLocalidad.TabIndex = 16;
            this.lblLocalidad.Text = "Localidad";
            // 
            // FormDatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 450);
            this.Controls.Add(this.tboxLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tboxCodigoPostal);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.tboxNumeroCalle);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.tboxNombreCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.tboxCorreo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tboxDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.tboxApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormDatosCliente";
            this.Text = "FormDatosCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tboxDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox tboxNumeroCalle;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox tboxNombreCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox tboxCorreo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tboxCodigoPostal;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tboxLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
    }
}