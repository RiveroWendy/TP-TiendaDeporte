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

        public ClienteDAL()
        {
            conexion = new Conexion(); // Creamos una instancia de Conexion
        }

        public void CrearCliente(ClienteBE cliente)
        {
            try
            {
                // Insertamos la localidad y obtenemos el Id generado
                string comandoInsertarLocalidad = "INSERT INTO Localidad (NombreLocalidad, CodigoPostal) VALUES (@NombreLocalidad, @CodigoPostal); SELECT SCOPE_IDENTITY();";
                SqlParameter[] parametrosLocalidad = new SqlParameter[]
                    {
                        new SqlParameter("@NombreLocalidad", cliente.Direccion.Localidad.NombreLocalidad),
                        new SqlParameter("@CodigoPostal", cliente.Direccion.Localidad.CodigoPostal)
                    };
                int idLocalidad = Convert.ToInt32(conexion.EscribirPorComando(comandoInsertarLocalidad, parametrosLocalidad));

                // Insertamos la dirección y obtenemos el Id generado
                string comandoInsertarDireccion = "INSERT INTO Direccion (NombreCalle, NumeroCalle, IdLocalidad) VALUES (@NombreCalle, @NumeroCalle, @IdLocalidad); SELECT SCOPE_IDENTITY();";
                SqlParameter[] parametrosDireccion = new SqlParameter[]
                    {
                        new SqlParameter("@NombreCalle", cliente.Direccion.NombreCalle),
                        new SqlParameter("@NumeroCalle", cliente.Direccion.NumeroCalle),
                        new SqlParameter("@IdLocalidad", idLocalidad)
                    };
                int idDireccion = Convert.ToInt32(conexion.EscribirPorComando(comandoInsertarDireccion, parametrosDireccion));

                // Insertamos el cliente
                string comandoInsertarCliente = "INSERT INTO Cliente (Dni, Nombre, Apellido, CorreoElectronico, IdDireccion) VALUES (@Dni, @Nombre, @Apellido, @CorreoElectronico, @IdDireccion)";
                SqlParameter[] parametrosCliente = new SqlParameter[]
                    {
                        new SqlParameter("@Dni", cliente.Dni),
                        new SqlParameter("@Nombre", cliente.Nombre),
                        new SqlParameter("@Apellido", cliente.Apellido),
                        new SqlParameter("@CorreoElectronico", cliente.Correo),
                        new SqlParameter("@IdDireccion", idDireccion)
                    };
                conexion.EscribirPorComando(comandoInsertarCliente, parametrosCliente);


            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el cliente. Detalles: " + ex.Message, ex);
            }
        }

        public ClienteBE BuscarClientePorDNI(int dni)
        {
            // Creamos la consulta SQL que selecciona los datos del cliente y su dirección
            string comando = $"SELECT c.IdCliente, c.Dni, c.Nombre, c.Apellido, c.CorreoElectronico, d.IdDireccion, d.NombreCalle, d.NumeroCalle, l.IdLocalidad, l.NombreLocalidad, l.CodigoPostal " +
                             $"FROM Cliente c " +
                             $"JOIN Direccion d ON c.IdDireccion = d.IdDireccion " +
                             $"JOIN Localidad l ON d.IdLocalidad = l.IdLocalidad " +
                             $"WHERE c.Dni = {dni}";

            // Ejecutamos el comando y obtenemos los resultados en un DataTable
            DataTable tabla = conexion.LeerPorComando(comando);

            // Si encontramos al menos una fila, procedemos a procesar los datos
            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];

                // Creamos y retornamos una instancia de ClienteBE con todos los datos obtenidos y procesados
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

        public void ActualizarCliente(ClienteBE cliente)
        {
            try
            {
                // Creamos la consulta SQL que actualiza los datos de la localidad, la dirección y el cliente
                string comando =
                    "UPDATE Localidad SET NombreLocalidad = @NombreLocalidad, CodigoPostal = @CodigoPostal WHERE IdLocalidad = @IdLocalidad; " +
                    "UPDATE Direccion SET NombreCalle = @NombreCalle, NumeroCalle = @NumeroCalle WHERE IdDireccion = @IdDireccion; " +
                    "UPDATE Cliente SET Dni = @Dni, Nombre = @Nombre, Apellido = @Apellido, CorreoElectronico = @Correo WHERE IdCliente = @IdCliente;";

                // Creamos los parámetros necesarios para la consulta
                SqlParameter[] parametros = new SqlParameter[]
                        {
                            conexion.crearParametro("@NombreLocalidad", cliente.Direccion.Localidad.NombreLocalidad),
                            conexion.crearParametro("@CodigoPostal", cliente.Direccion.Localidad.CodigoPostal),
                            conexion.crearParametro("@IdLocalidad", cliente.Direccion.Localidad.IdLocalidad),
                            conexion.crearParametro("@NombreCalle", cliente.Direccion.NombreCalle),
                            conexion.crearParametro("@NumeroCalle", cliente.Direccion.NumeroCalle),
                            conexion.crearParametro("@IdDireccion", cliente.Direccion.IdDireccion),
                            conexion.crearParametro("@Dni", cliente.Dni),
                            conexion.crearParametro("@Nombre", cliente.Nombre),
                            conexion.crearParametro("@Apellido", cliente.Apellido),
                            conexion.crearParametro("@Correo", cliente.Correo),
                            conexion.crearParametro("@IdCliente", cliente.IdCliente)
                        };

                // Ejecutar la consulta
                int filasAfectadas = conexion.EscribirPorComando(comando, parametros);

                // Verificar si se actualizaron registros
                if (filasAfectadas <= 0)
                {
                    throw new Exception("No se pudo actualizar el cliente.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el cliente.", ex);
            }
        }
    }
}

