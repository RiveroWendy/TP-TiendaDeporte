using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;


namespace UIDeportes
{
     public partial class FormEditarUsuario : Form
    {
        private EmpleadoBE _empleado;
        private UsuarioBLL _usuarioBLL;
        private UsuarioBE usuario;

        public FormEditarUsuario(EmpleadoBE empleado)
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();
            _empleado = empleado;
            CargarDatosUsuario();
        }
        public FormEditarUsuario(UsuarioBE usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            // Asignar los valores del usuario a los campos de entrada correspondientes
            tboxNombre.Text = usuario.Empleado.Nombre;
            tboxApellido.Text = usuario.Empleado.Apellido;
            tboxCorreo.Text = usuario.Empleado.Correo;
            tboxCalle.Text = usuario.Empleado.Direccion.NombreCalle;
            tboxNumeroCalle.Text = usuario.Empleado.Direccion.NumeroCalle.ToString();
            tboxLocalidad.Text = usuario.Empleado.Direccion.Localidad.NombreLocalidad;
            tboxCodigoPostal.Text = usuario.Empleado.Direccion.Localidad.CodigoPostal;
            cboxCargo.SelectedItem = usuario.Empleado.Cargo.Nombre;
        }

        /*private void CargarDatosUsuario()
        {
            // Asignar los valores del usuario a los campos de entrada correspondientes
            tboxNombre.Text = _empleado.Nombre;
            tboxApellido.Text = _empleado.Apellido;
            tboxCorreo.Text = _empleado.Correo;
            tboxCalle.Text = _empleado.Direccion.NombreCalle;
            tboxNumeroCalle.Text = _empleado.Direccion.NumeroCalle.ToString();
            tboxLocalidad.Text = _empleado.Direccion.Localidad.NombreLocalidad;
            tboxCodigoPostal.Text = _empleado.Direccion.Localidad.CodigoPostal;
            cboxCargo.SelectedItem = _empleado.Cargo.Nombre;
        }*/

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Actualizar los valores del usuario con los nuevos valores de los campos de entrada
            _empleado.Nombre = tboxNombre.Text;
            _empleado.Apellido = tboxApellido.Text;
            _empleado.Correo = tboxCorreo.Text;
            _empleado.Direccion.NombreCalle = tboxCalle.Text;
            _empleado.Direccion.NumeroCalle = int.Parse(tboxNumeroCalle.Text);
            _empleado.Direccion.Localidad.NombreLocalidad = tboxLocalidad.Text;
            _empleado.Direccion.Localidad.CodigoPostal = tboxCodigoPostal.Text;
            _empleado.Cargo.Nombre = cboxCargo.SelectedItem.ToString();

            // Guardar los cambios a través de la capa BLL
            _usuarioBLL.EditarUsuario(_empleado);
            MessageBox.Show("Usuario actualizado con éxito.");
            this.Close();
        }
    }
}
    

