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

        public void CrearProducto(int idProducto, string nombre, long precio, int cantidad, string categoria, string proveedor)
        {
            string query = "INSERT INTO dbo.Producto (IdProducto, Nombre, Precio, Cantidad, Categoria, Proveedor) VALUES (@IdProducto, @Nombre, @Precio, @Cantidad, @Categoria, @Proveedor)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto),
                new SqlParameter("@Nombre", nombre),
                new SqlParameter("@Precio", precio),
                new SqlParameter("@Cantidad", cantidad),
                new SqlParameter("@Categoria", categoria),
                new SqlParameter("@Proveedor", proveedor)
            };

            _conexion.EscribirPorComando(query);
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

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto),
                new SqlParameter("@Nombre", nombre),
                new SqlParameter("@Precio", precio),
                new SqlParameter("@Cantidad", cantidad),
                new SqlParameter("@Categoria", categoria),
                new SqlParameter("@Proveedor", proveedor)
            };

            _conexion.EscribirPorComando(query);
        }

        public void EliminarProducto(int idProducto)
        {
            string query = "DELETE FROM dbo.Producto WHERE IdProducto = @IdProducto";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto)
            };

            _conexion.EscribirPorComando(query);
        }

        public DataTable BuscarProducto(int idProducto)
        {
            string query = "SELECT * FROM dbo.Producto WHERE IdProducto = " + idProducto;

        
            return _conexion.LeerPorComando(query);
        }

    }
}

