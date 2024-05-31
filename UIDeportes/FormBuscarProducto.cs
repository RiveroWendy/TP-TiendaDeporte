using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDeportes
{
    public partial class FormBuscarProducto : Form
    {
        private ProductoBLL _productoBLL;

        public FormBuscarProducto()
        {
            InitializeComponent();
            _productoBLL = new ProductoBLL(); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {

        }

        private void tboxNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Valor TextBox Nombre
            string input = tboxNombreProducto.Text;
            int idProducto;

            if (int.TryParse(input, out idProducto))
            {
                ProductoBE producto = _productoBLL.BuscarProducto(idProducto);
                if (producto != null)
                {
                    MessageBox.Show("Producto Encontrado Nombre: " + producto.Nombre + "Precio: " +  producto.Precio);

                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un ID de producto válido");
            }

        }
    }
    }


