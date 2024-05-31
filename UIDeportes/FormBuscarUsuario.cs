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

            // Manejamos el evento de clic en el contenido de las celdas del DataGridView
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // Verificamos que la celda seleccionada sea válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificamos si se ha clicado en la columna "Editar"
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    // Obtener el DNI del usuario seleccionado en la fila
                    int dni = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["DNI"].Value);

                    // Buscar el usuario en la base de datos utilizando su DNI
                    UsuarioBE usuario = _usuarioBLL.BuscarUsuarioPorDni(dni);

                    if (usuario != null)
                    {
                        // Abrir el formulario de edición y pasarle el usuario encontrado
                        FormEditarUsuario formEditarUsuario = new FormEditarUsuario(usuario);
                        formEditarUsuario.ShowDialog();
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    // Código para eliminar el usuario, aun resta por hacerlo.
                }
            }

        }   
    }
}
    
