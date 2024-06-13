using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DAL;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        private LoginDAL loginDAL = new LoginDAL();
        private LoginDAL _login;

        public LoginBLL()
        {
            _login = new LoginDAL();
        }

        public bool Login1(string nombreUsuario, string clave)
        {
            // Llamamos al método Login de la capa DAL
            return loginDAL.VerificarCredenciales(nombreUsuario, clave);
        }

        public string ObtenerCargo(string nombreUsuario)
        {
            // Llamamos al método ObtenerCargoUsuario de la capa DAL
            return loginDAL.ObtenerCargoUsuario(nombreUsuario);
        }

        public void Login(string username, string password)
        {
            if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("El nombre de usuario y la contraseña no pueden estar vacíos.");
            }

            try
            {
                UsuarioBE usuario = _login.ValidarUsuario(username, password);

                if (usuario == null) throw new Exception("Usuario o contraseña incorrecta");

                ManejadorDeSesion.Instancia.LogIn(usuario);

            }
            catch
            {
                throw;
            }

        }

        public void LogOut()
        {
            ManejadorDeSesion.Instancia.LogOut();
        }

    }
}

