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
            _cargo = new CargoDAL();
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


        public void EliminarUsuario(int dni)
        {
            try
            {
                // Obtener el usuario a eliminar para verificar si es administrador
                UsuarioBE usuario = _usuarioDAL.BuscarUsuarioPorDni(dni);

                if (usuario != null && usuario.Empleado.CargoEmpleado.Nombre.ToLower() == "administrador")
                {
                    throw new Exception("No se puede eliminar al usuario administrador.");
                }

                _usuarioDAL.EliminarUsuario(dni);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el usuario. Detalles: " + ex.Message, ex);
            }
        }
    }
}



