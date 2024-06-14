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
    public class ClienteDAL
    {
        private Conexion conexion; // Agregamos un campo para la instancia de Conexion
        private ManejadorStoreProcedure _storeProcedure;
        private DireccionDAL _direccion;

        public ClienteDAL()
        {
            conexion = new Conexion(); // Creamos una instancia de Conexion
            _storeProcedure = new ManejadorStoreProcedure();
            _direccion = new DireccionDAL();
        }

        public void CrearCliente(ClienteBE cliente)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@Dni", cliente.Dni),
                new SqlParameter("@Nombre", cliente.Nombre),
                new SqlParameter("@Apellido", cliente.Apellido),
                new SqlParameter("@CorreoElectronico", cliente.Correo),
                new SqlParameter("@NombreCalle", cliente.Direccion.NombreCalle),
                new SqlParameter("@NumeroCalle", cliente.Direccion.NumeroCalle),
                new SqlParameter("@NombreLocalidad", cliente.Direccion.Localidad.NombreLocalidad),
                new SqlParameter("@CodigoPostal", cliente.Direccion.Localidad.CodigoPostal)
                };

                _storeProcedure.EscribirPorStoreProcedure("sp_crear_cliente", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el cliente. Detalles: " + ex.Message, ex);
            }
        }

        public ClienteBE BuscarClientePorDNI(int dni)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                conexion.crearParametro("@Dni", dni)
                };

                DataTable tabla = _storeProcedure.LeerPorStoreProcedure("sp_buscar_cliente_por_dni", parametros);

                if (tabla.Rows.Count > 0)
                {
                    DataRow fila = tabla.Rows[0];

                    return new ClienteBE
                    {
                        IdCliente = Convert.ToInt32(fila["IdCliente"]),
                        Dni = Convert.ToInt32(fila["Dni"]),
                        Nombre = fila["Nombre"].ToString(),
                        Apellido = fila["Apellido"].ToString(),
                        Correo = fila["CorreoElectronico"].ToString(),
                        Direccion = new DireccionBE
                        {
                            IdDireccion = Convert.ToInt32(fila["IdDireccion"]),
                            NombreCalle = fila["NombreCalle"].ToString(),
                            NumeroCalle = Convert.ToInt32(fila["NumeroCalle"]),
                            Localidad = new LocalidadBE
                            {
                                IdLocalidad = Convert.ToInt32(fila["IdLocalidad"]),
                                NombreLocalidad = fila["NombreLocalidad"].ToString(),
                                CodigoPostal = fila["CodigoPostal"].ToString()
                            }
                        }
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el cliente por DNI.", ex);
            }
        }

        public void ActualizarCliente(ClienteBE cliente)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                conexion.crearParametro("@IdCliente", cliente.IdCliente),
                conexion.crearParametro("@Dni", cliente.Dni),
                conexion.crearParametro("@Nombre", cliente.Nombre),
                conexion.crearParametro("@Apellido", cliente.Apellido),
                conexion.crearParametro("@CorreoElectronico", cliente.Correo),
                conexion.crearParametro("@NombreCalle", cliente.Direccion.NombreCalle),
                conexion.crearParametro("@NumeroCalle", cliente.Direccion.NumeroCalle),
                conexion.crearParametro("@NombreLocalidad", cliente.Direccion.Localidad.NombreLocalidad),
                conexion.crearParametro("@CodigoPostal", cliente.Direccion.Localidad.CodigoPostal),
                };

                _storeProcedure.EscribirPorStoreProcedure("sp_actualizar_cliente", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el cliente.", ex);
            }
        }

        public ClienteBE ObtenerClientePorId(int idCliente)
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
                    Direccion = _direccion.ObtenerDireccionPorId(Convert.ToInt32(row["IdDireccion"]))
                };

                return cliente;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

