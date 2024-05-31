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
            InitializeComponent();

            _usuarioBLL = new UsuarioBLL();

            // Crear columnas de botones
            DataGridViewButtonColumn editarColumna = new DataGridViewButtonColumn();
            editarColumna.Name = "Editar";
            editarColumna.Text = "Editar";
            editarColumna.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn eliminarColumna = new DataGridViewButtonColumn();
            eliminarColumna.Name = "Eliminar";
            eliminarColumna.Text = "Eliminar";
            eliminarColumna.UseColumnTextForButtonValue = true;

            // Agregar las columnas al DataGridView
            dataGridView1.Columns.Add(editarColumna);
            dataGridView1.Columns.Add(eliminarColumna);

            // Manejar el evento de clic del botón de editar
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            int dni;
            if (int.TryParse(tboxDNI.Text, out  dni))
            {
                UsuarioBE usuario = _usuarioBLL.BuscarUsuarioPorDni(dni);

                if (usuario != null)
                {
                    dataGridView1.Rows.Clear();
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
                    // Código para eliminar el usuario
                }
            }

        }   
    }
}
    
