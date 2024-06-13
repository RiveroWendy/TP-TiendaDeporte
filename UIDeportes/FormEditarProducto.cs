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
    public partial class FormEditarProducto : Form
    {
        private BLL.ProductoBLL _productoBLL;
        public FormEditarProducto()
        {
            InitializeComponent();
            _productoBLL = new BLL.ProductoBLL();
            dgvEditarProductos.ClearSelection();

        }

        private void FormEditarProducto_Load(object sender, EventArgs e)
        {
            List<BE.ProductoBE> productos = _productoBLL.TraerProductos();

           
            if (productos.Count > 0)
            {
                dgvEditarProductos.Columns.Add("IdProducto", "ID Producto");
                dgvEditarProductos.Columns.Add("Nombre", "Nombre");
                dgvEditarProductos.Columns.Add("Precio", "Precio");
                dgvEditarProductos.Columns.Add("Cantidad", "Cantidad");

                dgvEditarProductos.Rows.Clear();

                foreach (BE.ProductoBE producto in productos)
                {
                    dgvEditarProductos.Rows.Add(producto.IdProducto, producto.Nombre, producto.Precio, producto.Cantidad.CantidadStock);
                }
            }
            else
            {
                MessageBox.Show("No se encontró ningún usuario con ese DNI.", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvEditarProductos.ClearSelection();

        }

        private void dgvEditarProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEditarProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEditarProductos.SelectedRows[0];

                if (selectedRow.Cells["IdProducto"].Value == null || selectedRow.Cells["IdProducto"].Value == DBNull.Value)
                {
                    dgvEditarProductos.ClearSelection();
                }
                else
                {
                    txtIdProducto.Text = selectedRow.Cells["IdProducto"].Value.ToString();
                    txtNombreProducto.Text = selectedRow.Cells["Nombre"].Value.ToString();
                    txtPrecioProducto.Text = selectedRow.Cells["Precio"].Value.ToString();
                    var stock = _productoBLL.TraerStock(Convert.ToInt32(selectedRow.Cells["IdProducto"].Value.ToString()));
                    txtStockProducto.Text = stock.CantidadStock.ToString();
                }


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEditarProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEditarProductos.SelectedRows[0];

                if (selectedRow.Cells["IdProducto"].Value == null || selectedRow.Cells["IdProducto"].Value == DBNull.Value)
                {
                    dgvEditarProductos.ClearSelection();
                }
                else
                {
                    int idProducto = Convert.ToInt32(selectedRow.Cells["IdProducto"].Value.ToString());
                    string nombreProducto = txtNombreProducto.Text;
                    long precioProducto = Convert.ToInt64(txtPrecioProducto.Text);

                    int cantidad = Convert.ToInt32(txtStockProducto.Text);

                    _productoBLL.EditarProducto(idProducto, nombreProducto, precioProducto);
                    _productoBLL.EditarStockProducto(idProducto, cantidad);

                    //Listamos los nuevos registros una vez que ya actualizamos
                    List<BE.ProductoBE> productos = _productoBLL.TraerProductos();
                    dgvEditarProductos.Rows.Clear();

                    foreach (BE.ProductoBE producto in productos)
                    {
                        dgvEditarProductos.Rows.Add(producto.IdProducto, producto.Nombre, producto.Precio, producto.Cantidad.CantidadStock);
                    }

                }
            }
        }

        private void lblTitleForm_Click(object sender, EventArgs e)
        {

        }
    }
}
