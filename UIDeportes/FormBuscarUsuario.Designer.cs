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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngreseDireccion
            // 
            this.lblIngreseDireccion.AutoSize = true;
            this.lblIngreseDireccion.Location = new System.Drawing.Point(44, 57);
            this.lblIngreseDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngreseDireccion.Name = "lblIngreseDireccion";
            this.lblIngreseDireccion.Size = new System.Drawing.Size(131, 13);
            this.lblIngreseDireccion.TabIndex = 24;
            this.lblIngreseDireccion.Text = "Ingrese el DNI del Usuario";
            // 
            // tboxDNI
            // 
            this.tboxDNI.Location = new System.Drawing.Point(89, 97);
            this.tboxDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tboxDNI.Name = "tboxDNI";
            this.tboxDNI.Size = new System.Drawing.Size(151, 20);
            this.tboxDNI.TabIndex = 23;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(44, 101);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 22;
            this.lblDNI.Text = "DNI";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.Location = new System.Drawing.Point(445, 70);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 44);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(276, 70);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(115, 44);
            this.btnBuscarUsuario.TabIndex = 25;
            this.btnBuscarUsuario.Text = "Buscar Usuario";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.Nombre,
            this.Apellido,
            this.CorreoElectronico,
            this.Cargo,
            this.DNI,
            this.IdCargo,
            this.IdDireccion,
            this.IdLocalidad});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(42, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1301, 266);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.MinimumWidth = 8;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Width = 150;
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
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 8;
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 150;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 8;
            this.DNI.Name = "DNI";
            this.DNI.Width = 150;
            // 
            // IdCargo
            // 
            this.IdCargo.HeaderText = "IdCargo";
            this.IdCargo.MinimumWidth = 8;
            this.IdCargo.Name = "IdCargo";
            this.IdCargo.Width = 150;
            // 
            // IdDireccion
            // 
            this.IdDireccion.HeaderText = "IdDireccion";
            this.IdDireccion.MinimumWidth = 8;
            this.IdDireccion.Name = "IdDireccion";
            this.IdDireccion.Width = 150;
            // 
            // IdLocalidad
            // 
            this.IdLocalidad.HeaderText = "IdLocalidad";
            this.IdLocalidad.MinimumWidth = 8;
            this.IdLocalidad.Name = "IdLocalidad";
            this.IdLocalidad.Width = 150;
            // 
            // FormBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.lblIngreseDireccion);
            this.Controls.Add(this.tboxDNI);
            this.Controls.Add(this.lblDNI);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBuscarUsuario";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseDireccion;
        private System.Windows.Forms.TextBox tboxDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLocalidad;
    }
}