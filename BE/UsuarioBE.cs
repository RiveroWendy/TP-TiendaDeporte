using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UsuarioBE
    {
        #region Atributos
        private int _idUsuario;
        private EmpleadoBE _empleado;
        private string _nombreUsuario;
        private string _clave;
        #endregion

        public UsuarioBE()
        {
            _empleado = new EmpleadoBE();
        }

        #region Propiedades
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public EmpleadoBE Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }
        #endregion
    }
}

