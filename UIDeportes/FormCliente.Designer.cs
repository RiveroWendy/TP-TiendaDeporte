namespace UIDeportes
{
    partial class FormCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.lblIngreseDNICliente = new System.Windows.Forms.Label();
            this.tboxDNICliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.CorreoElectronico,
            this.NombreCalle,
            this.NumeroCalle,
            this.CodigoPostal,
            this.Localidad});
            this.dataGridView1.Location = new System.Drawing.Point(34, 125);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1163, 128);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.MinimumWidth = 8;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Width = 73;
            // 
            // DNI
            // 
            this.DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 8;
            this.DNI.Name = "DNI";
            this.DNI.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 150;
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.HeaderText = "Correo Electronico";
            this.CorreoElectronico.MinimumWidth = 8;
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.Width = 150;
            // 
            // NombreCalle
            // 
            this.NombreCalle.HeaderText = "Nombre Calle";
            this.NombreCalle.MinimumWidth = 8;
            this.NombreCalle.Name = "NombreCalle";
            this.NombreCalle.Width = 150;
            // 
            // NumeroCalle
            // 
            this.NumeroCalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NumeroCalle.HeaderText = "Numero Calle";
            this.NumeroCalle.MinimumWidth = 8;
            this.NumeroCalle.Name = "NumeroCalle";
            this.NumeroCalle.Width = 88;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CodigoPostal.HeaderText = "Codigo Postal";
            this.CodigoPostal.MinimumWidth = 8;
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Width = 89;
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.MinimumWidth = 8;
            this.Localidad.Name = "Localidad";
            this.Localidad.Width = 150;
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCliente.Location = new System.Drawing.Point(17, 94);
            this.lblDatosCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(132, 17);
            this.lblDatosCliente.TabIndex = 1;
            this.lblDatosCliente.Text = "Datos del Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1085, 270);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 38);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(941, 270);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(111, 38);
            this.btnModificarCliente.TabIndex = 3;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // lblIngreseDNICliente
            // 
            this.lblIngreseDNICliente.AutoSize = true;
            this.lblIngreseDNICliente.Location = new System.Drawing.Point(17, 55);
            this.lblIngreseDNICliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngreseDNICliente.Name = "lblIngreseDNICliente";
            this.lblIngreseDNICliente.Size = new System.Drawing.Size(127, 13);
            this.lblIngreseDNICliente.TabIndex = 5;
            this.lblIngreseDNICliente.Text = "Ingrese el DNI del Cliente";
            // 
            // tboxDNICliente
            // 
            this.tboxDNICliente.Location = new System.Drawing.Point(159, 51);
            this.tboxDNICliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxDNICliente.Name = "tboxDNICliente";
            this.tboxDNICliente.Size = new System.Drawing.Size(207, 20);
            this.tboxDNICliente.TabIndex = 7;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(399, 36);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(99, 32);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 554);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lblIngreseDNICliente);
            this.Controls.Add(this.tboxDNICliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Label lblIngreseDNICliente;
        private System.Windows.Forms.TextBox tboxDNICliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
    }
}