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

        public VentaDAL()
        {
            _storeProcedure = new ManejadorStoreProcedure();
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
                            EmpleadoResponsable = ObtenerEmpleadoPorId(Convert.ToInt32(row["IdEmpleado"])),
                            ClienteAsociado = ObtenerClientePorId(idCliente),
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
                                Cantidad = Convert.ToInt32(row["StockCantidad"])
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
                        Cantidad = Convert.ToInt32(row["Cantidad"]),
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

        private Cargo CrearCargo(string nombreCargo, int idCargo)
        {
            /*
             * No usar reflection, no me gusta, además no es seguro...
             * Mejor utilizar el patrón fábrica (hacerlo sencillo)..
             */
            Type cargoType = Type.GetType($"Cargo.{nombreCargo}");

            if (cargoType == null || !typeof(Cargo).IsAssignableFrom(cargoType))
            {
                throw new Exception($"Tipo de cargo desconocido o no válido: {nombreCargo}");
            }

            Cargo cargo = (Cargo)Activator.CreateInstance(cargoType);
            cargo.IdCargo = idCargo;

            return cargo;
            // ------------------------------------------------------------------------------
        }


        private ClienteBE ObtenerClientePorId(int idCliente)
        {

            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdCliente", idCliente)
                };

                DataTable dt = _storeProcedure.LeerPorStoreProcedure("sp_cliente_por_id", parametros);
                DataRow row = dt.Rows[0];

                ClienteBE cliente = new ClienteBE
                {
                    IdCliente = Convert.ToInt32(row["IdCliente"]),
                    Dni = Convert.ToInt32(row["Dni"]),
                    Nombre = row["Nombre"].ToString(),
                    Apellido = row["Apellido"].ToString(),
                    Correo = row["CorreoElectronico"].ToString(),
                    Direccion = ObtenerDireccionPorId(Convert.ToInt32(row["IdDireccion"]))
                };

                return cliente;

            }
            catch (Exception)
            {

                throw;
            }

        }


        private DireccionBE ObtenerDireccionPorId(int idDireccion)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdDireccion", idDireccion)
                };

                DataTable dt = _storeProcedure.LeerPorStoreProcedure("sp_direccion_por_id", parametros);
                DataRow row = dt.Rows[0];

                DireccionBE direccion = new DireccionBE
                {
                    IdDireccion = Convert.ToInt32(row["IdDireccion"]),
                    NombreCalle = row["NombreCalle"].ToString(),
                    NumeroCalle = Convert.ToInt32(row["NumeroCalle"]),
                    Localidad = ObtenerLocalidadPorId(Convert.ToInt32(row["IdLocalidad"]))
                };

                return direccion;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private LocalidadBE ObtenerLocalidadPorId(int idLocalidad)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdLocalidad", idLocalidad)
                };

                DataTable dt = _storeProcedure.LeerPorStoreProcedure("sp_localidad_por_id", parametros);
                DataRow row = dt.Rows[0];

                LocalidadBE localidad = new LocalidadBE
                {
                    IdLocalidad = Convert.ToInt32(row["IdLocalidad"]),
                    NombreLocalidad = row["NombreLocalidad"].ToString(),
                    CodigoPostal = row["CodigoPostal"].ToString()
                };

                return localidad;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private EmpleadoBE ObtenerEmpleadoPorId(int idEmpleado)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdEmpleado", idEmpleado)
                };

                DataTable dt = _storeProcedure.LeerPorStoreProcedure("sp_empleado_por_id", parametros);
                DataRow row = dt.Rows[0];

                EmpleadoBE empleado = new EmpleadoBE
                {
                    IdEmpleado = Convert.ToInt32(row["IdEmpleado"]),
                    Dni = Convert.ToInt32(row["Dni"]),
                    Nombre = row["Nombre"].ToString(),
                    Apellido = row["Apellido"].ToString(),
                    Correo = row["CorreoElectronico"].ToString(),
                    Direccion = ObtenerDireccionPorId(Convert.ToInt32(row["IdDireccion"])),
                    Cargo = ObtenerCargoPorId(Convert.ToInt32(row["IdCargo"]))
                };

                return empleado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private Cargo ObtenerCargoPorId(int idCargo)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdCargo", idCargo)
                };

                DataTable dt = _storeProcedure.LeerPorStoreProcedure("sp_cargo_por_id", parametros);
                DataRow row = dt.Rows[0];

                Cargo cargo = null;

                // De acá en más utilizar la fábrica para crear instancias de los cargos
                // Es decir el método CrearCargo...

                return cargo;


            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
