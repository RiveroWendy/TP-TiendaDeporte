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
            this.lblNombre.Location = new System.Drawing.Point(30, 40);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(385, 223);
            this.btnGuardarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(115, 44);
            this.btnGuardarCliente.TabIndex = 1;
            this.btnGuardarCliente.Text = "Guardar Cliente";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(123, 40);
            this.tboxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(171, 20);
            this.tboxNombre.TabIndex = 2;
            // 
            // tboxApellido
            // 
            this.tboxApellido.Location = new System.Drawing.Point(123, 74);
            this.tboxApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(171, 20);
            this.tboxApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(30, 74);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // tboxDNI
            // 
            this.tboxDNI.Location = new System.Drawing.Point(123, 110);
            this.tboxDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxDNI.Name = "tboxDNI";
            this.tboxDNI.Size = new System.Drawing.Size(171, 20);
            this.tboxDNI.TabIndex = 6;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(30, 110);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "DNI";
            // 
            // tboxNumeroCalle
            // 
            this.tboxNumeroCalle.Location = new System.Drawing.Point(498, 75);
            this.tboxNumeroCalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxNumeroCalle.Name = "tboxNumeroCalle";
            this.tboxNumeroCalle.Size = new System.Drawing.Size(171, 20);
            this.tboxNumeroCalle.TabIndex = 12;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(382, 75);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(70, 13);
            this.lblAltura.TabIndex = 11;
            this.lblAltura.Text = "Numero Calle";
            // 
            // tboxNombreCalle
            // 
            this.tboxNombreCalle.Location = new System.Drawing.Point(498, 39);
            this.tboxNombreCalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxNombreCalle.Name = "tboxNombreCalle";
            this.tboxNombreCalle.Size = new System.Drawing.Size(171, 20);
            this.tboxNombreCalle.TabIndex = 10;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(382, 39);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(70, 13);
            this.lblCalle.TabIndex = 9;
            this.lblCalle.Text = "Nombre Calle";
            // 
            // tboxCorreo
            // 
            this.tboxCorreo.Location = new System.Drawing.Point(123, 145);
            this.tboxCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxCorreo.Name = "tboxCorreo";
            this.tboxCorreo.Size = new System.Drawing.Size(171, 20);
            this.tboxCorreo.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 145);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Correo Electrónico";
            // 
            // tboxCodigoPostal
            // 
            this.tboxCodigoPostal.Location = new System.Drawing.Point(498, 110);
            this.tboxCodigoPostal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxCodigoPostal.Name = "tboxCodigoPostal";
            this.tboxCodigoPostal.Size = new System.Drawing.Size(171, 20);
            this.tboxCodigoPostal.TabIndex = 14;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(382, 110);
            this.lblCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(72, 13);
            this.lblCP.TabIndex = 13;
            this.lblCP.Text = "Código Postal";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(553, 223);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 44);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tboxLocalidad
            // 
            this.tboxLocalidad.Location = new System.Drawing.Point(498, 145);
            this.tboxLocalidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxLocalidad.Name = "tboxLocalidad";
            this.tboxLocalidad.Size = new System.Drawing.Size(171, 20);
            this.tboxLocalidad.TabIndex = 17;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(382, 145);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 16;
            this.lblLocalidad.Text = "Localidad";
            // 
            // FormDatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 292);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDatosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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