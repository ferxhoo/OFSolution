using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioUsuario
    {
        private ICrudDB<Usuario> dataUsuario = new DataUsuario();

        public List<Usuario> Listar()
        {
            return dataUsuario.Listar();
        }

        public int Registrar(Usuario nuevoUsuario, out string Mensaje)
        {
            return dataUsuario.Registrar(nuevoUsuario, out Mensaje);
        }

        public bool Editar(Usuario usuarioEditado, out string Mensaje)
        {
            return dataUsuario.Editar(usuarioEditado, out Mensaje);
        }

        public bool Eliminar(Usuario eliminarUsuario, out string Mensaje)
        {
            return dataUsuario.Eliminar(eliminarUsuario, out Mensaje);
        }

    }
}
