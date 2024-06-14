namespace UIDeportes
{
    partial class FormBuscarVenta
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
            this.lblIngreseFecha = new System.Windows.Forms.Label();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.tboxBusquedaPorFecha = new System.Windows.Forms.TextBox();
            this.lblBusquedaPorFecha = new System.Windows.Forms.Label();
            this.lblBuscarPorDNI = new System.Windows.Forms.Label();
            this.tboxBuscarPorDNI = new System.Windows.Forms.TextBox();
            this.lblIngreseDNI = new System.Windows.Forms.Label();
            this.lblIDVenta = new System.Windows.Forms.Label();
            this.tboxBuscarPorID = new System.Windows.Forms.TextBox();
            this.lblIngreseNumeroDeVenta = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngreseFecha
            // 
            this.lblIngreseFecha.AutoSize = true;
            this.lblIngreseFecha.Location = new System.Drawing.Point(391, 64);
            this.lblIngreseFecha.Name = "lblIngreseFecha";
            this.lblIngreseFecha.Size = new System.Drawing.Size(112, 20);
            this.lblIngreseFecha.TabIndex = 0;
            this.lblIngreseFecha.Text = "Ingrese Fecha";
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Location = new System.Drawing.Point(488, 313);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(138, 50);
            this.btnBuscarVenta.TabIndex = 1;
            this.btnBuscarVenta.Text = "Buscar Venta";
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            // 
            // tboxBusquedaPorFecha
            // 
            this.tboxBusquedaPorFecha.Location = new System.Drawing.Point(395, 90);
            this.tboxBusquedaPorFecha.Name = "tboxBusquedaPorFecha";
            this.tboxBusquedaPorFecha.Size = new System.Drawing.Size(231, 26);
            this.tboxBusquedaPorFecha.TabIndex = 2;
            // 
            // lblBusquedaPorFecha
            // 
            this.lblBusquedaPorFecha.AutoSize = true;
            this.lblBusquedaPorFecha.Location = new System.Drawing.Point(115, 90);
            this.lblBusquedaPorFecha.Name = "lblBusquedaPorFecha";
            this.lblBusquedaPorFecha.Size = new System.Drawing.Size(136, 20);
            this.lblBusquedaPorFecha.TabIndex = 3;
            this.lblBusquedaPorFecha.Text = "Buscar Por Fecha";
            // 
            // lblBuscarPorDNI
            // 
            this.lblBuscarPorDNI.AutoSize = true;
            this.lblBuscarPorDNI.Location = new System.Drawing.Point(115, 168);
            this.lblBuscarPorDNI.Name = "lblBuscarPorDNI";
            this.lblBuscarPorDNI.Size = new System.Drawing.Size(119, 20);
            this.lblBuscarPorDNI.TabIndex = 6;
            this.lblBuscarPorDNI.Text = "Buscar Por DNI";
            // 
            // tboxBuscarPorDNI
            // 
            this.tboxBuscarPorDNI.Location = new System.Drawing.Point(395, 165);
            this.tboxBuscarPorDNI.Name = "tboxBuscarPorDNI";
            this.tboxBuscarPorDNI.Size = new System.Drawing.Size(231, 26);
            this.tboxBuscarPorDNI.TabIndex = 5;
            // 
            // lblIngreseDNI
            // 
            this.lblIngreseDNI.AutoSize = true;
            this.lblIngreseDNI.Location = new System.Drawing.Point(391, 142);
            this.lblIngreseDNI.Name = "lblIngreseDNI";
            this.lblIngreseDNI.Size = new System.Drawing.Size(173, 20);
            this.lblIngreseDNI.TabIndex = 4;
            this.lblIngreseDNI.Text = "Ingrese DNI del Cliente";
            // 
            // lblIDVenta
            // 
            this.lblIDVenta.AutoSize = true;
            this.lblIDVenta.Location = new System.Drawing.Point(115, 249);
            this.lblIDVenta.Name = "lblIDVenta";
            this.lblIDVenta.Size = new System.Drawing.Size(188, 20);
            this.lblIDVenta.TabIndex = 9;
            this.lblIDVenta.Text = "Buscar Numero de Venta";
            // 
            // tboxBuscarPorID
            // 
            this.tboxBuscarPorID.Location = new System.Drawing.Point(395, 246);
            this.tboxBuscarPorID.Name = "tboxBuscarPorID";
            this.tboxBuscarPorID.Size = new System.Drawing.Size(231, 26);
            this.tboxBuscarPorID.TabIndex = 8;
            // 
            // lblIngreseNumeroDeVenta
            // 
            this.lblIngreseNumeroDeVenta.AutoSize = true;
            this.lblIngreseNumeroDeVenta.Location = new System.Drawing.Point(391, 223);
            this.lblIngreseNumeroDeVenta.Name = "lblIngreseNumeroDeVenta";
            this.lblIngreseNumeroDeVenta.Size = new System.Drawing.Size(192, 20);
            this.lblIngreseNumeroDeVenta.TabIndex = 7;
            this.lblIngreseNumeroDeVenta.Text = "Ingrese Numero de Venta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(488, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 50);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormBuscarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblIDVenta);
            this.Controls.Add(this.tboxBuscarPorID);
            this.Controls.Add(this.lblIngreseNumeroDeVenta);
            this.Controls.Add(this.lblBuscarPorDNI);
            this.Controls.Add(this.tboxBuscarPorDNI);
            this.Controls.Add(this.lblIngreseDNI);
            this.Controls.Add(this.lblBusquedaPorFecha);
            this.Controls.Add(this.tboxBusquedaPorFecha);
            this.Controls.Add(this.btnBuscarVenta);
            this.Controls.Add(this.lblIngreseFecha);
            this.Name = "FormBuscarVenta";
            this.Text = "FormBuscarVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseFecha;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.TextBox tboxBusquedaPorFecha;
        private System.Windows.Forms.Label lblBusquedaPorFecha;
        private System.Windows.Forms.Label lblBuscarPorDNI;
        private System.Windows.Forms.TextBox tboxBuscarPorDNI;
        private System.Windows.Forms.Label lblIngreseDNI;
        private System.Windows.Forms.Label lblIDVenta;
        private System.Windows.Forms.TextBox tboxBuscarPorID;
        private System.Windows.Forms.Label lblIngreseNumeroDeVenta;
        private System.Windows.Forms.Button btnCancelar;
    }
}