using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BE;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;

namespace DAL
{
    public class UsuarioDAL
    {

        private Conexion conexion = new Conexion();
        private ManejadorStoreProcedure _conexion = new ManejadorStoreProcedure();
        private CargoDAL _cargo;

        public UsuarioDAL()
        {
            _cargo = new CargoDAL();
        }

        public UsuarioBE BuscarUsuarioPorDni(int dni)
        {
            try
            {
                string nombreSP = "sp_buscar_empleado_por_dni";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@Dni", SqlDbType.Int) { Value = dni }
                };

                DataTable tabla = _conexion.LeerPorStoreProcedure(nombreSP, parameters);

                if (tabla.Rows.Count > 0)
                {
                    DataRow fila = tabla.Rows[0];
                    int idUsuario = Convert.ToInt32(fila["IdUsuario"]);
                    int idEmpleado = Convert.ToInt32(fila["IdEmpleado"]);

                    Cargo cargo = _cargo.ObtenerCargoPorId(Convert.ToInt32(fila["IdCargo"]));

                    return new UsuarioBE
                    {
                        IdUsuario = Convert.ToInt32(fila["IdUsuario"]),
                        NombreUsuario = fila["NombreUsuario"].ToString(),
                        Clave = fila["Clave"].ToString(),
                        Empleado = new EmpleadoBE
                        {
                            IdEmpleado = idEmpleado,
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
                            },
                            CargoEmpleado = cargo
                        }
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el usuario por DNI en la base de datos. Detalles: " + ex.Message, ex);
            }
        }

        public void ActualizarUsuario(UsuarioBE usuario)
        {
            string nombreSP = "sp_actualizar_usuario";
            SqlParameter[] parametros = new SqlParameter[]
            {
        conexion.crearParametro("@IdUsuario", usuario.IdUsuario),
        conexion.crearParametro("@Nombre", usuario.Empleado.Nombre),
        conexion.crearParametro("@Apellido", usuario.Empleado.Apellido),
        conexion.crearParametro("@Dni", usuario.Empleado.Dni),
        conexion.crearParametro("@CorreoElectronico", usuario.Empleado.Correo),
        conexion.crearParametro("@NombreCalle", usuario.Empleado.Direccion.NombreCalle),
        conexion.crearParametro("@NumeroCalle", usuario.Empleado.Direccion.NumeroCalle),
        conexion.crearParametro("@NombreLocalidad", usuario.Empleado.Direccion.Localidad.NombreLocalidad),
        conexion.crearParametro("@CodigoPostal", usuario.Empleado.Direccion.Localidad.CodigoPostal),
        conexion.crearParametro("@IdCargo", usuario.Empleado.CargoEmpleado.IdCargo),
        conexion.crearParametro("@NombreUsuario", usuario.NombreUsuario),
        conexion.crearParametro("@Clave", usuario.Clave)
            };

            _conexion.EscribirPorStoreProcedure(nombreSP, parametros);
        }

        public void CrearUsuario(UsuarioBE usuario)
        {
            try
            {
                if (usuario == null)
                {
                    throw new ArgumentNullException(nameof(usuario), "El objeto usuario no puede ser nulo.");
                }
                if (usuario.Empleado == null)
                {
                    throw new ArgumentNullException(nameof(usuario.Empleado), "El objeto Empleado en el usuario no puede ser nulo.");
                }

                EmpleadoBE empleado = usuario.Empleado;
                LocalidadBE localidad = empleado.Direccion.Localidad;


                string nombreSP = "sp_crear_usuario";

                SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Nombre", empleado.Nombre),
                        new SqlParameter("@Apellido", empleado.Apellido),
                        new SqlParameter("@Dni", empleado.Dni),
                        new SqlParameter("@CorreoElectronico", empleado.Correo),
                        new SqlParameter("@NombreCalle", empleado.Direccion.NombreCalle),
                        new SqlParameter("@NumeroCalle", empleado.Direccion.NumeroCalle),
                        new SqlParameter("@NombreLocalidad", localidad.NombreLocalidad),
                        new SqlParameter("@CodigoPostal", localidad.CodigoPostal),
                        new SqlParameter("@IdCargo", empleado.CargoEmpleado.IdCargo),
                        new SqlParameter("@NombreUsuario", usuario.NombreUsuario),
                        new SqlParameter("@Clave", usuario.Clave)
                    };

                _conexion.EscribirPorStoreProcedure(nombreSP, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el usuario en la base de datos. Detalles: " + ex.Message, ex);
            }
        }
        public void EliminarUsuario(int dni)
        {
            try
            {
                SqlParameter[] parametros =
                {
            new SqlParameter("@Dni", dni)
        };

                ManejadorStoreProcedure manejadorSP = new ManejadorStoreProcedure();
                int filasAfectadas = manejadorSP.EscribirPorStoreProcedure("sp_eliminar_usuario", parametros);

                if (filasAfectadas <= 0)
                {
                    throw new Exception("No se pudo eliminar el usuario.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el usuario. Detalles: " + ex.Message, ex);
            }
        }
    }
}
