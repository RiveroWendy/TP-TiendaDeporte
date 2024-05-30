using System;
using System.Collections.Generic;
using System.Linq;
using BE;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class EmpleadoBE : PersonaBE
    {
        #region Atributos
        private int _idEmpleado;
        private Cargo _cargo;
        #endregion

        #region Propiedades
        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        public Cargo Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }
        #endregion

        #region Constructores
        public EmpleadoBE() { }

        public EmpleadoBE(int dni, string nombre, string apellido, string correo, DireccionBE direccion, int IdEmpleado, Cargo cargo)
            : base(dni, nombre, apellido, correo, direccion)
        {
            _idEmpleado = IdEmpleado;
            _cargo = cargo;
        }
        #endregion
    }
}

