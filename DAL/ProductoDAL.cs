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
        private readonly Conexion _conexion;

        public ProductoDAL()
        {
            _conexion = new Conexion();
        }

        public void CrearProducto(ProductoBE producto)
        {
            try
            {
                if (producto == null)
                {
                    throw new ArgumentNullException();
                }

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
        {
            List<CategoriaProducto> categorias = new List<CategoriaProducto>();
            try
            {
                string query = "SELECT IdCategoria, Nombre FROM dbo.CategoriaProducto";
                DataTable tablaCategorias = _conexion.LeerPorComando(query);

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
                string query = "SELECT IdProveedor, NombreEmpresa, Telefono, Correo FROM dbo.Proveedor";
                DataTable tablaProveedor = _conexion.LeerPorComando(query);

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
            string query = "SELECT Cantidad FROM dbo.Producto WHERE IdProducto = @IdProducto";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto)
            };

            return _conexion.LeerPorComando(query);
        }

        public int EditarProducto(ProductoBE producto)
        {
            string query = "UPDATE dbo.Producto SET Nombre = @Nombre, Precio = @Precio WHERE IdProducto = @IdProducto";

            SqlParameter[] parameters = new SqlParameter[]
             {
                new SqlParameter("@Nombre", producto.Nombre),
                new SqlParameter("@Precio", producto.Precio),
                new SqlParameter("@IdProducto", producto.IdProducto)
              };

            return _conexion.EscribirPorComando(query, parameters);
        }

        public int EliminarProducto(int idProducto)
        {
            int valorFilasAfectadasProducto = 0;

            string queryStock = "EliminarProducto";
            //string queryProducto = "DELETE FROM dbo.Producto WHERE IdProducto = @IdProducto";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto)
            };

            return _conexion.EscribirPorStoreProcedure(queryStock, parameters);
        }

        public DataTable BuscarProducto(int idProducto)
        {
            string query = @"
            SELECT 
                p.IdProducto, 
                p.Nombre, 
                p.Precio, 
                c.Nombre AS Categoria, 
                pr.NombreEmpresa AS Proveedor 
                FROM dbo.Producto p
                JOIN dbo.CategoriaProducto c ON p.IdCategoria = c.IdCategoria
                JOIN dbo.Proveedor pr ON p.IdProveedor = pr.IdProveedor
                WHERE p.IdProducto =" + idProducto;


            return _conexion.LeerPorComando(query);
        }



        /*TODO*/
        public DataTable TraerProductos()
        {
            try
            {
                string query = "SELECT IdProducto, Nombre, Precio, IdProveedor, IdCategoria FROM dbo.Producto";
                return _conexion.LeerPorComando(query);
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
                string query = "SELECT Producto.IdProducto, Nombre, Precio, IdProveedor, IdCategoria, Stock.Cantidad " +
                               "FROM Producto " +
                               "JOIN Stock on Producto.IdProducto = Stock.IdProducto ";
                return _conexion.LeerPorComando(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las categorías. Detalles: " + ex.Message, ex);
            }
        }

        public DataTable TraerStock(int idProducto)
        {
            string query = "SELECT TOP 1 IdProducto, Cantidad FROM dbo.Stock WHERE IdProducto = @IdProducto";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto)
            };

            return _conexion.LeerPorComando(query, parameters);
        }

        public int EditarStockProducto(int idProducto, int cantidad)
        {
            string query = "UPDATE Stock SET Cantidad = @Cantidad WHERE IdProducto = @IdProducto";

            SqlParameter[] parameters = new SqlParameter[]
             {
                new SqlParameter("@IdProducto", idProducto),
                new SqlParameter("@Cantidad", cantidad),
              };

            return _conexion.EscribirPorComando(query, parameters);
        }
    }
}

