using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class ClienteBLL
    {
        private ClienteDAL clienteDAL;

        public ClienteBLL()
        {
            clienteDAL = new ClienteDAL();
        }

        public void CrearCliente(ClienteBE cliente)
        {
            try
            {
                // Validaciones adicionales si es necesario
                clienteDAL.CrearCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el cliente. Detalles: " + ex.Message, ex);
            }
        }

        public ClienteBE BuscarClientePorDNI(int dni)
        {
            return clienteDAL.BuscarClientePorDNI(dni);
        }

        public void ActualizarCliente(ClienteBE cliente)
        {
            try
            {
                // Llamar al método de la capa DAL para actualizar el cliente
                clienteDAL.ActualizarCliente(cliente);
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la actualización
                throw new Exception("Error al actualizar el cliente.", ex);
            }
        }
   
    }
}