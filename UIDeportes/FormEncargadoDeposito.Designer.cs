namespace UIDeportes
{
    partial class FormEncargadoDeposito
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
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Location = new System.Drawing.Point(267, 68);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(246, 87);
            this.btnAltaProducto.TabIndex = 0;
            this.btnAltaProducto.Text = "Alta Producto";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(267, 160);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(246, 87);
            this.btnBuscarProducto.TabIndex = 1;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(267, 251);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(246, 87);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Visualizar Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // FormEncargadoDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 454);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnAltaProducto);
            this.Name = "FormEncargadoDeposito";
            this.Text = "FormEncargadoDeposito";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnStock;
    }
}