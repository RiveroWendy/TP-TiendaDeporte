using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Stock
    {
        private int _idProducto;

        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public Stock() { }
    }
}
