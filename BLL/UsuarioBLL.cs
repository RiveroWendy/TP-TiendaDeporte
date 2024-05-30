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



        public void EditarUsuario(UsuarioBE usuario)
        {
            usuarioDAL.EditarUsuario(usuario);
        }

        public void EliminarUsuario(int idUsuario)
        {
            usuarioDAL.EliminarUsuario(idUsuario);
        }

        public UsuarioBE BuscarUsuario(int idUsuario)
        {
            return usuarioDAL.BuscarUsuario(idUsuario);
        }

        public void EditarUsuario(EmpleadoBE empleado)
        {
            throw new NotImplementedException();
        }
        public UsuarioBE ObtenerUsuarioPorId(int idUsuario)
        {
            return usuarioDAL.ObtenerUsuarioPorId(idUsuario);
        }
    }
}



