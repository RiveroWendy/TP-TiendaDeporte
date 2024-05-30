using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BE;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        
            private Conexion conexion = new Conexion();

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

                    Cargo cargo = usuario.Empleado.Cargo;
                    if (cargo == null)
                    {
                        throw new ArgumentNullException(nameof(cargo), "El cargo del empleado no puede ser nulo.");
                    }

                    // Insertar localidad y obtener Id
                    string comandoInsertarLocalidad = $"INSERT INTO Localidad (NombreLocalidad, CodigoPostal) VALUES ('{usuario.Empleado.Direccion.Localidad.NombreLocalidad}', '{usuario.Empleado.Direccion.Localidad.CodigoPostal}'); SELECT SCOPE_IDENTITY();";
                    int idLocalidad = Convert.ToInt32(conexion.EscribirPorComando(comandoInsertarLocalidad));

                    // Insertar dirección y obtener Id
                    string comandoInsertarDireccion = $"INSERT INTO Direccion (NombreCalle, NumeroCalle, IdLocalidad) VALUES ('{usuario.Empleado.Direccion.NombreCalle}', {usuario.Empleado.Direccion.NumeroCalle}, {idLocalidad}); SELECT SCOPE_IDENTITY();";
                    int idDireccion = Convert.ToInt32(conexion.EscribirPorComando(comandoInsertarDireccion));

                    // Insertar empleado y obtener Id
                    string comandoInsertarEmpleado = $"INSERT INTO Empleado (Nombre, Apellido, Dni, CorreoElectronico, IdDireccion, IdCargo) VALUES ('{usuario.Empleado.Nombre}', '{usuario.Empleado.Apellido}', {usuario.Empleado.Dni}, '{usuario.Empleado.Correo}', {idDireccion}, {usuario.Empleado.Cargo.IdCargo}); SELECT SCOPE_IDENTITY();";
                    int idEmpleado = Convert.ToInt32(conexion.EscribirPorComando(comandoInsertarEmpleado));

                    // Insertar usuario
                    string comandoInsertarUsuario = $"INSERT INTO Usuario (IdEmpleado, NombreUsuario, Clave) VALUES ({idEmpleado}, '{usuario.NombreUsuario}', '{usuario.Clave}')";
                    conexion.EscribirPorComando(comandoInsertarUsuario);

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el usuario en la base de datos. Detalles: " + ex.Message, ex);
                }
            }

            public List<Cargo> ObtenerCargos()
            {
                List<Cargo> cargos = new List<Cargo>();

                try
                {
                    string query = "SELECT IdCargo, Nombre FROM Cargo";
                    DataTable tablaCargos = conexion.LeerPorComando(query);
                    foreach (DataRow row in tablaCargos.Rows)
                    {
                        int idCargo = Convert.ToInt32(row["IdCargo"]);
                        string nombreCargo = row["Nombre"].ToString();

                        Cargo cargo;
                        switch (nombreCargo)
                        {
                            case "Administrador":
                                cargo = new Administrador { IdCargo = idCargo, Nombre = nombreCargo };
                                break;
                            case "Cajero":
                                cargo = new Cajero { IdCargo = idCargo, Nombre = nombreCargo };
                                break;
                            case "Encargado de Depósito":
                                cargo = new EncargadoDeposito { IdCargo = idCargo, Nombre = nombreCargo };
                                break;
                            case "Gerente":
                                cargo = new Gerente { IdCargo = idCargo, Nombre = nombreCargo };
                                break;
                            case "Vendedor":
                                cargo = new Vendedor { IdCargo = idCargo, Nombre = nombreCargo };
                                break;
                            default:
                                throw new Exception($"Tipo de cargo desconocido: {nombreCargo}");
                        }

                        cargos.Add(cargo);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los cargos. Detalles: " + ex.Message, ex);
                }

                return cargos;
            }      
     
        public void EditarUsuario(UsuarioBE usuario)
        {
            // Actualizar tabla Usuario
            string comandoUsuario = "UPDATE Usuario SET NombreUsuario = @NombreUsuario, Clave = @Clave WHERE IdUsuario = @IdUsuario";
            SqlParameter[] parametrosUsuario = new SqlParameter[]
            {
                conexion.crearParametro("@IdUsuario", usuario.IdUsuario),
                conexion.crearParametro("@NombreUsuario", usuario.NombreUsuario),
                conexion.crearParametro("@Clave", usuario.Clave)
            };
            conexion.EscribirPorComando(comandoUsuario, parametrosUsuario);

            // Actualizar tabla Empleado
            string comandoEmpleado = "UPDATE Empleado SET Nombre = @Nombre, Apellido = @Apellido, CorreoElectronico = @CorreoElectronico, IdCargo = @IdCargo WHERE IdEmpleado = @IdEmpleado";
            SqlParameter[] parametrosEmpleado = new SqlParameter[]
            {
                conexion.crearParametro("@IdEmpleado", usuario.Empleado.IdEmpleado),
                conexion.crearParametro("@Nombre", usuario.Empleado.Nombre),
                conexion.crearParametro("@Apellido", usuario.Empleado.Apellido),
                conexion.crearParametro("@CorreoElectronico", usuario.Empleado.Correo),
                conexion.crearParametro("@IdCargo", usuario.Empleado.Cargo.IdCargo)
            };
            conexion.EscribirPorComando(comandoEmpleado, parametrosEmpleado);

            // Actualizar tabla Direccion
            string comandoDireccion = "UPDATE Direccion SET NombreCalle = @NombreCalle, NumeroCalle = @NumeroCalle, IdLocalidad = @IdLocalidad WHERE IdDireccion = @IdDireccion";
            SqlParameter[] parametrosDireccion = new SqlParameter[]
            {
                conexion.crearParametro("@IdDireccion", usuario.Empleado.Direccion.IdDireccion),
                conexion.crearParametro("@NombreCalle", usuario.Empleado.Direccion.NombreCalle),
                conexion.crearParametro("@NumeroCalle", usuario.Empleado.Direccion.NumeroCalle),
                conexion.crearParametro("@IdLocalidad", usuario.Empleado.Direccion.Localidad.IdLocalidad)
            };
            conexion.EscribirPorComando(comandoDireccion, parametrosDireccion);

            // Actualizar tabla Localidad
            string comandoLocalidad = "UPDATE Localidad SET NombreLocalidad = @NombreLocalidad, CodigoPostal = @CodigoPostal WHERE IdLocalidad = @IdLocalidad";
            SqlParameter[] parametrosLocalidad = new SqlParameter[]
            {
                conexion.crearParametro("@IdLocalidad", usuario.Empleado.Direccion.Localidad.IdLocalidad),
                conexion.crearParametro("@NombreLocalidad", usuario.Empleado.Direccion.Localidad.NombreLocalidad),
                conexion.crearParametro("@CodigoPostal", usuario.Empleado.Direccion.Localidad.CodigoPostal)
            };
            conexion.EscribirPorComando(comandoLocalidad, parametrosLocalidad);
        }

        public void EliminarUsuario(int idUsuario)
        {
            string comando = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@IdUsuario", idUsuario)
            };
            conexion.EscribirPorComando(comando, parametros);
        }

        public UsuarioBE BuscarUsuario(int idUsuario)
        {
            string comando = "SELECT * FROM Usuario WHERE IdUsuario = @IdUsuario";
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@IdUsuario", idUsuario)
            };
            DataTable tabla = conexion.LeerPorComando(comando, parametros);
            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                int idEmpleado = Convert.ToInt32(fila["IdEmpleado"]);

                EmpleadoBE empleado = BuscarEmpleado(idEmpleado);

                return new UsuarioBE
                {
                    IdUsuario = Convert.ToInt32(fila["IdUsuario"]),
                    NombreUsuario = fila["NombreUsuario"].ToString(),
                    Clave = fila["Clave"].ToString(),
                    Empleado = empleado
                };
            }
            return null;
        }

        private EmpleadoBE BuscarEmpleado(int idEmpleado)
        {
            string comando = "SELECT * FROM Empleado WHERE IdEmpleado = @IdEmpleado";
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@IdEmpleado", idEmpleado)
            };
            DataTable tabla = conexion.LeerPorComando(comando, parametros);
            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                int idDireccion = Convert.ToInt32(fila["IdDireccion"]);

                DireccionBE direccion = BuscarDireccion(idDireccion);
                int idCargo = Convert.ToInt32(fila["IdCargo"]);
                Cargo cargo;
                switch (idCargo)
                {
                    case 1:
                        cargo = new Gerente { IdCargo = idCargo, Nombre = "Gerente" };
                        break;
                    case 2:
                        cargo = new Administrador { IdCargo = idCargo, Nombre = "Administrador" };
                        break;
                    case 3:
                        cargo = new Cajero { IdCargo = idCargo, Nombre = "Cajero" };
                        break;
                    case 4:
                        cargo = new EncargadoDeposito { IdCargo = idCargo, Nombre = "Encargado de Depósito" };
                        break;
                    case 5:
                        cargo = new Vendedor { IdCargo = idCargo, Nombre = "Vendedor" };
                        break;
                    default:
                        throw new ArgumentException("IdCargo no válido");
                }

                return new EmpleadoBE
                {
                    IdEmpleado = Convert.ToInt32(fila["IdEmpleado"]),
                    Nombre = fila["Nombre"].ToString(),
                    Apellido = fila["Apellido"].ToString(),
                    Correo = fila["CorreoElectronico"].ToString(),
                    Direccion = direccion,
                    Cargo = cargo,
                };
            }
            return null;
        }

        private DireccionBE BuscarDireccion(int idDireccion)
        {
            string comando = "SELECT * FROM Direccion WHERE IdDireccion = @IdDireccion";
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@IdDireccion", idDireccion)
            };
            DataTable tabla = conexion.LeerPorComando(comando, parametros);
            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                int idLocalidad = Convert.ToInt32(fila["IdLocalidad"]);

                LocalidadBE localidad = BuscarLocalidad(idLocalidad);

                return new DireccionBE
                {
                    IdDireccion = Convert.ToInt32(fila["IdDireccion"]),
                    NombreCalle = fila["NombreCalle"].ToString(),
                    NumeroCalle = Convert.ToInt32(fila["NumeroCalle"]),
                    Localidad = localidad
                };
            }
            return null;
        }

        private LocalidadBE BuscarLocalidad(int idLocalidad)
        {
            string comando = "SELECT * FROM Localidad WHERE IdLocalidad = @IdLocalidad";
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@IdLocalidad", idLocalidad)
            };
            DataTable tabla = conexion.LeerPorComando(comando, parametros);
            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                return new LocalidadBE
                {
                    IdLocalidad = Convert.ToInt32(fila["IdLocalidad"]),
                    NombreLocalidad = fila["NombreLocalidad"].ToString(),
                    CodigoPostal = fila["CodigoPostal"].ToString()
                };
            }
            return null;
        }
        public UsuarioBE ObtenerUsuarioPorId(int idUsuario)
        {
            string comando = "SELECT * FROM Usuario WHERE IdUsuario = @IdUsuario";
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@IdUsuario", idUsuario)
            };
            DataTable tabla = conexion.LeerPorComando(comando, parametros);
            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                int idEmpleado = Convert.ToInt32(fila["IdEmpleado"]);

                EmpleadoBE empleado = BuscarEmpleado(idEmpleado);

                return new UsuarioBE
                {
                    IdUsuario = Convert.ToInt32(fila["IdUsuario"]),
                    NombreUsuario = fila["NombreUsuario"].ToString(),
                    Clave = fila["Clave"].ToString(),
                    Empleado = empleado
                };
            }
            return null;
        }
        public List<UsuarioBE> BuscarUsuarios(string criterio)
        {
            string comando = "SELECT * FROM Usuario WHERE NombreUsuario LIKE @Criterio OR NombreUsuario LIKE @Criterio";
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@Criterio", "%" + criterio + "%")
            };
            DataTable tabla = conexion.LeerPorComando(comando, parametros);
            List<UsuarioBE> usuarios = new List<UsuarioBE>();

            foreach (DataRow fila in tabla.Rows)
            {
                int idEmpleado = Convert.ToInt32(fila["IdEmpleado"]);
                EmpleadoBE empleado = BuscarEmpleado(idEmpleado);

                usuarios.Add(new UsuarioBE
                {
                    IdUsuario = Convert.ToInt32(fila["IdUsuario"]),
                    NombreUsuario = fila["NombreUsuario"].ToString(),
                    Clave = fila["Clave"].ToString(),
                    Empleado = empleado
                });
            }

            return usuarios;
        }
    }
}