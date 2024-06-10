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
    public class CargoDAL
    {
        private ManejadorStoreProcedure _storeProcedure;

        public CargoDAL()
        {
            _storeProcedure = new ManejadorStoreProcedure();
        }

        public Cargo ObtenerCargoPorId(int idCargo)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdCargo", idCargo)
                };

                DataTable dt = _storeProcedure.LeerPorStoreProcedure("sp_cargo_por_id", parametros);
                DataRow row = dt.Rows[0];

                Cargo cargo = CrearCargo(Convert.ToInt32(row["IdCargo"]), row["Nombre"].ToString());

                return cargo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Cargo> ObtenerCargos()
        {
            DataTable dt = _storeProcedure.LeerPorStoreProcedure("sp_obtener_cargos");

            List<Cargo> cargos = new List<Cargo>();

            foreach (DataRow row in dt.Rows)
            {
                Cargo cargo = CrearCargo(Convert.ToInt32(row["IdCargo"]), row["Nombre"].ToString());
                cargos.Add(cargo);
            }

            return cargos;
        }

        private Cargo CrearCargo(int idCargo, string nombreCargo)
        {
            try
            {
                Cargo cargo;

                // Dependiendo del nombre del cargo, creamos una instancia del tipo correspondiente
                switch (nombreCargo)
                {
                    case "Administrador":
                        return cargo = new Administrador { IdCargo = idCargo, Nombre = nombreCargo };
                    case "Cajero":
                        return cargo = new Cajero { IdCargo = idCargo, Nombre = nombreCargo };
                    case "Encargado de Depósito":
                        return cargo = new EncargadoDeposito { IdCargo = idCargo, Nombre = nombreCargo };
                    case "Gerente":
                        return cargo = new Gerente { IdCargo = idCargo, Nombre = nombreCargo };
                    case "Vendedor":
                        return cargo = new Vendedor { IdCargo = idCargo, Nombre = nombreCargo };
                    default:
                        throw new Exception($"Tipo de cargo desconocido: {nombreCargo}");
                }
            }
            catch (Exception ex)
            {
                // En caso de excepción, lanzamos un error con un mensaje detallado
                throw new Exception("Error al obtener el cargo. Detalles: " + ex.Message, ex);
            }
        }
    }
}
