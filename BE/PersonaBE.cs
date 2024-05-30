using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class PersonaBE
    {
        #region Atributos
        private int _dni;
        private string _nombre;
        private string _apellido;
        private string _correo;
        private DireccionBE _direccion;
        #endregion

        #region Propiedades
        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        public DireccionBE Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        #endregion

        #region Constructores
        public PersonaBE() { }

        public PersonaBE(int dni, string nombre, string apellido, string correo, DireccionBE direccion)
        {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
            _correo = correo;
            _direccion = direccion;
        }
        #endregion
    }
}

