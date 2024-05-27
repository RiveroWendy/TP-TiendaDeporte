namespace UIDeportes
{
    partial class FormAdministrador
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
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCrearUsuario.Location = new System.Drawing.Point(229, 72);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(300, 99);
            this.btnCrearUsuario.TabIndex = 0;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(229, 242);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(300, 99);
            this.btnBuscarUsuario.TabIndex = 1;
            this.btnBuscarUsuario.Text = "Buscar Usuario";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // FormAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.btnCrearUsuario);
            this.Name = "FormAdministrativo";
            this.Text = "FormAdministrativo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
    }
}