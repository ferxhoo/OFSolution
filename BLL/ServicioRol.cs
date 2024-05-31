using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioRol
    {
        private DataRol dataRol = new DataRol();

        public List<Rol> Listar()
        {
            return dataRol.Listar();
        }
    }
}
