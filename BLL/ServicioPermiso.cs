using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioPermiso
    {

        private DataPermiso dataPermiso = new DataPermiso();

        public List<Permiso> Listar(int idUsuario)
        {
            return dataPermiso.Listar(idUsuario);
        }

    }
}
