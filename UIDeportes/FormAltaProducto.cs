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
    public partial class FormAltaProducto : Form
    {
        private BE.ProductoBE producto;

        public FormAltaProducto()
        {
            producto = new BE.ProductoBE();
            InitializeComponent();
            CargarCategorias();
            CargarProveedores();
            comboBoxProveedor.SelectedIndexChanged += comboBoxProveedor_SelectedIndexChanged;
            comboBoxCategoria.SelectedIndexChanged += comboBoxCategoria_SelectedIndexChanged;
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarCategorias()
        {
            try
            {
                var productoBLL = new BLL.ProductoBLL();
                List<CategoriaProducto> categorias = productoBLL.ObtenerCategoria();

                comboBoxCategoria.DisplayMember = "Nombre";
                comboBoxCategoria.ValueMember = "IdCategoria";
                comboBoxCategoria.DataSource = categorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message);
            }
        }

        private void CargarProveedores()
        {
            try
            {
                var productoBLL = new BLL.ProductoBLL();
                List<Proveedor> proveedores = productoBLL.ObtenerProveedor();

                comboBoxProveedor.DisplayMember = "NombreEmpresa";
                comboBoxProveedor.ValueMember = "IdProveedor";
                comboBoxProveedor.DataSource = proveedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            string nombre = tboxNombreProducto.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            if (long.TryParse(textBoxPrecio.Text, out long precio) == false)
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return;
            }

            var categoriaSeleccionada = comboBoxCategoria.SelectedItem as CategoriaProducto;
            if (categoriaSeleccionada == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría.");
                return;
            }
            if (int.TryParse(textBoxCantidad.Text, out int cantidad) == false)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }
            producto.Nombre = nombre;
            producto.Precio = precio;

            producto.Cantidad = new Stock()
            {
                CantidadStock = cantidad,
            };

            producto.Proveedor = new Proveedor()
            {
                IdProveedor = Convert.ToInt32(comboBoxProveedor.SelectedValue),
            };

            producto.Categoria = new CategoriaProducto()
            {
                IdCategoria = Convert.ToInt32(comboBoxCategoria.SelectedValue),
            };


            try
            {

                var productoBLL = new ProductoBLL();
                productoBLL.CrearProducto(producto);

                MessageBox.Show("Producto guardado exitosamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message);
            }
        }



        private void FormAltaProducto_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoriaProducto categoriaSeleccionado = comboBoxCategoria.SelectedItem as CategoriaProducto;
            if (categoriaSeleccionado != null)
            {
                producto.Categoria = categoriaSeleccionado;
            }
            else
            {
                MessageBox.Show("Error: no se pudo obtener el cargo seleccionado del ComboBox");
            }
        }

        private void comboBoxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proveedor proveedorSeleccionado = comboBoxProveedor.SelectedItem as Proveedor;
            if (proveedorSeleccionado != null)
            {
                producto.Proveedor = proveedorSeleccionado;
            }
            else
            {
                MessageBox.Show("Error: no se pudo obtener el cargo seleccionado del ComboBox");
            }
        }
    }
}
