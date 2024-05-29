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
        #region cdc
        private DataUsuario dataUsuario = new DataUsuario();


        public List<Usuario> Listar()
        {
            return dataUsuario.Listar();
        }

        
        #endregion
    }
}
