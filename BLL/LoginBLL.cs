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

        public bool Login(string nombreUsuario, string clave)
        {
            // Llamamos al método Login de la capa DAL
            return loginDAL.VerificarCredenciales(nombreUsuario, clave);
        }

        public string ObtenerCargo(string nombreUsuario)
        {
            // Llamamos al método ObtenerCargoUsuario de la capa DAL
            return loginDAL.ObtenerCargoUsuario(nombreUsuario);
        }
    }
}

