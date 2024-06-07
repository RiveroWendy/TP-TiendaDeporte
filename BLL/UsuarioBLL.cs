using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        public void CrearUsuario(UsuarioBE usuario)
        {
            try
            {
                if (usuario == null)
                {
                    throw new ArgumentNullException(nameof(usuario), "El usuario no puede ser nulo.");
                }

                usuarioDAL.CrearUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el usuario. Detalles: " + ex.Message, ex);
            }
        }

        public List<Cargo> ObtenerCargos() => usuarioDAL.ObtenerCargos();

        public void ActualizarUsuario(UsuarioBE usuario)
        {

            usuarioDAL.ActualizarUsuario(usuario);
        }


        public UsuarioBE BuscarUsuarioPorDni(int dni)
        {
            return usuarioDAL.BuscarUsuarioPorDni(dni);
        }

    }
}



