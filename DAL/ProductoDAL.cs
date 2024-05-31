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

                // Insertar producto
                string queryInsertarProducto = $"INSERT INTO dbo.Producto (Nombre, Precio, IdProveedor, IdCategoria) VALUES  ('{producto.Nombre}', '{producto.Precio}', '{producto.Proveedor.IdProveedor}' , '{producto.Categoria.IdCategoria}')";
                var identity = _conexion.EscribirPorComando(queryInsertarProducto);
                string queryInsertarCantidad = $"INSERT INTO dbo.Stock (IdProducto, Cantidad) VALUES  ('{identity}', '{producto.Cantidad.Cantidad}')";
                _conexion.EscribirPorComando(queryInsertarCantidad);

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

        public void EditarProducto(int idProducto, string nombre, long precio, int cantidad, string categoria, string proveedor)
        {
            string query = "UPDATE dbo.Producto SET Nombre = @Nombre, Precio = @Precio, Cantidad = @Cantidad, Categoria = @Categoria, Proveedor = @Proveedor WHERE IdProducto = @IdProducto";

            //TO-DO
        }

        public void EliminarProducto(int idProducto)
        {
            string query = "DELETE FROM dbo.Producto WHERE IdProducto = @IdProducto";

            //TO-DO
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

    }
}

