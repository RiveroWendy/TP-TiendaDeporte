using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoBLL
    {
        private List<ProductoBE> _productos;
        private ProductoDAL _productoDAL = new ProductoDAL();

        public ProductoBLL()
        {
            _productos = new List<ProductoBE>();
        }

        public void CrearProducto(ProductoBE producto)
        {
            try
            {
                if (producto == null)
                {
                    throw new ArgumentNullException(nameof(producto), "El producto no puede ser nulo");
                }

                _productoDAL.CrearProducto(producto);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al crear el producto. Detalles: " + ex.Message, ex);
            }
        }

        public Stock VisualizarStock(int idProducto)
        {
            var producto = _productos.FirstOrDefault(p => p.IdProducto == idProducto);
            return producto?.Cantidad;
        }

        public int EditarProducto(int idProducto, string nombre, long precio)
        {
            ProductoBE producto = new ProductoBE(); 
            if (producto != null)
            {
                producto.IdProducto = idProducto;
                producto.Nombre = nombre;
                producto.Precio = precio;
                producto.Cantidad = new Stock();
                producto.Categoria = new CategoriaProducto();
                producto.Proveedor = new Proveedor();

            }
            return _productoDAL.EditarProducto(producto);
        }

        public int EditarStockProducto(int idProducto, int cantidad)
        {
            return _productoDAL.EditarStockProducto(idProducto, cantidad);
        }

        public void EliminarProducto(int idProducto)
        {
            var producto = _productos.FirstOrDefault(p => p.IdProducto == idProducto);
            if (producto != null)
            {
                _productos.Remove(producto);
            }
        }

        public ProductoBE BuscarProducto(int idProducto)
        {
            var producto = _productos.FirstOrDefault(p => p.IdProducto == idProducto);
            if (producto != null)
            {
                return producto;
            }
            else
            {
                DataTable productoData = _productoDAL.BuscarProducto(idProducto);
                if (productoData.Rows.Count > 0)
                {
                    DataRow row = productoData.Rows[0];
                    ProductoBE encontradoProducto = new ProductoBE
                    {
                        IdProducto = Convert.ToInt32(row["IdProducto"]),
                        Nombre = row["Nombre"].ToString(),
                        Precio = Convert.ToInt64(row["Precio"]),
                        //Cantidad = new Stock { Cantidad = Convert.ToInt32(row["Cantidad"]) },
                        //Categoria = new CategoriaProducto { Nombre = row["Categoria"].ToString() },
                        //Proveedor = new Proveedor { NombreEmpresa = row["Proveedor"].ToString() }
                    };
                    return encontradoProducto;
                }
                return null;
            }
        }

        public List<CategoriaProducto> ObtenerCategoria()
        {
            try
            {
                var productoDAL = new ProductoDAL();
                return productoDAL.ObtenerCategoria();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las categorías. Detalles: " + ex.Message, ex);
            }
        }

        public List<Proveedor> ObtenerProveedor()
        {
            try
            {
                var productoDAL = new ProductoDAL();
                return productoDAL.ObtenerProveedor();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los proveedores. Detalles: " + ex.Message, ex);
            }
        }

        /*TODO*/
        public List<ProductoBE> TraerProductos()
        {
            try
            {
                var productoData = _productoDAL.TraerProductosConStock();

                List<ProductoBE> productos = new List<ProductoBE>();

                foreach (DataRow row in productoData.Rows)
                {
                    int IdProducto = Convert.ToInt32(row["IdProducto"]);
                    string Nombre = row["Nombre"].ToString();
                    long Precio = Convert.ToInt64(row["Precio"]);
                    int IdProveedor = Convert.ToInt32(row["IdProveedor"]);
                    int IdCategoria = Convert.ToInt32(row["IdCategoria"]);
                    int Cantidad = Convert.ToInt32(row["Cantidad"]);


                    ProductoBE producto = new ProductoBE
                    {
                        IdProducto = IdProducto,
                        Nombre = Nombre,
                        Precio = Precio,
                        Proveedor = new Proveedor
                        {
                            IdProveedor = IdProveedor
                        },
                        Categoria = new CategoriaProducto
                        {
                            IdCategoria = IdCategoria
                        },
                        Cantidad = new Stock
                        {
                            Cantidad = Cantidad
                        }
                };

                    productos.Add(producto);
                }

                return productos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los proveedores. Detalles: " + ex.Message, ex);

            }
        }

        public Stock TraerStock(int idProducto)
        {
            try
            {
                var productoData = _productoDAL.TraerStock(idProducto);

                Stock stock = new Stock();

                foreach (DataRow row in productoData.Rows)
                {
                    //int IdStock = Convert.ToInt32(row["IdStock"]);
                    int IdProducto = Convert.ToInt32(row["IdProducto"]);
                    int Precio = Convert.ToInt32(row["Cantidad"]);

                    stock.IdProducto = IdProducto;
                    stock.Cantidad = Precio;
                }
                
                return stock;


            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los proveedores. Detalles: " + ex.Message, ex);

            }
        }
    }
}

