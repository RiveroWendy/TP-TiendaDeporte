using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Cargo
    {
        #region Atributos
        private int _idCargo;
        private string _nombre;
        #endregion

        #region Propiedades
        public int IdCargo
        {
            get { return _idCargo; }
            set { _idCargo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        #endregion
    }
}
