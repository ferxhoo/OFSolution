using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioCategoria
    {
        private DataCategoria dataCategoria = new DataCategoria();

        public List<Categoria> Listar()
        {
            return dataCategoria.Listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {    
            return dataCategoria.Registrar(obj, out Mensaje);
        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            return dataCategoria.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return dataCategoria.Eliminar(obj, out Mensaje);
        }
    }
}
