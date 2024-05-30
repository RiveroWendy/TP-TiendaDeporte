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
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    // Código para editar el usuario
                    int usuarioId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdUsuario"].Value);
                    UsuarioBE usuario = _usuarioBLL.BuscarUsuario(usuarioId); ;
                    if (usuario != null)
                    {
                        // Abrir un nuevo formulario para editar el usuario

                        FormEditarUsuario formEditarUsuario = new FormEditarUsuario(usuario);
                        formEditarUsuario.ShowDialog();
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    // Código para eliminar el usuario
                    int usuarioId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdUsuario"].Value);
                    _usuarioBLL.EliminarUsuario(usuarioId);

                    //EliminarUsuario(usuarioId);
                }
            }
        }

    
    }
}
    
