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
    public partial class FormDatosCliente : Form
    {
        private ClienteBLL clienteBLL;
        private ClienteBE clienteExistente; // Variable para almacenar el cliente existente a modificar

        public FormDatosCliente()
        {
            InitializeComponent();
            clienteBLL = new ClienteBLL();
           // clienteExistente = cliente; 
            // Verificar si se pasó un cliente existente
            if (clienteExistente != null)
            {
                // Rellenar los controles del formulario con los datos del cliente existente
                RellenarDatosClienteExistente(clienteExistente);
            }
        }
        public void EstablecerClienteExistente(ClienteBE cliente)
        {
            clienteExistente = cliente;
            if (clienteExistente != null)
            {
                // Rellenar los controles del formulario con los datos del cliente existente
                RellenarDatosClienteExistente(clienteExistente);
            }
        }

        private void RellenarDatosClienteExistente(ClienteBE cliente)
        {
            // Rellenar los controles del formulario con los datos del cliente existente
            tboxDNI.Text = cliente.Dni.ToString();
            tboxNombre.Text = cliente.Nombre;
            tboxApellido.Text = cliente.Apellido;
            tboxCorreo.Text = cliente.Correo;
            tboxNombreCalle.Text = cliente.Direccion.NombreCalle;
            tboxNumeroCalle.Text = cliente.Direccion.NumeroCalle.ToString();
            tboxCodigoPostal.Text = cliente.Direccion.Localidad.CodigoPostal;
            tboxLocalidad.Text = cliente.Direccion.Localidad.NombreLocalidad;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormVendedor frm = Application.OpenForms["FormVendedor"] as FormVendedor;
            frm?.Show();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteExistente != null)
                {
                    // Si hay un cliente existente, se está modificando, por lo tanto, actualizarlo
                    ActualizarCliente();
                }
                else
                {
                    // Si no hay un cliente existente, se está creando uno nuevo, por lo tanto, guardarlo
                    CrearNuevoCliente();
                }

                MessageBox.Show("Cliente guardado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message);
            }
        }

        private void CrearNuevoCliente()
        {
            // Obtener los datos del formulario
            int dni = int.Parse(tboxDNI.Text);
            string nombre = tboxNombre.Text;
            string apellido = tboxApellido.Text;
            string correo = tboxCorreo.Text;
            string nombreCalle = tboxNombreCalle.Text;
            int numeroCalle = int.Parse(tboxNumeroCalle.Text);
            string codigoPostal = tboxCodigoPostal.Text;
            string nombreLocalidad = tboxLocalidad.Text;

            // Crear objeto ClienteBE con los datos del formulario
            ClienteBE cliente = new ClienteBE()
            {
                Dni = dni,
                Nombre = nombre,
                Apellido = apellido,
                Correo = correo,
                Direccion = new DireccionBE()
                {
                    NombreCalle = nombreCalle,
                    NumeroCalle = numeroCalle,
                    Localidad = new LocalidadBE()
                    {
                        NombreLocalidad = nombreLocalidad,
                        CodigoPostal = codigoPostal
                    }
                }
            };

            // Llamar al método CrearCliente de ClienteBLL para guardar el cliente
            clienteBLL.CrearCliente(cliente);
        }
        private void ActualizarCliente()
        {
            // Actualizar los datos del cliente existente con los nuevos datos del formulario
            clienteExistente.Dni = int.Parse(tboxDNI.Text);
            clienteExistente.Nombre = tboxNombre.Text;
            clienteExistente.Apellido = tboxApellido.Text;
            clienteExistente.Correo = tboxCorreo.Text;
            clienteExistente.Direccion.NombreCalle = tboxNombreCalle.Text;
            clienteExistente.Direccion.NumeroCalle = int.Parse(tboxNumeroCalle.Text);
            clienteExistente.Direccion.Localidad.CodigoPostal = tboxCodigoPostal.Text;
            clienteExistente.Direccion.Localidad.NombreLocalidad = tboxLocalidad.Text;

            // Llamar al método ActualizarCliente de ClienteBLL para guardar los cambios
            clienteBLL.ActualizarCliente(clienteExistente);
        }

    }
}
