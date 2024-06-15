using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UIDeportes
{
    public partial class FormGenerarVenta : Form
    {
        private ProductoBLL _producto;
        private List<ProductoBE> _productos;
        private VentaBLL _venta;
        private ClienteBLL _cliente;
        private List<DetalleVentaBE> _detalleVenta;
        private UsuarioBLL _usuario;

        public FormGenerarVenta()
        {
            InitializeComponent();
            _producto = new ProductoBLL();
            _venta = new VentaBLL();
            _cliente = new ClienteBLL();
            _detalleVenta = new List<DetalleVentaBE>();
            _usuario = new UsuarioBLL();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormVendedor frm = Application.OpenForms["FormVendedor"] as FormVendedor;
            frm?.Show();
        }

        private void btnAgregarProductoVenta_Click(object sender, EventArgs e)
        {
            if (cbxProductos.Items[0].ToString() == "Nombre del Producto")
            {
                MessageBox.Show("Ingrese el nombre del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mejorar el texto del mensaje.
                return;
            }

            if (!int.TryParse(tbxCantidadProducto.Text.Trim(), out int cantidad))
            {
                MessageBox.Show("Valor no válido para la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mejorar el texto del mensaje.
                return;
            }

            if (Convert.ToInt32(tbxCantidadProducto.Text) <= 0)
            {
                MessageBox.Show("Cantidad incorrecta. Debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mejorar el texto del mensaje.
                return;
            }

            try
            {
                string productoSeleccionado = cbxProductos.SelectedItem.ToString();

                DataGridViewRow productoRepetido = dgvProductosVenta.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => productoSeleccionado == r.Cells[0].Value.ToString());

                if (productoRepetido == null)
                {
                    AgregarNuevoProducto(productoSeleccionado);
                }
                else
                {
                    ActualizarProductoExistente(productoRepetido);
                }

                //_venta.GenerarVenta();
            }
            catch (Exception ex) // Añadir excepciones de negocio.
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormGenerarVenta_Load(object sender, EventArgs e)
        {
            try
            {
                _productos = _producto.TraerProductos();
                List<ClienteBE> clientes = _cliente.ObtenerClientes();
                cbxSeleccionCliente.Items.Clear();
                cbxProductos.Items.Clear();

                foreach (ProductoBE producto in _productos)
                {
                    cbxProductos.Items.Add(producto.Nombre.ToString());
                }

                foreach (var cliente in clientes)
                {
                    cbxSeleccionCliente.Items.Add($"{cliente.Apellido}, {cliente.Nombre} - DNI: {cliente.Dni}");
                }

                dgvProductosVenta.EnableHeadersVisualStyles = false;
                dgvProductosVenta.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProductosVenta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                cbxProductos.Items.Insert(0, "Nombre del Producto");
                cbxProductos.SelectedIndex = 0;
                cbxProductos.DropDown += cbxProductos_DropDown;
                cbxProductos.SelectedIndexChanged += cbxProductos_SelectedIndexChanged;
                cbxProductos.Validating += cbxProductos_Validating;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarProductoExistente(DataGridViewRow productoRepetido)
        {
            string productoSeleccionado = productoRepetido.Cells[0].Value.ToString();

            int cantidadNueva = Convert.ToInt32(productoRepetido.Cells[2].Value.ToString()) + Convert.ToInt32(tbxCantidadProducto.Text.ToString());
            ProductoBE productoEnLista = _productos.FirstOrDefault(p => productoSeleccionado == p.Nombre);

            if (productoEnLista != null && cantidadNueva > productoEnLista.Cantidad.CantidadStock)
            {
                MessageBox.Show($"Esa cantidad excede los niveles de stock del producto.\n\nProducto: {productoSeleccionado}.\nStock actual: {Math.Abs(productoEnLista.Cantidad.CantidadStock - Convert.ToInt32(productoRepetido.Cells[2].Value.ToString()))} unidad/es.", "Error de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            productoRepetido.Cells[2].Value = $"{Convert.ToInt32(productoRepetido.Cells[2].Value.ToString()) + Convert.ToInt32(tbxCantidadProducto.Text.ToString())}"; // CANTIDAD
            productoRepetido.Cells[3].Value = $"{(long)Convert.ToDouble(productoRepetido.Cells[2].Value.ToString()) * (long)Convert.ToDouble(productoRepetido.Cells[1].Value.ToString()):F2}"; // SUBTOTAL

            tbxCantidadProducto.Text = String.Empty;
            cbxProductos.SelectedIndex = -1;

        }

        private void AgregarNuevoProducto(string productoSeleccionado)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvProductosVenta);

            ProductoBE producto = _productos.FirstOrDefault(p => productoSeleccionado == p.Nombre);

            if (productoSeleccionado == producto.Nombre.ToString())
            {
                if (Convert.ToInt32(tbxCantidadProducto.Text.ToString()) > producto.Cantidad.CantidadStock)
                {
                    MessageBox.Show($"Esa cantidad excede los niveles de stock del producto.\n\nProducto: {producto.Nombre}.\nStock actual: {producto.Cantidad.CantidadStock} unidad/es.", "Error de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                row.Cells[0].Value = productoSeleccionado;     // NOMBRE
                row.Cells[1].Value = $"{producto.Precio:F2}";  // PRECIO
                row.Cells[2].Value = tbxCantidadProducto.Text; // CANTIDAD
                row.Cells[3].Value = $"{producto.Precio * (long)Convert.ToDouble(tbxCantidadProducto.Text):F2}"; // SUBTOTAL

                dgvProductosVenta.Rows.Add(row);
                tbxCantidadProducto.Text = String.Empty;
                cbxProductos.SelectedIndex = -1;
                return;
            }
        }

        private void cbxProductos_DropDown(object sender, EventArgs e)
        {
            if (cbxProductos.Items[0].ToString() == "Nombre del Producto")
            {
                cbxProductos.Items.RemoveAt(0);
            }
        }

        private void cbxProductos_Validating(object sender, CancelEventArgs e)
        {
            if (cbxProductos.SelectedIndex == -1)
            {
                cbxProductos.Items.Insert(0, "Nombre del Producto");
                cbxProductos.SelectedIndex = 0;
            }
        }

        private void cbxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProductos.SelectedIndex == -1)
            {
                cbxProductos.Items.Insert(0, "Nombre del Producto");
                cbxProductos.SelectedIndex = 0;
            }
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            DialogResult eleccion = MessageBox.Show("¿Está seguro de que desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (eleccion == DialogResult.Yes)
            {
                try
                {
                    UsuarioBE usuario = ManejadorDeSesion.Instancia.Sesion;
                    int indice = cbxSeleccionCliente.Text.IndexOf(": ");
                    string dni = cbxSeleccionCliente.Text.Substring(indice + 2);
                    ClienteBE cliente = _cliente.BuscarClientePorDNI(Convert.ToInt32(dni));
                    VentaBE venta = new VentaBE
                    {
                        EmpleadoResponsable = new EmpleadoBE
                        {
                            IdEmpleado = usuario.Empleado.IdEmpleado,
                            Apellido = usuario.Empleado.Apellido,
                            Nombre = usuario.Empleado.Nombre,
                            Correo = usuario.Empleado.Correo,
                            Dni = usuario.Empleado.Dni,
                            CargoEmpleado = usuario.Empleado.CargoEmpleado,
                            Direccion = usuario.Empleado.Direccion
                        },
                        ClienteAsociado = cliente,
                        FechaVenta = DateTime.Now,
                        DetalleVentas = new List<DetalleVentaBE>()
                    };

                    long montoTotal = 0;

                    venta.EmpleadoResponsable = usuario.Empleado;
                    venta.ClienteAsociado = cliente;

                    List<DetalleVentaBE> detalles = new List<DetalleVentaBE>();

                    foreach (DataGridViewRow row in dgvProductosVenta.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string nombreProducto = row.Cells["Nombre"].Value.ToString();
                        ProductoBE producto = _productos.FirstOrDefault(p => nombreProducto == p.Nombre);

                        if (producto != null)
                        {
                            DetalleVentaBE detalle = new DetalleVentaBE
                            {
                                Producto = new ProductoBE
                                {
                                    IdProducto = producto.IdProducto,
                                    Nombre = producto.Nombre,
                                    Precio = producto.Precio,
                                    Proveedor = new Proveedor
                                    {
                                        IdProveedor = producto.Proveedor.IdProveedor,
                                        Correo = producto.Proveedor.Correo,
                                        NombreEmpresa = producto.Proveedor.NombreEmpresa,
                                        Telefono = producto.Proveedor.Telefono
                                    },
                                    Categoria = new CategoriaProducto
                                    {
                                        IdCategoria = producto.Categoria.IdCategoria,
                                        Nombre = producto.Categoria.Nombre
                                    },
                                    Cantidad = new Stock
                                    {
                                        IdProducto = producto.IdProducto,
                                        CantidadStock = producto.Cantidad.CantidadStock
                                    }
                                },
                                CantidadDeVenta = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString()),
                                PrecioUnitario = producto.Precio,
                            };

                            montoTotal += (long)Convert.ToDouble(row.Cells["Subtotal"].Value.ToString());
                            detalles.Add(detalle);
                        }
                    }
                    venta.TotalVenta = montoTotal;
                    venta.DetalleVentas.AddRange(detalles);
                    _venta.GenerarVenta(venta);

                    dgvProductosVenta.DataSource = null;
                    dgvProductosVenta.Rows.Clear();
                }
                catch (Exception)
                {

                    throw;
                }
                
            }

        }
    }
}
