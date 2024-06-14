namespace UIDeportes
{
    partial class FormEditarProducto
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvEditarProductos = new System.Windows.Forms.DataGridView();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.lblStockProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(348, 250);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 28);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(480, 250);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvEditarProductos
            // 
            this.dgvEditarProductos.AllowDrop = true;
            this.dgvEditarProductos.AllowUserToAddRows = false;
            this.dgvEditarProductos.AllowUserToDeleteRows = false;
            this.dgvEditarProductos.AllowUserToOrderColumns = true;
            this.dgvEditarProductos.AllowUserToResizeColumns = false;
            this.dgvEditarProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEditarProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEditarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditarProductos.Location = new System.Drawing.Point(184, 303);
            this.dgvEditarProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEditarProductos.MultiSelect = false;
            this.dgvEditarProductos.Name = "dgvEditarProductos";
            this.dgvEditarProductos.ReadOnly = true;
            this.dgvEditarProductos.RowHeadersWidth = 51;
            this.dgvEditarProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditarProductos.Size = new System.Drawing.Size(599, 345);
            this.dgvEditarProductos.TabIndex = 2;
            this.dgvEditarProductos.SelectionChanged += new System.EventHandler(this.dgvEditarProductos_SelectionChanged);
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Location = new System.Drawing.Point(437, 11);
            this.lblTitleForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(99, 16);
            this.lblTitleForm.TabIndex = 3;
            this.lblTitleForm.Text = "Editar Producto";
            this.lblTitleForm.Click += new System.EventHandler(this.lblTitleForm_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(337, 122);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(113, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre Producto";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(337, 167);
            this.lblPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(103, 16);
            this.lblPrecioProducto.TabIndex = 5;
            this.lblPrecioProducto.Text = "Precio Producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(465, 118);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(132, 22);
            this.txtNombreProducto.TabIndex = 6;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(465, 164);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(132, 22);
            this.txtPrecioProducto.TabIndex = 7;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(465, 74);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(132, 22);
            this.txtIdProducto.TabIndex = 9;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(337, 78);
            this.lblIdProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(113, 16);
            this.lblIdProducto.TabIndex = 8;
            this.lblIdProducto.Text = "Nombre Producto";
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(465, 207);
            this.txtStockProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(132, 22);
            this.txtStockProducto.TabIndex = 11;
            // 
            // lblStockProducto
            // 
            this.lblStockProducto.AutoSize = true;
            this.lblStockProducto.Location = new System.Drawing.Point(337, 210);
            this.lblStockProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockProducto.Name = "lblStockProducto";
            this.lblStockProducto.Size = new System.Drawing.Size(98, 16);
            this.lblStockProducto.TabIndex = 10;
            this.lblStockProducto.Text = "Stock Producto";
            // 
            // FormEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 706);
            this.Controls.Add(this.txtStockProducto);
            this.Controls.Add(this.lblStockProducto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitleForm);
            this.Controls.Add(this.dgvEditarProductos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEditarProducto";
            this.Text = "FormEditarProducto";
            this.Load += new System.EventHandler(this.FormEditarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvEditarProductos;
        private System.Windows.Forms.Label lblTitleForm;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.TextBox txtStockProducto;
        private System.Windows.Forms.Label lblStockProducto;
    }
}