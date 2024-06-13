using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class ManejadorDeSesion
    {
        private static ManejadorDeSesion _instancia;
        private UsuarioBE _sesion;

        private ManejadorDeSesion() { }

        public static ManejadorDeSesion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ManejadorDeSesion();
                }
                return _instancia;
            }
        }

        public UsuarioBE Sesion
        {
            get { return _sesion; }
            set { _sesion = value; }
        }

        public void LogIn(UsuarioBE usuario)
        {
            _sesion = usuario;
        }

        public void LogOut()
        {
            _sesion = null;
        }

        public bool IsLogged()
        {
            return _sesion != null;
        }
    }
}
