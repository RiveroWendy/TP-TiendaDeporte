using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManejadorStoreProcedure
    {
        private ConexionBase _conexion;

        public ManejadorStoreProcedure()
        {
            _conexion = new ConexionBase();
        }

        public DataTable LeerPorStoreProcedure(string pNombreStoreProcedure, SqlParameter[] pParametrosSql = null)
        {
            DataTable dt = new DataTable();
            SqlCommand comando = null;

            try
            {
                _conexion.Conectar();
                comando = new SqlCommand(pNombreStoreProcedure, _conexion.DBConexion);
                comando.CommandType = CommandType.StoredProcedure;

                if (pParametrosSql != null && pParametrosSql.Length > 0)
                {
                    comando.Parameters.AddRange(pParametrosSql);
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                _conexion.DBConexion?.Close();
                throw new Exception("Error al ejecutar el procedimiento almacenado.", ex);
            }
            finally
            {
                comando?.Dispose();
                _conexion.Desconectar();
            }

            return dt;
        }

        public int EscribirPorStoreProcedure(string pNombreStoreProcedure, SqlParameter[] pParametrosSql = null, SqlTransaction transaction = null)
        {
            SqlCommand comando = null;
            int filasAfectadas = 0;

            try
            {
                if (transaction != null)
                {
                    comando = new SqlCommand(pNombreStoreProcedure, transaction.Connection, transaction);
                }
                else
                {
                    _conexion.Conectar();
                    comando = new SqlCommand(pNombreStoreProcedure, _conexion.DBConexion);
                }

                comando.CommandType = CommandType.StoredProcedure;

                if (pParametrosSql != null && pParametrosSql.Length > 0)
                {
                    comando.Parameters.AddRange(pParametrosSql);
                }

                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (transaction == null)
                {
                    _conexion.DBConexion?.Close();                    
                }
                filasAfectadas = -1;
                throw new Exception("Error al ejecutar el procedimiento almacenado.", ex);
            }
            finally
            {
                if (transaction == null)
                {
                    comando?.Dispose();
                    _conexion.Desconectar();                    
                }
            }

            return filasAfectadas;
        }
    }
}
