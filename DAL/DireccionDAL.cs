using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class DireccionDAL
    {
        private ManejadorStoreProcedure _storeProcedure;

        public DireccionDAL()
        {
            _storeProcedure = new ManejadorStoreProcedure();
        }

        public DireccionBE ObtenerDireccionPorId(int idDireccion)
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

        public LocalidadBE ObtenerLocalidadPorId(int idLocalidad)
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
    }
}
