using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConexionBase
    {
        private SqlConnection _conexion;
        public SqlConnection DBConexion { get { return _conexion; } }
        public void Conectar()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UIDeportes.Properties.Settings.CadenaConexion"].ConnectionString;

            _conexion = new SqlConnection(connectionString);

            _conexion.Open();
        }

        public void Desconectar()
        {
            if (_conexion != null)
            {
                if (_conexion.State != ConnectionState.Closed)
                {
                    _conexion.Close();
                }
                _conexion.Dispose();
            }
        }
    }
}
