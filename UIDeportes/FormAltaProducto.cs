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
        private ProductoBE producto;

        public FormAltaProducto()
        {
            producto = new ProductoBE();
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
                var productoBLL = new ProductoBLL();
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
                var productoBLL = new ProductoBLL();
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
            // Valores de los Textbox
            string nombre = tboxNombreProducto.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            if (!long.TryParse(textBoxPrecio.Text, out long precio))
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

            var proveedorSeleccionado = comboBoxProveedor.SelectedItem as Proveedor;
            if (proveedorSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un proveedor.");
                return;
            }

            if (!int.TryParse(textBoxCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }

            // Crear el objeto ProductoBE y asignarle los valores
            producto = new ProductoBE
            {
                Nombre = nombre,
                Precio = precio,
                Categoria = categoriaSeleccionada,
                Proveedor = proveedorSeleccionado,
                Cantidad = new Stock { Cantidad = cantidad }
            };

            try
            {
                // Llamar al método para guardar el producto
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
