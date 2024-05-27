using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDeportes
{
    public partial class Form1 : Form
    {
        FormGerente formularioGerente;
        FormEncargadoDeposito formularioEncargadoDeposito;
        FormCajero formularioCajero;
        FormVendedor formularioVendedor;
        FormAdministrador formularioAdministrativo;

        public Form1()
        {
            InitializeComponent();
            formularioGerente = new FormGerente();
            formularioEncargadoDeposito = new FormEncargadoDeposito();
            formularioCajero = new FormCajero();
            formularioVendedor = new FormVendedor();   
            formularioAdministrativo = new FormAdministrador();    

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Verifico usuario y contraseña
            string nombreUsuario = tboxNombreUsuario.Text;
            string contraseña = tboxClave.Text;

            if (nombreUsuario == "gerente" && contraseña == "123")
            {
                // Oculto la ventana actual (Form1)
                this.Hide();
                formularioGerente.Show();
            }
            else if (nombreUsuario == "edeposito" && contraseña == "123")
            {
                // Oculto la ventana actual (Form1)
                this.Hide();
                formularioEncargadoDeposito.Show();
            }else if (nombreUsuario == "cajero" && contraseña == "123")
            {
                // Oculto la ventana actual (Form1)
                this.Hide();
                formularioCajero.Show();
            }
            else if (nombreUsuario == "vendedor" && contraseña == "123")
            {
                // Oculto la ventana actual (Form1)
                this.Hide();
                formularioVendedor.Show();
            }
            else if (nombreUsuario == "administrador" && contraseña == "123")
            {
                // Oculto la ventana actual (Form1)
                this.Hide();
                formularioAdministrativo.Show();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.\nPor favor, inténtelo de nuevo.");
            }
        }

        private void tboxNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void tboxClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
