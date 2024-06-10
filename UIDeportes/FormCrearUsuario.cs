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
                // Obtenemos la lista de cargos desde la capa de lógica de negocio (BLL)
                List<Cargo> cargos = usuarioBLL.ObtenerCargos();

                // Asignamos la lista de cargos como fuente de datos del ComboBox
                cboxCargos.DataSource = cargos;

                // Especificamos las propiedades para mostrar y el valor de los ítems del ComboBox
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
            // Capturamos los valores de los TextBoxes
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

            // Verificamos si hay campos obligatorios vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            // Creamos instancias de las clases BE 
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
                // Llamamos al método para crear el usuario en la capa de lógica de negocio (BLL)
                usuarioBLL.CrearUsuario(usuario);
                // Notificamos al usuario y cerramos el formulario
                MessageBox.Show("Usuario creado exitosamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                // Mostramos un mensaje de error en caso de que ocurra una excepción
                MessageBox.Show("Error al crear el usuario: " + ex.Message);
            }
        }

        private void cboxCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtenemos el cargo seleccionado del ComboBox
            Cargo cargoSeleccionado = cboxCargos.SelectedItem as Cargo;

            // Verificamos si el cargo seleccionado no es nulo
            if (cargoSeleccionado != null)
            {
                // Asignamos el cargo seleccionado al empleado
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

        private void tboxDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
