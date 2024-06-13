namespace UIDeportes
{
    partial class FormEditarUsuario
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.cboxCargo = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tboxApellido = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.tboxCorreo = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.tboxCalle = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tboxNumeroCalle = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.tboxLocalidad = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.tboxCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEditar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.tboxDni = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.tboxNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.tboxClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(581, 266);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 47);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar Usuario";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(713, 266);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 47);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(218, 58);
            this.tboxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(211, 20);
            this.tboxNombre.TabIndex = 2;
            // 
            // cboxCargo
            // 
            this.cboxCargo.FormattingEnabled = true;
            this.cboxCargo.Location = new System.Drawing.Point(218, 174);
            this.cboxCargo.Margin = new System.Windows.Forms.Padding(2);
            this.cboxCargo.Name = "cboxCargo";
            this.cboxCargo.Size = new System.Drawing.Size(211, 21);
            this.cboxCargo.TabIndex = 3;
            this.cboxCargo.SelectedIndexChanged += new System.EventHandler(this.cboxCargo_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(101, 62);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(101, 100);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // tboxApellido
            // 
            this.tboxApellido.Location = new System.Drawing.Point(218, 96);
            this.tboxApellido.Margin = new System.Windows.Forms.Padding(2);
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(211, 20);
            this.tboxApellido.TabIndex = 5;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(101, 141);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(94, 13);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo Electronico";
            // 
            // tboxCorreo
            // 
            this.tboxCorreo.Location = new System.Drawing.Point(218, 137);
            this.tboxCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.tboxCorreo.Name = "tboxCorreo";
            this.tboxCorreo.Size = new System.Drawing.Size(211, 20);
            this.tboxCorreo.TabIndex = 7;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(486, 57);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 10;
            this.lblCalle.Text = "Calle";
            // 
            // tboxCalle
            // 
            this.tboxCalle.Location = new System.Drawing.Point(603, 53);
            this.tboxCalle.Margin = new System.Windows.Forms.Padding(2);
            this.tboxCalle.Name = "tboxCalle";
            this.tboxCalle.Size = new System.Drawing.Size(211, 20);
            this.tboxCalle.TabIndex = 9;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(486, 98);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Text = "Numero";
            // 
            // tboxNumeroCalle
            // 
            this.tboxNumeroCalle.Location = new System.Drawing.Point(603, 94);
            this.tboxNumeroCalle.Margin = new System.Windows.Forms.Padding(2);
            this.tboxNumeroCalle.Name = "tboxNumeroCalle";
            this.tboxNumeroCalle.Size = new System.Drawing.Size(211, 20);
            this.tboxNumeroCalle.TabIndex = 11;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(486, 137);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 14;
            this.lblLocalidad.Text = "Localidad";
            // 
            // tboxLocalidad
            // 
            this.tboxLocalidad.Location = new System.Drawing.Point(603, 133);
            this.tboxLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.tboxLocalidad.Name = "tboxLocalidad";
            this.tboxLocalidad.Size = new System.Drawing.Size(211, 20);
            this.tboxLocalidad.TabIndex = 13;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(487, 176);
            this.lblCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(72, 13);
            this.lblCP.TabIndex = 16;
            this.lblCP.Text = "Codigo Postal";
            // 
            // tboxCodigoPostal
            // 
            this.tboxCodigoPostal.Location = new System.Drawing.Point(603, 174);
            this.tboxCodigoPostal.Margin = new System.Windows.Forms.Padding(2);
            this.tboxCodigoPostal.Name = "tboxCodigoPostal";
            this.tboxCodigoPostal.Size = new System.Drawing.Size(211, 20);
            this.tboxCodigoPostal.TabIndex = 15;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(101, 179);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 17;
            this.lblCargo.Text = "Cargo";
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.Location = new System.Drawing.Point(95, 18);
            this.lblEditar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(181, 20);
            this.lblEditar.TabIndex = 18;
            this.lblEditar.Text = "Editar Datos Personales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Editar Dirección";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(101, 214);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 21;
            this.lblDNI.Text = "DNI";
            // 
            // tboxDni
            // 
            this.tboxDni.Location = new System.Drawing.Point(218, 211);
            this.tboxDni.Margin = new System.Windows.Forms.Padding(2);
            this.tboxDni.Name = "tboxDni";
            this.tboxDni.Size = new System.Drawing.Size(211, 20);
            this.tboxDni.TabIndex = 20;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(101, 253);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(98, 13);
            this.lblNombreUsuario.TabIndex = 23;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // tboxNombreUsuario
            // 
            this.tboxNombreUsuario.Location = new System.Drawing.Point(218, 250);
            this.tboxNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tboxNombreUsuario.Name = "tboxNombreUsuario";
            this.tboxNombreUsuario.Size = new System.Drawing.Size(211, 20);
            this.tboxNombreUsuario.TabIndex = 22;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(101, 292);
            this.lblClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 25;
            this.lblClave.Text = "Clave";
            // 
            // tboxClave
            // 
            this.tboxClave.Location = new System.Drawing.Point(218, 288);
            this.tboxClave.Margin = new System.Windows.Forms.Padding(2);
            this.tboxClave.Name = "tboxClave";
            this.tboxClave.Size = new System.Drawing.Size(211, 20);
            this.tboxClave.TabIndex = 24;
            // 
            // FormEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 420);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.tboxClave);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.tboxNombreUsuario);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.tboxDni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEditar);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.tboxCodigoPostal);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.tboxLocalidad);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.tboxNumeroCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.tboxCalle);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.tboxCorreo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tboxApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cboxCargo);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.ComboBox cboxCargo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tboxApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox tboxCorreo;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox tboxCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox tboxNumeroCalle;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox tboxLocalidad;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox tboxCodigoPostal;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox tboxDni;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox tboxNombreUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox tboxClave;
    }
}