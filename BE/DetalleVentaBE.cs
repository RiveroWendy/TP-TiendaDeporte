using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleVentaBE
    {
        private int _idDetalleVenta;
        private ProductoBE _producto;
        private int _cantidad;
        private long _precioUnitario;

        public int IdDetalleVenta
        {
            get { return _idDetalleVenta; }
            set { _idDetalleVenta = value; }
        }

        public ProductoBE Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        public int CantidadDeVenta
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public long PrecioUnitario
        {
            get { return _precioUnitario; }
            set { _precioUnitario = value; }
        }
    }

}