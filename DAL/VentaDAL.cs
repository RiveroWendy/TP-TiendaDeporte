using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class VentaDAL
    {
        private readonly Conexion _conexion;

        public VentaDAL()
        {
            _conexion = new Conexion();
        }

        public void AgregarVenta(VentaBE venta)
        {
            try
            {
                if (venta == null)
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<VentaBE> BuscarVenta(string argumento, string pValor)
        {
            List<VentaBE> ventas = new List<VentaBE>();

            try
            {
                if (!new[] { "Nombre", "Apellido", "DNI" }.Contains(argumento))
                {
                    throw new ArgumentException("Criterio de búsqueda no válido.");
                }

                string query = $"SELECT v.IdVenta, v.FechaVenta, v.IdEmpleado, v.IdCliente, v.TotalVenta " +
                               "FROM Venta v " +
                               "JOIN Empleado e ON v.IdEmpleado = e.IdEmpleado " +
                               $"WHERE e.{argumento} LIKE {pValor}";

                DataTable tabla = _conexion.LeerPorComando(query);

                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow row in tabla.Rows)
                    {
                        VentaBE venta = new VentaBE();
                        venta.IdVenta = Convert.ToInt32(row["IdVenta"]);
                        venta.FechaVenta = Convert.ToDateTime(row["FechaVenta"]);
                        venta.IdEmpleado = Convert.ToInt32(row["IdEmpleado"]);
                        venta.TotalVenta = long.Parse(row["TotalVenta"].ToString());

                        //ventas.Add(venta);
                    }
                }

                foreach (VentaBE venta in ventas)
                {
                    venta.DetalleVentas = ObtenerDetallesVenta(venta.IdVenta);
                    
                }

            }
            catch (Exception)
            {

                throw;
            }

            return null;
        }

        private List<DetalleVentaBE> ObtenerDetallesVenta(int idVenta)
        {
            List<DetalleVentaBE> detalles = new List<DetalleVentaBE>();

            try
            {
                string query = $"SELECT * FROM DetalleVenta WHERE IdVenta = {idVenta}";
                DataTable tabla = _conexion.LeerPorComando(query);

                foreach (DataRow row in tabla.Rows)
                {
                    ProductoBE producto = new ProductoBE();
                    producto.IdProducto = (int)row["IdProducto"];


                    DetalleVentaBE detalle = new DetalleVentaBE();
                    detalle.IdDetalleVenta = (int)row["IdDetalleVenta"];
                    detalle.Cantidad = (int)row["Cantidad"];
                    detalle.PrecioUnitario = (long)row["PrecioUnitario"];
                    detalle.Producto = producto;

                    detalles.Add(detalle);
                }

            }
            catch (Exception)
            {
                throw;
            }


            return null;
        }

    }
}
