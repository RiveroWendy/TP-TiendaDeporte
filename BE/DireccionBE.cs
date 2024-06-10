using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DireccionBE
    {
        #region Atributos
        private int _idDireccion;
        private string _nombreCalle;
        private int _numeroCalle;
        private LocalidadBE _localidad;
        #endregion

        #region Propiedades
        public int IdDireccion
        {
            get { return _idDireccion; }
            set { _idDireccion = value; }
        }

        public string NombreCalle
        {
            get { return _nombreCalle; }
            set { _nombreCalle = value; }
        }

        public int NumeroCalle
        {
            get { return _numeroCalle; }
            set { _numeroCalle = value; }
        }

        public LocalidadBE Localidad
        {
            get { return _localidad; }
            set { _localidad = value; }
        }
        #endregion

        #region Constructores
        public DireccionBE() { }

        public DireccionBE(int idDireccion, string nombreCalle, int numeroCalle, LocalidadBE localidad)
        {
            _idDireccion = idDireccion;
            _nombreCalle = nombreCalle;
            _numeroCalle = numeroCalle;
            _localidad = localidad;
        }
        #endregion
    }
}
