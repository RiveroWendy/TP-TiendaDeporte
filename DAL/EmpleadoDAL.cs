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
    public class EmpleadoDAL
    {
        private ManejadorStoreProcedure _storeProcedure;
        private DireccionDAL _direccion;
        private CargoDAL _cargo;

        public EmpleadoDAL()
        {
            _storeProcedure = new ManejadorStoreProcedure();
            _direccion = new DireccionDAL();
            _cargo = new CargoDAL();
        }

        public EmpleadoBE ObtenerEmpleadoPorId(int idEmpleado)
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
                    Direccion = _direccion.ObtenerDireccionPorId(Convert.ToInt32(row["IdDireccion"])),
                    CargoEmpleado = _cargo.ObtenerCargoPorId(Convert.ToInt32(row["IdCargo"]))
                };

                return empleado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
