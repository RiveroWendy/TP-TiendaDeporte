namespace UIDeportes
{
    partial class FormEliminarProducto
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
            this.dgvEliminarProductos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEliminarProductos
            // 
            this.dgvEliminarProductos.AllowDrop = true;
            this.dgvEliminarProductos.AllowUserToAddRows = false;
            this.dgvEliminarProductos.AllowUserToDeleteRows = false;
            this.dgvEliminarProductos.AllowUserToOrderColumns = true;
            this.dgvEliminarProductos.AllowUserToResizeColumns = false;
            this.dgvEliminarProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEliminarProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEliminarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarProductos.Location = new System.Drawing.Point(181, 78);
            this.dgvEliminarProductos.MultiSelect = false;
            this.dgvEliminarProductos.Name = "dgvEliminarProductos";
            this.dgvEliminarProductos.ReadOnly = true;
            this.dgvEliminarProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEliminarProductos.Size = new System.Drawing.Size(449, 280);
            this.dgvEliminarProductos.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(411, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(312, 376);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 4;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // FormEliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.dgvEliminarProductos);
            this.Name = "FormEliminarProducto";
            this.Text = "FormEliminarProducto";
            this.Load += new System.EventHandler(this.FormEliminarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEliminarProductos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminarProducto;
    }
}