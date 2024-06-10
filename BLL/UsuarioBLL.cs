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
        private UsuarioDAL _usuarioDAL;
        private CargoDAL _cargo;

        public UsuarioBLL()
        {
            _usuarioDAL = new UsuarioDAL();
        }

        public void CrearUsuario(UsuarioBE usuario)
        {
            try
            {
                if (usuario == null)
                {
                    throw new ArgumentNullException(nameof(usuario), "El usuario no puede ser nulo.");
                }

                _usuarioDAL.CrearUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el usuario. Detalles: " + ex.Message, ex);
            }
        }

        public List<Cargo> ObtenerCargos() => _cargo.ObtenerCargos();

        public void ActualizarUsuario(UsuarioBE usuario)
        {

            _usuarioDAL.ActualizarUsuario(usuario);
        }

        public UsuarioBE BuscarUsuarioPorDni(int dni)
        {
            return _usuarioDAL.BuscarUsuarioPorDni(dni);
        }

    }
}



