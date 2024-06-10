using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class VentaBE
    {
        private int _idVenta;
        private DateTime _fechaVenta;
        private EmpleadoBE _empleadoResponsable;
        private ClienteBE _clienteAsociado;
        private List<DetalleVentaBE> _detalleVentas;
        private long _totalVenta;

        public VentaBE()
        {
            _detalleVentas = new List<DetalleVentaBE>();
            _empleadoResponsable = new EmpleadoBE();
            _clienteAsociado = new ClienteBE();
        }

        public int IdVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }

        public DateTime FechaVenta
        {
            get { return _fechaVenta; }
            set { _fechaVenta = value; }
        }

        public EmpleadoBE EmpleadoResponsable
        {
            get { return _empleadoResponsable; }
            set { _empleadoResponsable = value; }
        }

        public ClienteBE ClienteAsociado
        {
            get { return _clienteAsociado; }
            set { _clienteAsociado = value; }
        }
        public List<DetalleVentaBE> DetalleVentas
        {
            get { return _detalleVentas; }
            set { _detalleVentas = value; }
        }

        public long TotalVenta
        {
            get { return _totalVenta; }
            set { _totalVenta = value; }
        }

    }
}
