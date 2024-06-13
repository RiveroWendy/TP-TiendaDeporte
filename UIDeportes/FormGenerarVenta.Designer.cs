namespace UIDeportes
{
    partial class FormGenerarVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGuardarVenta = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cbxProductos = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tbxCantidadProducto = new System.Windows.Forms.TextBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.lblEnvioDomicilio = new System.Windows.Forms.Label();
            this.checkBoxSI = new System.Windows.Forms.CheckBox();
            this.checkBoxNO = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarProductoVenta = new System.Windows.Forms.Button();
            this.dgvProductosVenta = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.Location = new System.Drawing.Point(212, 424);
            this.btnGuardarVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(112, 40);
            this.btnGuardarVenta.TabIndex = 5;
            this.btnGuardarVenta.Text = "Guardar Venta";
            this.btnGuardarVenta.UseVisualStyleBackColor = true;
            this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(23, 33);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto";
            // 
            // cbxProductos
            // 
            this.cbxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProductos.FormattingEnabled = true;
            this.cbxProductos.Location = new System.Drawing.Point(89, 28);
            this.cbxProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxProductos.Name = "cbxProductos";
            this.cbxProductos.Size = new System.Drawing.Size(135, 21);
            this.cbxProductos.TabIndex = 0;
            this.cbxProductos.DropDown += new System.EventHandler(this.cbxProductos_DropDown);
            this.cbxProductos.SelectedIndexChanged += new System.EventHandler(this.cbxProductos_SelectedIndexChanged);
            this.cbxProductos.Validating += new System.ComponentModel.CancelEventHandler(this.cbxProductos_Validating);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(282, 33);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // tbxCantidadProducto
            // 
            this.tbxCantidadProducto.Location = new System.Drawing.Point(350, 29);
            this.tbxCantidadProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCantidadProducto.Name = "tbxCantidadProducto";
            this.tbxCantidadProducto.Size = new System.Drawing.Size(60, 20);
            this.tbxCantidadProducto.TabIndex = 1;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(222, 28);
            this.txtDniCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(176, 20);
            this.txtDniCliente.TabIndex = 27;
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Location = new System.Drawing.Point(63, 32);
            this.lblDNICliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(116, 13);
            this.lblDNICliente.TabIndex = 26;
            this.lblDNICliente.Text = "Ingrese DNI del Cliente";
            // 
            // lblEnvioDomicilio
            // 
            this.lblEnvioDomicilio.AutoSize = true;
            this.lblEnvioDomicilio.Location = new System.Drawing.Point(180, 380);
            this.lblEnvioDomicilio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnvioDomicilio.Name = "lblEnvioDomicilio";
            this.lblEnvioDomicilio.Size = new System.Drawing.Size(90, 13);
            this.lblEnvioDomicilio.TabIndex = 28;
            this.lblEnvioDomicilio.Text = "Envío a Domicilio";
            // 
            // checkBoxSI
            // 
            this.checkBoxSI.AutoSize = true;
            this.checkBoxSI.Location = new System.Drawing.Point(338, 378);
            this.checkBoxSI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSI.Name = "checkBoxSI";
            this.checkBoxSI.Size = new System.Drawing.Size(35, 17);
            this.checkBoxSI.TabIndex = 29;
            this.checkBoxSI.Text = "Si";
            this.checkBoxSI.UseVisualStyleBackColor = true;
            // 
            // checkBoxNO
            // 
            this.checkBoxNO.AutoSize = true;
            this.checkBoxNO.Location = new System.Drawing.Point(438, 378);
            this.checkBoxNO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxNO.Name = "checkBoxNO";
            this.checkBoxNO.Size = new System.Drawing.Size(40, 17);
            this.checkBoxNO.TabIndex = 30;
            this.checkBoxNO.Text = "No";
            this.checkBoxNO.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(375, 424);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 40);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDniCliente);
            this.groupBox1.Controls.Add(this.lblDNICliente);
            this.groupBox1.Location = new System.Drawing.Point(99, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 66);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarProductoVenta);
            this.groupBox2.Controls.Add(this.cbxProductos);
            this.groupBox2.Controls.Add(this.lblProducto);
            this.groupBox2.Controls.Add(this.lblCantidad);
            this.groupBox2.Controls.Add(this.tbxCantidadProducto);
            this.groupBox2.Location = new System.Drawing.Point(99, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 69);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso de productos";
            // 
            // btnAgregarProductoVenta
            // 
            this.btnAgregarProductoVenta.Location = new System.Drawing.Point(442, 27);
            this.btnAgregarProductoVenta.Name = "btnAgregarProductoVenta";
            this.btnAgregarProductoVenta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProductoVenta.TabIndex = 2;
            this.btnAgregarProductoVenta.Text = "Agregar";
            this.btnAgregarProductoVenta.UseVisualStyleBackColor = true;
            this.btnAgregarProductoVenta.Click += new System.EventHandler(this.btnAgregarProductoVenta_Click);
            // 
            // dgvProductosVenta
            // 
            this.dgvProductosVenta.AllowUserToAddRows = false;
            this.dgvProductosVenta.AllowUserToDeleteRows = false;
            this.dgvProductosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.Subtotal});
            this.dgvProductosVenta.Location = new System.Drawing.Point(99, 201);
            this.dgvProductosVenta.Name = "dgvProductosVenta";
            this.dgvProductosVenta.ReadOnly = true;
            this.dgvProductosVenta.RowHeadersVisible = false;
            this.dgvProductosVenta.Size = new System.Drawing.Size(532, 150);
            this.dgvProductosVenta.TabIndex = 34;
            // 
            // Nombre
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nombre.HeaderText = "     Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio.HeaderText = "     Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cantidad.HeaderText = "     Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.Subtotal.HeaderText = "     Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // FormGenerarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 499);
            this.Controls.Add(this.dgvProductosVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.checkBoxNO);
            this.Controls.Add(this.checkBoxSI);
            this.Controls.Add(this.lblEnvioDomicilio);
            this.Controls.Add(this.btnGuardarVenta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGenerarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGenerarVenta";
            this.Load += new System.EventHandler(this.FormGenerarVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarVenta;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cbxProductos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox tbxCantidadProducto;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.Label lblEnvioDomicilio;
        private System.Windows.Forms.CheckBox checkBoxSI;
        private System.Windows.Forms.CheckBox checkBoxNO;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarProductoVenta;
        private System.Windows.Forms.DataGridView dgvProductosVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}