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
        // Declaramos una instancia de LoginBLL para manejar la lógica de negocio relacionada con el login.
        private LoginBLL _loginBLL;

        // Declaramos instancias de los diferentes formularios que utilizaremos.
        FormGerente formularioGerente;
        FormEncargadoDeposito formularioEncargadoDeposito;
        FormCajero formularioCajero;
        FormVendedor formularioVendedor;
        FormAdministrador formularioAdministrativo;
        FormEditarProducto formularioEditarProducto;
        public Form1()
        {
            InitializeComponent();
            // Inicializamos las instancias de los diferentes formularios.
            formularioEditarProducto = new FormEditarProducto();
            _loginBLL = new LoginBLL();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Obtenemos el nombre de usuario y la clave de los campos de texto.
            string nombreUsuario = tboxNombreUsuario.Text;
            string clave = tboxClave.Text;

            // Verificamos si el inicio de sesión es exitoso llamando al método Login de loginBLL.
            try
            {
                _loginBLL.Login(nombreUsuario, clave);
                ValidarSesion();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarSesion()
        {
            if (ManejadorDeSesion.Instancia.IsLogged())
            {
                //string nombre = ManejadorDeSesion.Instancia.Sesion.NombreUsuario;
                string perfil = ManejadorDeSesion.Instancia.Sesion.Empleado.CargoEmpleado.Nombre;

                InicializarFormulariosDeUsuario(perfil);
                tboxNombreUsuario.Text = String.Empty;
                tboxClave.Text = String.Empty;
                tboxNombreUsuario.Focus();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o clave incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioEditarProducto.Show();
        }

        private void InicializarFormulariosDeUsuario(string cargo)
        {
            // Dependiendo del cargo, mostramos el formulario correspondiente.
            switch (cargo)
            {
                case "Gerente":
                    formularioGerente = new FormGerente();
                    formularioGerente.Show();
                    break;
                case "Encargado de Depósito":
                    formularioEncargadoDeposito = new FormEncargadoDeposito();
                    formularioEncargadoDeposito.Show();
                    break;
                case "Cajero":
                    formularioCajero = new FormCajero();
                    formularioCajero.Show();
                    break;
                case "Vendedor":
                    formularioVendedor = new FormVendedor();
                    formularioVendedor.Show();
                    break;
                case "Administrador":
                    formularioAdministrativo = new FormAdministrador();
                    formularioAdministrativo.Show();
                    break;
                default:
                    MessageBox.Show("Cargo no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

    }
}