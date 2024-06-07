using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class VentaBLL
    {
        private VentaDAL _ventaDAL;

        public VentaBLL()
        {
            _ventaDAL = new VentaDAL();
        }

        private void ValidarVenta(VentaBE venta)
        {
            if (venta == null)
            {
                throw new ArgumentNullException(nameof(venta));
            }

            if (venta.FechaVenta > DateTime.Now)
            {
                throw new InvalidOperationException("La fecha de la venta no puede ser en el futuro.");
            }

            if (venta.DetalleVentas == null || !venta.DetalleVentas.Any())
            {
                throw new InvalidOperationException("La venta debe tener al menos un detalle de venta.");
            }
        }

        public void GenerarVenta(VentaBE venta)
        {
            ValidarVenta(venta);
        }

        public void BuscarVenta()
        {

        }

        public void VisualizarVenta()
        {

        }

        public void EmitirOrdenVenta()
        {

        }

        public void ModificarVenta()
        {

        }


    }
}
