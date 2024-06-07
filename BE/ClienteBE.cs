using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ClienteBE : PersonaBE
    {
        public int IdCliente { get; set; } 

        public ClienteBE() { }

        public ClienteBE(int idCliente, int dni, string nombre, string apellido, string correo, DireccionBE direccion)
            : base(dni, nombre, apellido, correo, direccion)
        {
            IdCliente = idCliente;
        }
    }
}