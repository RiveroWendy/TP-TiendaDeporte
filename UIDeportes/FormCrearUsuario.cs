using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UIDeportes
{
    public partial class FormCrearUsuario : Form
    {
        private UsuarioBLL usuarioBLL;
        private EmpleadoBE empleado;

        public FormCrearUsuario()
        {
            InitializeComponent();
            usuarioBLL = new UsuarioBLL();
            empleado = new EmpleadoBE();

            // Vincular el evento SelectedIndexChanged
            cboxCargos.SelectedIndexChanged += cboxCargos_SelectedIndexChanged;

            // Cargar los cargos en el ComboBox
            CargarCargos();
        }
        private void CargarCargos()
        {
            try
            {
                List<Cargo> cargos = usuarioBLL.ObtenerCargos();
                cboxCargos.DataSource = cargos;
                cboxCargos.DisplayMember = "Nombre";
                cboxCargos.ValueMember = "IdCargo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los cargos: " + ex.Message);
            }
        }
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            // Capturar los valores de los TextBoxes
            int dni = int.Parse(tboxDNI.Text);
            string nombre = tboxNombre.Text;
            string apellido = tboxApellido.Text;
            string correo = tboxEmail.Text;
            string nombreCalle = tboxNombreCalle.Text;
            int numeroCalle = int.Parse(tboxAlturaCalle.Text);
            string nombreLocalidad = tboxLocalidad.Text;
            string codigoPostal = tboxCP.Text;
            string nombreUsuario = tboxNombreUsuario.Text;
            string clave = tboxClave.Text;

            
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            // Crear instancias de las clases BE
            LocalidadBE localidad = new LocalidadBE
            {
                NombreLocalidad = nombreLocalidad,
                CodigoPostal = codigoPostal
            };

            DireccionBE direccion = new DireccionBE
            {
                NombreCalle = nombreCalle,
                NumeroCalle = numeroCalle,
                Localidad = localidad
            };

            empleado.Nombre = nombre;
            empleado.Apellido = apellido;
            empleado.Correo = correo;
            empleado.Dni = dni;
            empleado.Direccion = direccion;
          
            UsuarioBE usuario = new UsuarioBE
            {
                Empleado = empleado,
                NombreUsuario = nombreUsuario,
                Clave = clave
            };

            try
            {
                usuarioBLL.CrearUsuario(usuario);
                // Notificar al usuario y cerrar el formulario
                MessageBox.Show("Usuario creado exitosamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message);
            }
        }

        private void cboxCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargo cargoSeleccionado = cboxCargos.SelectedItem as Cargo;
            if (cargoSeleccionado != null)
            {
                empleado.Cargo = cargoSeleccionado;
            }
            else
            {
                MessageBox.Show("Error: no se pudo obtener el cargo seleccionado del ComboBox");
            }         
        }

        private void FormCrearUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


       
    }
}
