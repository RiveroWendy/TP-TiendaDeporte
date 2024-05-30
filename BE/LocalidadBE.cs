using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class LocalidadBE
    {
        #region Atributos
        private int _idLocalidad;
        private string _nombreLocalidad;
        private string _codigoPostal;
        #endregion

        #region Propiedades
        public int IdLocalidad
        {
            get { return _idLocalidad; }
            set { _idLocalidad = value; }
        }

        public string NombreLocalidad
        {
            get { return _nombreLocalidad; }
            set { _nombreLocalidad = value; }
        }

        public string CodigoPostal
        {
            get { return _codigoPostal; }
            set { _codigoPostal = value; }
        }
        #endregion

        #region Constructores
        public LocalidadBE() { }

        public LocalidadBE(int idLocalidad, string nombreLocalidad, string codigoPostal)
        {
            _idLocalidad = idLocalidad;
            _nombreLocalidad = nombreLocalidad;
            _codigoPostal = codigoPostal;
        }
        #endregion
    }
}
