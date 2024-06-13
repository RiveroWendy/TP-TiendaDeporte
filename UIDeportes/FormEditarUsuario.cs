﻿using System;
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

        private UsuarioBLL _usuarioBLL;
        private UsuarioBE _usuario;

        public FormEditarUsuario(UsuarioBE usuario)
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();
            _usuario = usuario;
            CargarDatosUsuario();
            // Enlazar evento de cambio de selección del ComboBox de Cargo
            cboxCargo.SelectedIndexChanged += cboxCargo_SelectedIndexChanged;

            // Enlazar evento de clic del botón Guardar
            btnGuardar.Click += btnGuardar_Click_1;
        }

        private void CargarDatosUsuario()
        {
            // Cargamos los datos del usuario en los controles del formulario
            tboxNombre.Text = _usuario.Empleado.Nombre;
            tboxApellido.Text = _usuario.Empleado.Apellido;
            tboxCorreo.Text = _usuario.Empleado.Correo;
            tboxDni.Text = _usuario.Empleado.Dni.ToString();
            tboxNombreUsuario.Text = _usuario.NombreUsuario;
            tboxClave.Text = _usuario.Clave;
            tboxCalle.Text = _usuario.Empleado.Direccion.NombreCalle;
            tboxNumeroCalle.Text = _usuario.Empleado.Direccion.NumeroCalle.ToString();
            tboxLocalidad.Text = _usuario.Empleado.Direccion.Localidad.NombreLocalidad;
            tboxCodigoPostal.Text = _usuario.Empleado.Direccion.Localidad.CodigoPostal;

            // Cargar cargo en el comboBox
            cboxCargo.Items.Clear();
            cboxCargo.Items.Add("Administrador");
            cboxCargo.Items.Add("Cajero");
            cboxCargo.Items.Add("Encargado de Depósito");
            cboxCargo.Items.Add("Gerente");
            cboxCargo.Items.Add("Vendedor");

            // Seleccionamos el cargo actual del usuario
            cboxCargo.SelectedItem = _usuario.Empleado.CargoEmpleado.Nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Actualizar¿mos los datos del usuario con los valores de los controles del formulario
            _usuario.Empleado.Nombre = tboxNombre.Text;
            _usuario.Empleado.Apellido = tboxApellido.Text;
            _usuario.Empleado.Correo = tboxCorreo.Text;
            _usuario.Empleado.Dni = int.Parse(tboxDni.Text);
            _usuario.NombreUsuario = tboxNombreUsuario.Text;
            _usuario.Clave = tboxClave.Text;
            _usuario.Empleado.Direccion.NombreCalle = tboxCalle.Text;
            _usuario.Empleado.Direccion.NumeroCalle = int.Parse(tboxNumeroCalle.Text);
            _usuario.Empleado.Direccion.Localidad.NombreLocalidad = tboxLocalidad.Text;
            _usuario.Empleado.Direccion.Localidad.CodigoPostal = tboxCodigoPostal.Text;
            _usuario.Empleado.CargoEmpleado.Nombre = cboxCargo.SelectedItem.ToString();


            // Obtenemos el nombre del cargo seleccionado del ComboBox
            if (cboxCargo.SelectedItem is string selectedCargo)
            {
                // Buscamos el objeto Cargo correspondiente en la lista de cargos
                Cargo cargoSeleccionado = ObtenerCargoPorNombre(selectedCargo);

                if (cargoSeleccionado != null)
                {
                    // Asignamos el objeto Cargo al usuario
                    _usuario.Empleado.CargoEmpleado = cargoSeleccionado;
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el cargo seleccionado.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un cargo.");
                return;
            }
            // Llamamos al método de la capa BLL para actualizar el usuario
            _usuarioBLL.ActualizarUsuario(_usuario);

            MessageBox.Show("¡Usuario editado con éxito!");

            this.Close();

        }

        private void cboxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos si el ítem seleccionado es de tipo Cargo
            if (cboxCargo.SelectedItem is Cargo selectedCargo)
            {
                // Actualizamos el nombre y el Id del cargo del empleado en el objeto _usuario
                _usuario.Empleado.CargoEmpleado.Nombre = selectedCargo.Nombre;
                _usuario.Empleado.CargoEmpleado.IdCargo = selectedCargo.IdCargo;
            }
        }
        private Cargo ObtenerCargoPorNombre(string nombreCargo)
        {
            // Iterar sobre la lista de cargos y encontrar el objeto Cargo con el nombre especificado
            foreach (Cargo cargo in _usuarioBLL.ObtenerCargos())
            {
                if (cargo.Nombre.Equals(nombreCargo))
                {
                    return cargo;
                }
            }

            return null; // Si no se encuentra el cargo, devolver null
        }
    }
}
    

