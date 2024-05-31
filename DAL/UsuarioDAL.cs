﻿using System;
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

        public UsuarioBE BuscarUsuarioPorDni(int dni)
        {
         string comando = $"SELECT u.IdUsuario, u.NombreUsuario, u.Clave, e.IdEmpleado, e.Nombre, e.Apellido, e.Dni, e.CorreoElectronico, d.IdDireccion, d.NombreCalle, d.NumeroCalle, l.IdLocalidad, l.NombreLocalidad, l.CodigoPostal, c.IdCargo, c.Nombre AS NombreCargo " +
                          $"FROM Usuario u " +
                          $"JOIN Empleado e ON u.IdEmpleado = e.IdEmpleado " +
                          $"JOIN Direccion d ON e.IdDireccion = d.IdDireccion " +
                          $"JOIN Localidad l ON d.IdLocalidad = l.IdLocalidad " +
                          $"JOIN Cargo c ON e.IdCargo = c.IdCargo " +
                          $"WHERE e.Dni = {dni}";

         DataTable tabla = conexion.LeerPorComando(comando);

         if (tabla.Rows.Count > 0)
        {
             DataRow fila = tabla.Rows[0];

             Cargo cargo;
             string nombreCargo = fila["NombreCargo"].ToString();
             int idCargo = Convert.ToInt32(fila["IdCargo"]);

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

        public void ActualizarUsuario(UsuarioBE usuario)
        {
            string comando =
                "UPDATE Localidad SET NombreLocalidad = @NombreLocalidad, CodigoPostal = @CodigoPostal WHERE IdLocalidad = @IdLocalidad; " +
                "UPDATE Direccion SET NombreCalle = @NombreCalle, NumeroCalle = @NumeroCalle WHERE IdDireccion = @IdDireccion; " +
                "UPDATE Usuario SET NombreUsuario = @NombreUsuario, Clave = @Clave WHERE IdUsuario = @IdUsuario; " +
                "UPDATE Empleado SET Nombre = @Nombre, Apellido = @Apellido, Dni = @Dni, CorreoElectronico = @CorreoElectronico, IdCargo = @IdCargo WHERE IdEmpleado = @IdEmpleado;";

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

            conexion.EscribirPorComando1(comando, parametros);
           
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
    }
}