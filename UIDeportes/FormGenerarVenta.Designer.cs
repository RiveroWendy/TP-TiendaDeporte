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
            this.btnGuardarVenta = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblProducto = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tboxCantidad = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.lblEnvioDomicilio = new System.Windows.Forms.Label();
            this.checkBoxSI = new System.Windows.Forms.CheckBox();
            this.checkBoxNO = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.Location = new System.Drawing.Point(657, 568);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(168, 61);
            this.btnGuardarVenta.TabIndex = 0;
            this.btnGuardarVenta.Text = "Guardar Venta";
            this.btnGuardarVenta.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 768);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(175, 214);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(210, 20);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Eliga un Producto de la Lista";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pantalon",
            "Remera",
            "Buzo",
            "Zapatiila",
            "Short",
            "Campera"});
            this.comboBox1.Location = new System.Drawing.Point(413, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(602, 214);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // tboxCantidad
            // 
            this.tboxCantidad.Location = new System.Drawing.Point(725, 208);
            this.tboxCantidad.Name = "tboxCantidad";
            this.tboxCantidad.Size = new System.Drawing.Size(100, 26);
            this.tboxCantidad.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(725, 259);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Pantalon",
            "Remera",
            "Buzo",
            "Zapatiila",
            "Short",
            "Campera"});
            this.comboBox2.Location = new System.Drawing.Point(413, 257);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Eliga un Producto de la Lista";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(725, 308);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantidad";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Pantalon",
            "Remera",
            "Buzo",
            "Zapatiila",
            "Short",
            "Campera"});
            this.comboBox3.Location = new System.Drawing.Point(413, 306);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 28);
            this.comboBox3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Eliga un Producto de la Lista";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(725, 359);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cantidad";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Pantalon",
            "Remera",
            "Buzo",
            "Zapatiila",
            "Short",
            "Campera"});
            this.comboBox4.Location = new System.Drawing.Point(413, 357);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 28);
            this.comboBox4.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Eliga un Producto de la Lista";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(725, 416);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cantidad";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Pantalon",
            "Remera",
            "Buzo",
            "Zapatiila",
            "Short",
            "Campera"});
            this.comboBox5.Location = new System.Drawing.Point(413, 414);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 28);
            this.comboBox5.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Eliga un Producto de la Lista";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(725, 471);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(602, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Cantidad";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Pantalon",
            "Remera",
            "Buzo",
            "Zapatiila",
            "Short",
            "Campera"});
            this.comboBox6.Location = new System.Drawing.Point(413, 469);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 28);
            this.comboBox6.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Eliga un Producto de la Lista";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(413, 58);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(262, 26);
            this.textBox6.TabIndex = 27;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Location = new System.Drawing.Point(174, 64);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(173, 20);
            this.lblDNICliente.TabIndex = 26;
            this.lblDNICliente.Text = "Ingrese DNI del Cliente";
            // 
            // lblEnvioDomicilio
            // 
            this.lblEnvioDomicilio.AutoSize = true;
            this.lblEnvioDomicilio.Location = new System.Drawing.Point(175, 114);
            this.lblEnvioDomicilio.Name = "lblEnvioDomicilio";
            this.lblEnvioDomicilio.Size = new System.Drawing.Size(128, 20);
            this.lblEnvioDomicilio.TabIndex = 28;
            this.lblEnvioDomicilio.Text = "Envío a Domicilio";
            // 
            // checkBoxSI
            // 
            this.checkBoxSI.AutoSize = true;
            this.checkBoxSI.Location = new System.Drawing.Point(413, 110);
            this.checkBoxSI.Name = "checkBoxSI";
            this.checkBoxSI.Size = new System.Drawing.Size(49, 24);
            this.checkBoxSI.TabIndex = 29;
            this.checkBoxSI.Text = "Si";
            this.checkBoxSI.UseVisualStyleBackColor = true;
            // 
            // checkBoxNO
            // 
            this.checkBoxNO.AutoSize = true;
            this.checkBoxNO.Location = new System.Drawing.Point(562, 110);
            this.checkBoxNO.Name = "checkBoxNO";
            this.checkBoxNO.Size = new System.Drawing.Size(55, 24);
            this.checkBoxNO.TabIndex = 30;
            this.checkBoxNO.Text = "No";
            this.checkBoxNO.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(657, 666);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 61);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormGenerarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 768);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.checkBoxNO);
            this.Controls.Add(this.checkBoxSI);
            this.Controls.Add(this.lblEnvioDomicilio);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lblDNICliente);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnGuardarVenta);
            this.Name = "FormGenerarVenta";
            this.Text = "FormGenerarVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarVenta;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox tboxCantidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.Label lblEnvioDomicilio;
        private System.Windows.Forms.CheckBox checkBoxSI;
        private System.Windows.Forms.CheckBox checkBoxNO;
        private System.Windows.Forms.Button btnCancelar;
    }
}