namespace UIDeportes
{
    partial class FormReporteGeneral
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
            this.btnReporteMensual = new System.Windows.Forms.Button();
            this.btnReporteProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReporteMensual
            // 
            this.btnReporteMensual.Location = new System.Drawing.Point(159, 45);
            this.btnReporteMensual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReporteMensual.Name = "btnReporteMensual";
            this.btnReporteMensual.Size = new System.Drawing.Size(187, 79);
            this.btnReporteMensual.TabIndex = 0;
            this.btnReporteMensual.Text = "Reporte Mensual";
            this.btnReporteMensual.UseVisualStyleBackColor = true;
            this.btnReporteMensual.Click += new System.EventHandler(this.btnReporteMensual_Click);
            // 
            // btnReporteProducto
            // 
            this.btnReporteProducto.Location = new System.Drawing.Point(159, 153);
            this.btnReporteProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReporteProducto.Name = "btnReporteProducto";
            this.btnReporteProducto.Size = new System.Drawing.Size(187, 79);
            this.btnReporteProducto.TabIndex = 1;
            this.btnReporteProducto.Text = "Reporte por Producto";
            this.btnReporteProducto.UseVisualStyleBackColor = true;
            // 
            // FormReporteGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnReporteProducto);
            this.Controls.Add(this.btnReporteMensual);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormReporteGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteGeneral";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporteMensual;
        private System.Windows.Forms.Button btnReporteProducto;
    }
}