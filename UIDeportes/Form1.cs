using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;




namespace UIDeportes
{
    public partial class Form1 : Form
    {
        LoginBLL loginBLL = new LoginBLL();
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
            string nombreUsuario = tboxNombreUsuario.Text;
            string clave = tboxClave.Text;

            bool loginExitoso = loginBLL.Login(nombreUsuario, clave);

            if (loginExitoso)
            {
                string cargo = loginBLL.ObtenerCargo(nombreUsuario);

                switch (cargo)
                {
                    case "Gerente":
                        formularioGerente.Show();
                        break;
                    case "Encargado de Depósito":
                        formularioEncargadoDeposito.Show();
                        break;
                    case "Cajero":
                        formularioCajero.Show();
                        break;
                    case "Vendedor":
                        formularioVendedor.Show();
                        break;
                    case "Administrador":
                        formularioAdministrativo.Show();
                        break;
                    default:
                        MessageBox.Show("Cargo no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o clave incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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