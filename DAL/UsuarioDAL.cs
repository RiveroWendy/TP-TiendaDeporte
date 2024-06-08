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

        public UsuarioBE BuscarUsuarioPorDni(int dni)
        {
            // Creamos la consulta SQL que selecciona los datos del usuario, empleado, dirección, localidad y cargo
            string comando = $"SELECT u.IdUsuario, u.NombreUsuario, u.Clave, e.IdEmpleado, e.Nombre, e.Apellido, e.Dni, e.CorreoElectronico, d.IdDireccion, d.NombreCalle, d.NumeroCalle, l.IdLocalidad, l.NombreLocalidad, l.CodigoPostal, c.IdCargo, c.Nombre AS NombreCargo " +
                          $"FROM Usuario u " +
                          $"LEFT JOIN Empleado e ON u.IdEmpleado = e.IdEmpleado " +
                          $"JOIN Direccion d ON e.IdDireccion = d.IdDireccion " +
                          $"JOIN Localidad l ON d.IdLocalidad = l.IdLocalidad " +
                          $"JOIN Cargo c ON e.IdCargo = c.IdCargo " +
                          $"WHERE e.Dni = {dni}";
   
            // Ejecutamos el comando y obtenemos los resultados en un DataTable
            DataTable tabla = conexion.LeerPorComando(comando);

            // Ejecutamos el comando y obtenemos los resultados en un DataTable
            DataTable tabla = conexion.LeerPorComando(comando);

            // Si encontramos al menos una fila, procedemos a procesar los datos
            if (tabla.Rows.Count > 0)
        {
                 DataRow fila = tabla.Rows[0];

                 Cargo cargo;
                 string nombreCargo = fila["NombreCargo"].ToString();
                 int idCargo = Convert.ToInt32(fila["IdCargo"]);

                // Dependiendo del nombre del cargo, creamos una instancia del tipo correspondiente
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
                // Creamos y retornamos una instancia de UsuarioBE con todos los datos obtenidos y procesados
                return new UsuarioBE
                {
                    IdUsuario = Convert.ToInt32(fila["IdUsuario"]),
                    NombreUsuario = fila["NombreUsuario"].ToString(),
                    Clave = fila["Clave"].ToString(),
                    Empleado = new EmpleadoBE
                    {
                        IdEmpleado = Convert.ToInt32(fila["IdEmpleado"]),
                        Dni = Convert.ToInt32(fila["Dni"]),  // Aquí convertimos el valor a int
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
                        Cargo = cargo
                    }
                };
            }
       
        return null;
        }
        // Si no encontramos ninguna fila, retornamos null
        return null;
     }

        public void ActualizarUsuario(UsuarioBE usuario)
        {
            // Creamos la consulta SQL que actualiza los datos de localidad, dirección, usuario y empleado
            string comando =
                "UPDATE Localidad SET NombreLocalidad = @NombreLocalidad, CodigoPostal = @CodigoPostal WHERE IdLocalidad = @IdLocalidad; " +
                "UPDATE Direccion SET NombreCalle = @NombreCalle, NumeroCalle = @NumeroCalle WHERE IdDireccion = @IdDireccion; " +
                "UPDATE Usuario SET NombreUsuario = @NombreUsuario, Clave = @Clave WHERE IdUsuario = @IdUsuario; " +
                "UPDATE Empleado SET Nombre = @Nombre, Apellido = @Apellido, Dni = @Dni, CorreoElectronico = @CorreoElectronico, IdCargo = @IdCargo WHERE IdEmpleado = @IdEmpleado;";

            // Creamos los parámetros necesarios para la consulta
            SqlParameter[] parametros = new SqlParameter[]
            {
                conexion.crearParametro("@NombreLocalidad", usuario.Empleado.Direccion.Localidad.NombreLocalidad),
                conexion.crearParametro("@CodigoPostal", usuario.Empleado.Direccion.Localidad.CodigoPostal),
                conexion.crearParametro("@IdLocalidad", usuario.Empleado.Direccion.Localidad.IdLocalidad),
                conexion.crearParametro("@NombreCalle", usuario.Empleado.Direccion.NombreCalle),
                conexion.crearParametro("@NumeroCalle", usuario.Empleado.Direccion.NumeroCalle),
                conexion.crearParametro("@IdDireccion", usuario.Empleado.Direccion.IdDireccion),
                conexion.crearParametro("@NombreUsuario", usuario.NombreUsuario),
                conexion.crearParametro("@Clave", usuario.Clave),
                conexion.crearParametro("@IdUsuario", usuario.IdUsuario),
                conexion.crearParametro("@Nombre", usuario.Empleado.Nombre),
                conexion.crearParametro("@Apellido", usuario.Empleado.Apellido),
                conexion.crearParametro("@Dni", usuario.Empleado.Dni),
                conexion.crearParametro("@CorreoElectronico", usuario.Empleado.Correo),
                conexion.crearParametro("@IdCargo", usuario.Empleado.Cargo.IdCargo),
                conexion.crearParametro("@IdEmpleado", usuario.Empleado.IdEmpleado)
            };
            // Ejecutamos el comando con los parámetros creados
            conexion.EscribirPorComando1(comando, parametros);
           
        }

        public void CrearUsuario(UsuarioBE usuario)
            {
                try
                {
                // Verificamos que el objeto usuario no sea nulo
                if (usuario == null)
                    {
                        throw new ArgumentNullException(nameof(usuario), "El objeto usuario no puede ser nulo.");
                    }
                        // Verificamos que el objeto Empleado del usuario no sea nulo
                        if (usuario.Empleado == null)
                            {
                                throw new ArgumentNullException(nameof(usuario.Empleado), "El objeto Empleado en el usuario no puede ser nulo.");
                            }

                Cargo cargo = usuario.Empleado.Cargo;

                // Verificamos que el cargo del empleado no sea nulo
                if (cargo == null)
                    {
                        throw new ArgumentNullException(nameof(cargo), "El cargo del empleado no puede ser nulo.");
                    }

                    // Insertamos la localidad y obtenemos el Id generado
                    string comandoInsertarLocalidad = $"INSERT INTO Localidad (NombreLocalidad, CodigoPostal) VALUES ('{usuario.Empleado.Direccion.Localidad.NombreLocalidad}', '{usuario.Empleado.Direccion.Localidad.CodigoPostal}'); SELECT SCOPE_IDENTITY();";
                    int idLocalidad = Convert.ToInt32(conexion.EscribirPorComando(comandoInsertarLocalidad));

                    // Insertamos la dirección y obtenemos el Id generado
                    string comandoInsertarDireccion = $"INSERT INTO Direccion (NombreCalle, NumeroCalle, IdLocalidad) VALUES ('{usuario.Empleado.Direccion.NombreCalle}', {usuario.Empleado.Direccion.NumeroCalle}, {idLocalidad}); SELECT SCOPE_IDENTITY();";
                    int idDireccion = Convert.ToInt32(conexion.EscribirPorComando(comandoInsertarDireccion));

                    // Insertamos el empleado y obtenemos el Id generado
                    string comandoInsertarEmpleado = $"INSERT INTO Empleado (Nombre, Apellido, Dni, CorreoElectronico, IdDireccion, IdCargo) VALUES ('{usuario.Empleado.Nombre}', '{usuario.Empleado.Apellido}', {usuario.Empleado.Dni}, '{usuario.Empleado.Correo}', {idDireccion}, {usuario.Empleado.Cargo.IdCargo}); SELECT SCOPE_IDENTITY();";
                    int idEmpleado = Convert.ToInt32(conexion.EscribirPorComando(comandoInsertarEmpleado));

                    // Insertamos el usuario
                    string comandoInsertarUsuario = $"INSERT INTO Usuario (IdEmpleado, NombreUsuario, Clave) VALUES ({idEmpleado}, '{usuario.NombreUsuario}', '{usuario.Clave}')";
                    conexion.EscribirPorComando(comandoInsertarUsuario);

                }
                catch (Exception ex)
                {
                    // En caso de excepción, lanzamos un error con un mensaje detallado
                    throw new Exception("Error al crear el usuario en la base de datos. Detalles: " + ex.Message, ex);
                }
            }

        public List<Cargo> ObtenerCargos()
            {
            // Creamos una lista para almacenar los cargos
            List<Cargo> cargos = new List<Cargo>();

                try
                {
                    // Definimos la consulta SQL para obtener los cargos
                    string query = "SELECT IdCargo, Nombre FROM Cargo";
                    DataTable tablaCargos = conexion.LeerPorComando(query);

                    // Recorremos cada fila del DataTable
                    foreach (DataRow row in tablaCargos.Rows)
                    {
                        // Obtenemos los datos de la fila
                        int idCargo = Convert.ToInt32(row["IdCargo"]);
                        string nombreCargo = row["Nombre"].ToString();

                        Cargo cargo;

                        // Dependiendo del nombre del cargo, creamos una instancia del tipo correspondiente
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

                        // Añadimos el cargo a la lista
                        cargos.Add(cargo);
                    }
                }
                catch (Exception ex)
                {
                    // En caso de excepción, lanzamos un error con un mensaje detallado
                    throw new Exception("Error al obtener los cargos. Detalles: " + ex.Message, ex);
                }
                // Retornamos la lista de cargos
                return cargos;
            }          
    }
}