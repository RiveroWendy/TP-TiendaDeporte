using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bll
{
    public class Login
    {
		private string usuario;
		private string clave;

        public Login(string _user, string _clave)
        {
			this.usuario = _user;
			this.clave = _clave;
        }

        public bool iniciarSesion()
		{

			Conexion objConexion = new Conexion();

			//LEO LA TABLA DE LA BASE DE DATOS

			DataTable dt = objConexion.LeerPorComando("select rtrim([nombreUsuario]),rtrim([contrasenia]) from  [Ejercicio_1].[dbo].[Usuario]");


			//RECORRE TODAS LAS FILAS
			foreach (DataRow fila in dt.Rows) {
				
				if (fila[0].ToString() == this.usuario && fila[1].ToString() == this.clave)
				{
					return true;
				}
			}

			return false;
			
		}

	}
}
