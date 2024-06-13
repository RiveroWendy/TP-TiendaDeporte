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
        private ManejadorStoreProcedure _storeProcedure;
        private CargoDAL _cargo;
        private DireccionDAL _direccion;
        private EmpleadoDAL _empleado;

        public LoginDAL()
        {
            _storeProcedure = new ManejadorStoreProcedure();
            _cargo = new CargoDAL();
            _direccion = new DireccionDAL();
            _empleado = new EmpleadoDAL();
        }

        public bool VerificarCredenciales(string nombreUsuario, string clave)
        {
            // Creamos una tabla de datos que contiene todos los usuarios obtenidos de la base de datos.
            DataTable tablaUsuarios = conexion.LeerPorComando("SELECT * FROM Usuario");

            // Iteramos sobre cada fila en la tabla de usuarios.
            foreach (DataRow fila in tablaUsuarios.Rows)
            {
                // Comparamos el nombre de usuario y la clave de la fila actual con los parámetros proporcionados.
                if (fila["NombreUsuario"].ToString() == nombreUsuario && fila["Clave"].ToString() == clave)
                {
                    return true;
                }
            }
            return false;
        }

        public string ObtenerCargoUsuario(string nombreUsuario)
        {
            // Creamos una tabla de datos que contiene los nombres de usuarios y sus respectivos cargos,
            // obtenidos mediante una consulta que une las tablas Usuario, Empleado y Cargo.
            DataTable tablaUsuarios = conexion.LeerPorComando("SELECT u.NombreUsuario, c.Nombre FROM Usuario u JOIN Empleado e ON u.IdEmpleado = e.IdEmpleado JOIN Cargo c ON e.IdCargo = c.IdCargo");

            // Iteramos sobre cada fila en la tabla de usuarios.
            foreach (DataRow fila in tablaUsuarios.Rows)
            {
                // Comparamos el nombre de usuario de la fila actual con el parámetro proporcionado.
                if (fila["NombreUsuario"].ToString() == nombreUsuario)
                {
                    return fila["Nombre"].ToString();
                }
            }
            return null;
        }


        public UsuarioBE ValidarUsuario(string nombreUsuario, string password)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@NombreUsuario", nombreUsuario),
                new SqlParameter("@Password", password)
            };

            DataTable dt = _storeProcedure.LeerPorStoreProcedure("sp_validar_credenciales_usuario", parametros);

            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = dt.Rows[0];

            UsuarioBE usuario = new UsuarioBE()
            {
                IdUsuario = (int)row["IdUsuario"],
                NombreUsuario = row["NombreUsuario"].ToString(),
                Empleado = _empleado.ObtenerEmpleadoPorId(Convert.ToInt32(row["IdEmpleado"]))
            };

            return usuario;
        }


    }
}