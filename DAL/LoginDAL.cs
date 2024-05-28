using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BE;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class LoginDAL
    {
        private Conexion conexion = new Conexion();

        public bool VerificarCredenciales(string nombreUsuario, string clave)
        {
            DataTable tablaUsuarios = conexion.LeerPorComando("SELECT * FROM Usuario");
            foreach (DataRow fila in tablaUsuarios.Rows)
            {
                if (fila["NombreUsuario"].ToString() == nombreUsuario && fila["Clave"].ToString() == clave)
                {
                    return true;
                }
            }
            return false;
        }

        public string ObtenerCargoUsuario(string nombreUsuario)
        {
            DataTable tablaUsuarios = conexion.LeerPorComando("SELECT u.NombreUsuario, c.Nombre FROM Usuario u JOIN Empleado e ON u.IdEmpleado = e.IdEmpleado JOIN Cargo c ON e.IdTipoEmpleado = c.IdCargo");

            foreach (DataRow fila in tablaUsuarios.Rows)
            {
                if (fila["NombreUsuario"].ToString() == nombreUsuario)
                {
                    return fila["Nombre"].ToString();
                }
            }
            return null;
        }
    }
}