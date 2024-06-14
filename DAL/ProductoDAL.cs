using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Security.Cryptography;

namespace DAL
{
    public class ProductoDAL
    {
        private readonly ManejadorStoreProcedure _conexion;

        public ProductoDAL()
        {
            _conexion = new ManejadorStoreProcedure();
        }

        public void CrearProducto(ProductoBE producto)
        {
            try
            {
                if (producto == null)
                {
                    throw new ArgumentNullException();
                }

                // Insertar producto
                //string queryInsertarProducto = $"INSERT INTO dbo.Producto (Nombre, Precio, IdProveedor, IdCategoria) VALUES  ('{producto.Nombre}', '{producto.Precio}', '{producto.Proveedor.IdProveedor}' , '{producto.Categoria.IdCategoria}')";
                //var identity = _conexion.EscribirPorComando(queryInsertarProducto);
                //string queryInsertarCantidad = $"INSERT INTO dbo.Stock (IdProducto, Cantidad) VALUES  ('{identity}', '{producto.Cantidad.Cantidad}')";
                //string queryInsertarProducto = $"INSERT INTO dbo.Producto (Nombre, Precio, IdProveedor, IdCategoria) VALUES  ('{producto.Nombre}', '{producto.Precio}', '{producto.Proveedor.IdProveedor}' , '{producto.Categoria.IdCategoria}')";
                //var identity = _conexion.EscribirPorComando(queryInsertarProducto);
                //string queryInsertarCantidad = $"INSERT INTO dbo.Stock (IdProducto, Cantidad) VALUES  ('{identity}', '{producto.Cantidad.Cantidad}')";
                //string queryInsertarProducto = $"INSERT INTO dbo.Producto (Nombre, Precio, IdProveedor, IdCategoria) VALUES  ('{producto.Nombre}', '{producto.Precio}', '{producto.Proveedor.IdProveedor}' , '{producto.Categoria.IdCategoria}')";
                    new SqlParameter("@Cantidad", producto.Cantidad.CantidadStock)
                //string queryInsertarCantidad = $"INSERT INTO dbo.Stock (IdProducto, Cantidad) VALUES  ('{identity}', '{producto.Cantidad.Cantidad}')";
                //string queryInsertarProducto = $"INSERT INTO dbo.Producto (Nombre, Precio, IdProveedor, IdCategoria) VALUES  ('{producto.Nombre}', '{producto.Precio}', '{producto.Proveedor.IdProveedor}' , '{producto.Categoria.IdCategoria}')";
                //var identity = _conexion.EscribirPorComando(queryInsertarProducto);
                //string queryInsertarCantidad = $"INSERT INTO dbo.Stock (IdProducto, Cantidad) VALUES  ('{identity}', '{producto.Cantidad.Cantidad}')";
                //string queryInsertarProducto = $"INSERT INTO dbo.Producto (Nombre, Precio, IdProveedor, IdCategoria) VALUES  ('{producto.Nombre}', '{producto.Precio}', '{producto.Proveedor.IdProveedor}' , '{producto.Categoria.IdCategoria}')";
                //var identity = _conexion.EscribirPorComando(queryInsertarProducto);
                //string queryInsertarCantidad = $"INSERT INTO dbo.Stock (IdProducto, Cantidad) VALUES  ('{identity}', '{producto.Cantidad.Cantidad}')";
                //string queryInsertarProducto = $"INSERT INTO dbo.Producto (Nombre, Precio, IdProveedor, IdCategoria) VALUES  ('{producto.Nombre}', '{producto.Precio}', '{producto.Proveedor.IdProveedor}' , '{producto.Categoria.IdCategoria}')";
                //var identity = _conexion.EscribirPorComando(queryInsertarProducto);
                //string queryInsertarCantidad = $"INSERT INTO dbo.Stock (IdProducto, Cantidad) VALUES  ('{identity}', '{producto.Cantidad.Cantidad}')";
                //string queryInsertarProducto = $"INSERT INTO dbo.Producto (Nombre, Precio, IdProveedor, IdCategoria) VALUES  ('{producto.Nombre}', '{producto.Precio}', '{producto.Proveedor.IdProveedor}' , '{producto.Categoria.IdCategoria}')";
                //var identity = _conexion.EscribirPorComando(queryInsertarProducto);
                //string queryInsertarCantidad = $"INSERT INTO dbo.Stock (IdProducto, Cantidad) VALUES  ('{identity}', '{producto.Cantidad.Cantidad}')";
                //string queryInsertarProducto = $"INSERT INTO dbo.Producto (Nombre, Precio, IdProveedor, IdCategoria) VALUES  ('{producto.Nombre}', '{producto.Precio}', '{producto.Proveedor.IdProveedor}' , '{producto.Categoria.IdCategoria}')";
                //var identity = _conexion.EscribirPorComando(queryInsertarProducto);
                //string queryInsertarCantidad = $"INSERT INTO dbo.Stock (IdProducto, Cantidad) VALUES  ('{identity}', '{producto.Cantidad.Cantidad}')";
                //string queryInsertarProducto = $"INSERT INTO dbo.Producto (Nombre, Precio, IdProveedor, IdCategoria) VALUES  ('{producto.Nombre}', '{producto.Precio}', '{producto.Proveedor.IdProveedor}' , '{producto.Categoria.IdCategoria}')";
                string query = "SELECT IdCategoria, Nombre FROM dbo.CategoriaProducto";
                DataTable tablaCategorias = _conexion.LeerPorComando(query);
                //string queryInsertarProducto = $"INSERT INTO dbo.Producto (Nombre, Precio, IdProveedor, IdCategoria) VALUES  ('{producto.Nombre}', '{producto.Precio}', '{producto.Proveedor.IdProveedor}' , '{producto.Categoria.IdCategoria}')";
                //var identity = _conexion.EscribirPorComando(queryInsertarProducto);
                //string queryInsertarCantidad = $"INSERT INTO dbo.Stock (IdProducto, Cantidad) VALUES  ('{identity}', '{producto.Cantidad.Cantidad}')";
                //string queryInsertarProducto = $"INSERT INTO dbo.Producto (Nombre, Precio, IdProveedor, IdCategoria) VALUES  ('{producto.Nombre}', '{producto.Precio}', '{producto.Proveedor.IdProveedor}' , '{producto.Categoria.IdCategoria}')";
                //var identity = _conexion.EscribirPorComando(queryInsertarProducto);
                //string queryInsertarCantidad = $"INSERT INTO dbo.Stock (IdProducto, Cantidad) VALUES  ('{identity}', '{producto.Cantidad.Cantidad}')";
                string SP = "CrearProducto";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", producto.Nombre),
                    new SqlParameter("@Precio", producto.Precio),
                    new SqlParameter("@IdProveedor", producto.Proveedor.IdProveedor),
                    new SqlParameter("@IdCategoria", producto.Categoria.IdCategoria),
                    new SqlParameter("@Cantidad", producto.Cantidad.Cantidad)
                };

                _conexion.EscribirPorStoreProcedure(SP, parameters);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CategoriaProducto> ObtenerCategoria()
                string query = "ObtenerProveedor";
                DataTable tablaProveedor = _conexion.LeerPorStoreProcedure(query);
            try
            {
                string query = "ObtenerCategoria";
                DataTable tablaCategorias = _conexion.LeerPorStoreProcedure(query);

                foreach (DataRow row in tablaCategorias.Rows)
                {
                    int idCategoria = Convert.ToInt32(row["IdCategoria"]);
                    string nombreCategoria = row["Nombre"].ToString();

                    CategoriaProducto categoriaProducto = new CategoriaProducto
                    {
                        IdCategoria = idCategoria,
                        Nombre = nombreCategoria
                    };

                    categorias.Add(categoriaProducto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las categorías. Detalles: " + ex.Message, ex);
            }
            return categorias;
        }

        public List<Proveedor> ObtenerProveedor()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            try
            {
                string query = "ObtenerProveedor";
                DataTable tablaProveedor = _conexion.LeerPorStoreProcedure(query);

                foreach (DataRow row in tablaProveedor.Rows)
                {
                    int idProveedor = Convert.ToInt32(row["IdProveedor"]);
                    string nombreEmpresa = row["NombreEmpresa"].ToString();
                    //string telefono = row["Telefono"].ToString();
                    //string correo = row["Correo"].ToString();


                    Proveedor proveedor = new Proveedor
                    {
                        IdProveedor = idProveedor,
                        NombreEmpresa = nombreEmpresa,
                        //Telefono = telefono,
                        //Correo = correo

                    };

                    proveedores.Add(proveedor);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las categorías. Detalles: " + ex.Message, ex);
            }
            return proveedores;
        }


        public DataTable VisualizarStock(int idProducto)
        {
            string query = "VisualizarStock";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto)
            };

            return _conexion.LeerPorStoreProcedure(query);
        }

        public int EditarProducto(ProductoBE producto)
        {
            string query = "EditarProducto";

            SqlParameter[] parameters = new SqlParameter[]
             {
                new SqlParameter("@Nombre", producto.Nombre),
                new SqlParameter("@Precio", producto.Precio),
                new SqlParameter("@IdProducto", producto.IdProducto)
              };

            return _conexion.EscribirPorStoreProcedure(query, parameters);
        }

        public int EliminarProducto(int idProducto)
        {
            string queryStock = "EliminarProducto";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto)
            };

            return _conexion.EscribirPorStoreProcedure(queryStock, parameters);
        }

        public DataTable BuscarProducto(string nombreProducto)
        {
            string query = "BuscarProducto";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NombreProducto", nombreProducto)
            };

            return _conexion.LeerPorStoreProcedure(query, parameters);
        }



        /*TODO*/
        public DataTable TraerProductos()
        {
            try
            {
                string query = "TraerProductos";
                return _conexion.LeerPorStoreProcedure(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las categorías. Detalles: " + ex.Message, ex);
            }
        }
        public DataTable TraerProductosConStock()
        {
            try
            {
                string query = "TraerProductosConStock";
                return _conexion.LeerPorStoreProcedure(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las categorías. Detalles: " + ex.Message, ex);
            }
        }

        public DataTable TraerStock(int idProducto)
        {
            string query = "TraerStock";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto)
            };

            return _conexion.LeerPorStoreProcedure(query, parameters);
        }

        public int EditarStockProducto(int idProducto, int cantidad)
        {
            string query = "EditarStockProducto";

            SqlParameter[] parameters = new SqlParameter[]
             {
                new SqlParameter("@IdProducto", idProducto),
                new SqlParameter("@Cantidad", cantidad),
              };

            return _conexion.EscribirPorStoreProcedure(query, parameters);
        }
    }
}

