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
    public partial class FormEliminarProducto : Form
    {
        private ProductoBLL _productoBLL;
        public FormEliminarProducto()
        {
            InitializeComponent();
            _productoBLL = new ProductoBLL();
        }

        private void FormEliminarProducto_Load(object sender, EventArgs e)
        {
            List<ProductoBE> productos = _productoBLL.TraerProductos();


            if (productos.Count > 0)
            {

                dgvEliminarProductos.Columns.Add("IdProducto", "ID Producto");
                dgvEliminarProductos.Columns.Add("Nombre", "Nombre");
                dgvEliminarProductos.Columns.Add("Precio", "Precio");

                dgvEliminarProductos.Rows.Clear();

                foreach (ProductoBE producto in productos)
                {
                    dgvEliminarProductos.Rows.Add(producto.IdProducto, producto.Nombre, producto.Precio);
                }
            }
            else
            {
                MessageBox.Show("No se encontró ningún registro de productos.", "No existen productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvEliminarProductos.SelectedRows.Count > 0)
            {

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dgvEliminarProductos.SelectedRows[0];

                    if (selectedRow.Cells["IdProducto"].Value == null || selectedRow.Cells["IdProducto"].Value == DBNull.Value)
                    {
                        dgvEliminarProductos.ClearSelection();
                    }
                    else
                    {
                        int idProducto = Convert.ToInt32(selectedRow.Cells["IdProducto"].Value.ToString());

                        _productoBLL.EliminarProducto(idProducto);


                        //Listamos los nuevos registros una vez que ya actualizamos
                        List<ProductoBE> productos = _productoBLL.TraerProductos();
                        dgvEliminarProductos.Rows.Clear();

                        foreach (ProductoBE producto in productos)
                        {
                            dgvEliminarProductos.Rows.Add(producto.IdProducto, producto.Nombre, producto.Precio, producto.Cantidad.Cantidad);
                        }

                    }

                    MessageBox.Show("Registro eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
        }
    }
}
