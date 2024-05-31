using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Proveedor
    {
        private int _idProveedor;

        public int IdProveedor
        {
            get { return _idProveedor; }
            set { _idProveedor = value; }
        }

        private string _nombreEmpresa;

        public string NombreEmpresa
        {
            get { return _nombreEmpresa; }
            set { _nombreEmpresa = value; }
        }

        private long _telefono;

        public long Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _correo;

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        public Proveedor() { }
    }
}
