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
    public partial class FormBuscarUsuario : Form
    {
        private UsuarioBLL _usuarioBLL;
        public FormBuscarUsuario()
        {
            // Inicializamos los componentes del formulario
            InitializeComponent();

            // Creamos una instancia de UsuarioBLL
            _usuarioBLL = new UsuarioBLL();

            // Creamos una columna de botones para editar
            DataGridViewButtonColumn editarColumna = new DataGridViewButtonColumn();
            editarColumna.Name = "Editar";
            editarColumna.Text = "Editar";
            editarColumna.UseColumnTextForButtonValue = true;

            // Creamos una columna de botones para eliminar
            DataGridViewButtonColumn eliminarColumna = new DataGridViewButtonColumn();
            eliminarColumna.Name = "Eliminar";
            eliminarColumna.Text = "Eliminar";
            eliminarColumna.UseColumnTextForButtonValue = true;

            // Agregar las columnas al DataGridView
            dataGridView1.Columns.Add(editarColumna);
            dataGridView1.Columns.Add(eliminarColumna);

            dataGridView1.CellContentClick -= dataGridView1_CellContentClick; // Eliminamos el manejador existente, si es necesario
            dataGridView1.CellContentClick += dataGridView1_CellContentClick; // Luego, subscribimos el evento

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            int dni;

            // Intentamos convertir el texto del TextBox a un número entero
            if (int.TryParse(tboxDNI.Text, out  dni))
            {
                // Buscamos el usuario por DNI utilizando la capa de lógica de negocio (BLL)
                UsuarioBE usuario = _usuarioBLL.BuscarUsuarioPorDni(dni);

                // Si encontramos un usuario con el DNI proporcionado
                if (usuario != null)
                {
                    // Limpiamos las filas del DataGridView
                    dataGridView1.Rows.Clear();
                    // Añadimos una nueva fila al DataGridView con la información del usuario
                    dataGridView1.Rows.Add(usuario.IdUsuario, usuario.Empleado.Nombre, usuario.Empleado.Apellido, usuario.Empleado.Correo, usuario.Empleado.Cargo.Nombre, usuario.Empleado.Dni, usuario.Empleado.Cargo.IdCargo, usuario.Empleado.Direccion.IdDireccion, usuario.Empleado.Direccion.Localidad.IdLocalidad);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún usuario con ese DNI.", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           else
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "DNI inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    int dni = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["DNI"].Value);

                    UsuarioBE usuario = _usuarioBLL.BuscarUsuarioPorDni(dni);

                    if (usuario != null)
                    {
                        FormEditarUsuario formEditarUsuario = new FormEditarUsuario(usuario);
                        formEditarUsuario.ShowDialog();
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    // Obtener el DNI del usuario a eliminar
                    int dni = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["DNI"].Value);

                    // Obtener el valor de la celda Cargo antes de realizar cualquier operación
                    object cargoValue = dataGridView1.Rows[e.RowIndex].Cells["Cargo"].Value;
                    if (cargoValue == null)
                    {
                        MessageBox.Show("El cargo del usuario no está especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string cargo = cargoValue.ToString();

                    if (cargo == "Administrador")
                    {
                        MessageBox.Show("No se puede eliminar al usuario del tipo Administrador.", "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult resultado = MessageBox.Show($"¿Está seguro que desea eliminar al usuario con DNI: {dni}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Llamar al método de la capa BLL para eliminar el usuario
                        _usuarioBLL.EliminarUsuario(dni);
                        MessageBox.Show("El usuario ha sido eliminado con exito!");

                        // Eliminar la fila del DataGridView solo si la eliminación fue exitosa
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }


            }
        }   
    }
}
    
