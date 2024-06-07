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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tboxDNICliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            int dni;

            // Intentamos convertir el texto del TextBox a un número entero
            if (int.TryParse(tboxDNICliente.Text, out dni))
            {
                // Buscamos el cliente por DNI utilizando la capa de lógica de negocio (BLL)
                ClienteBLL clienteBLL = new ClienteBLL();
                ClienteBE cliente = clienteBLL.BuscarClientePorDNI(dni);

                // Si encontramos un cliente con el DNI proporcionado
                if (cliente != null)
                {
                    // Limpiamos las filas del DataGridView
                    dataGridView1.Rows.Clear();
                    // Añadimos una nueva fila al DataGridView con la información del cliente
                    dataGridView1.Rows.Add(cliente.IdCliente, cliente.Dni, cliente.Nombre, cliente.Apellido, cliente.Correo, cliente.Direccion.NombreCalle, cliente.Direccion.NumeroCalle, cliente.Direccion.Localidad.CodigoPostal, cliente.Direccion.Localidad.NombreLocalidad);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún cliente con ese DNI.", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "DNI inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente para modificar.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            ClienteBE cliente = new ClienteBE
            {
                IdCliente = Convert.ToInt32(selectedRow.Cells["IdCliente"].Value),
                Dni = Convert.ToInt32(selectedRow.Cells["DNI"].Value),
                Nombre = selectedRow.Cells["Nombre"].Value.ToString(),
                Apellido = selectedRow.Cells["Apellido"].Value.ToString(),
                Correo = selectedRow.Cells["CorreoElectronico"].Value.ToString(),
                Direccion = new DireccionBE
                {
                    NombreCalle = selectedRow.Cells["NombreCalle"].Value.ToString(),
                    NumeroCalle = Convert.ToInt32(selectedRow.Cells["NumeroCalle"].Value),
                    Localidad = new LocalidadBE
                    {
                        NombreLocalidad = selectedRow.Cells["Localidad"].Value.ToString(),
                        CodigoPostal = selectedRow.Cells["CodigoPostal"].Value.ToString(),
                    }
                }
            };

            FormDatosCliente formDatosCliente = new FormDatosCliente();
            formDatosCliente.EstablecerClienteExistente(cliente);
            formDatosCliente.ShowDialog();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
