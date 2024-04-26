using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class Usuario
    {
        #region Atributos
        private string nombreUsuario;
        private string contrasenia;
        private string nombre;
        private string apellido;
        private int edad;
        #endregion

        #region Getters & Setters
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        #endregion

        public Usuario(string _nombreUsuario, string _contrasenia,string _nombre, string _apellido, int _edad)
        {
            this.nombreUsuario = _nombreUsuario;
            this.contrasenia = _contrasenia;
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.edad = _edad;
        }

    }
}
