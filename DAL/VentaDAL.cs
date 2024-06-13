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
        private ManejadorStoreProcedure _storeProcedure;
        private ConexionBase _conexion;
        private ClienteDAL _cliente;
        private CargoDAL _cargo;
        private DireccionDAL _direccion;
        private EmpleadoDAL _empleado;

        public VentaDAL()
        {
            _storeProcedure = new ManejadorStoreProcedure();
            _cliente = new ClienteDAL();
            _cargo = new CargoDAL();
            _direccion = new DireccionDAL();
            _empleado = new EmpleadoDAL();
            _conexion = new ConexionBase();
        }

        public void AgregarVenta(VentaBE venta)
        {
            using (SqlConnection connection = new SqlConnection(_conexion.ConnectionString))
            {
                SqlTransaction transaction = null;

                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    SqlParameter[] parametrosVenta = new SqlParameter[]
                    {
                        new SqlParameter("@FechaVenta", venta.FechaVenta),
                        new SqlParameter("@IdEmpleado", venta.EmpleadoResponsable.IdEmpleado),
                        new SqlParameter("@IdCliente", venta.ClienteAsociado.IdCliente),
                        new SqlParameter("@TotalVenta", venta.TotalVenta),
                        new SqlParameter("@IdVenta", SqlDbType.Int) { Direction = ParameterDirection.Output }
                    };

                    _storeProcedure.EscribirPorStoreProcedure("sp_insertar_venta", parametrosVenta);

                    int idVenta = (int)parametrosVenta.First(p => p.ParameterName == "@IdVenta").Value;

                    foreach (DetalleVentaBE detalle in venta.DetalleVentas)
                    {
                        SqlParameter[] parametrosDetalle = new SqlParameter[]
                        {
                            new SqlParameter("@IdVenta", idVenta),
                            new SqlParameter("@IdProducto", detalle.Producto.IdProducto),
                            new SqlParameter("@Cantidad", detalle.CantidadDeVenta),
                            new SqlParameter("@PrecioUnitario", detalle.PrecioUnitario)
                        };

                        _storeProcedure.EscribirPorStoreProcedure("sp_insertar_detalle_venta", parametrosDetalle);

                        SqlParameter[] parametrosStock = new SqlParameter[]
                        {
                            new SqlParameter("@IdProducto", detalle.Producto.IdProducto),
                            new SqlParameter("@Cantidad", detalle.CantidadDeVenta)
                        };

                        _storeProcedure.EscribirPorStoreProcedure("sp_actualizar_stock", parametrosStock, transaction);
                    }


                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    throw new ApplicationException("Error al agregar la venta", ex);
                }
                finally
                {
                    connection.Close();
                }
            }

        }


        public List<VentaBE> BuscarVentaPorIdCliente(int idCliente)
        {
            List<VentaBE> ventas = new List<VentaBE>();

            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdCliente", idCliente)
                };

                DataTable dt = _storeProcedure.LeerPorStoreProcedure("sp_ventas_por_id_cliente", parametros);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        VentaBE venta = new VentaBE
                        {
                            IdVenta = Convert.ToInt32(row["IdVenta"]),
                            FechaVenta = Convert.ToDateTime(row["FechaVenta"]),
                            EmpleadoResponsable = _empleado.ObtenerEmpleadoPorId(Convert.ToInt32(row["IdEmpleado"])),
                            ClienteAsociado = _cliente.ObtenerClientePorId(idCliente),
                            DetalleVentas = ObtenerDetallesVenta(Convert.ToInt32(row["IdVenta"])),
                            TotalVenta = (long)row["TotalVenta"]
                        };

                        ventas.Add(venta);
                    }
                }

                return ventas;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<DetalleVentaBE> ObtenerDetallesVenta(int idVenta)
        {
            List<DetalleVentaBE> detalles = new List<DetalleVentaBE>();

            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdCliente", idVenta)
                };


                DataTable dt = _storeProcedure.LeerPorStoreProcedure("sp_detalles_venta_por_id_venta", parametros);

                foreach (DataRow row in dt.Rows)
                {

                    DetalleVentaBE detalle = new DetalleVentaBE
                    {
                        IdDetalleVenta = Convert.ToInt32(row["IdDetalleVenta"]),
                        Producto = new ProductoBE
                        {
                            IdProducto = Convert.ToInt32(row["IdProducto"]),
                            Nombre = row["NombreProducto"].ToString(),
                            Precio = (long)row["PrecioProducto"],
                            Cantidad = new Stock
                            {
                                IdProducto = Convert.ToInt32(row["IdProducto"]),
                                CantidadStock = Convert.ToInt32(row["StockCantidad"])
                            },
                            Categoria = new CategoriaProducto
                            {
                                IdCategoria = Convert.ToInt32(row["IdCategoria"]),
                                Nombre = row["NombreCategoria"].ToString()
                            },
                            Proveedor = new Proveedor
                            {
                                IdProveedor = Convert.ToInt32(row["IdProveedor"]),
                                NombreEmpresa = row["NombreProveedor"].ToString(),
                                Telefono = (long)row["TelefonoProveedor"],
                                Correo = row["CorreoProveedor"].ToString()
                            }
                        },
                        CantidadDeVenta = Convert.ToInt32(row["Cantidad"]),
                        PrecioUnitario = Convert.ToInt32(row["PrecioUnitario"])
                    };

                    detalles.Add(detalle);
                }

                return detalles;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
