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
        private BLL.ProductoBLL _productoBLL;

        public FormBuscarProducto()
        {
            InitializeComponent();
            _productoBLL = new BLL.ProductoBLL();
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
            // Valor TextBox Nombre
            dgvBuscarProducto.DataSource = null;
            dgvBuscarProducto.Columns.Clear();
            dgvBuscarProducto.Rows.Clear();
            string nombreProducto = tboxNombreProducto.Text;

            List<ProductoBE> productos = _productoBLL.BuscarProducto(nombreProducto);

            if (productos.Count > 0)
            {
                dgvBuscarProducto.Columns.Add("IdProducto", "ID Producto");
                dgvBuscarProducto.Columns.Add("Nombre", "Nombre");
                dgvBuscarProducto.Columns.Add("Precio", "Precio");

                dgvBuscarProducto.Rows.Clear();

                foreach (BE.ProductoBE producto in productos)
                {
                    dgvBuscarProducto.Rows.Add(producto.IdProducto, producto.Nombre, producto.Precio, producto.Cantidad.CantidadStock);
                }
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
                dgvBuscarProducto.DataSource = null;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

