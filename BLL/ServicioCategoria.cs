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
        private ICrudDB<Categoria> dataCategoria = new DataCategoria();

        public List<Categoria> Listar()
        {
            return dataCategoria.Listar();
        }

        public int Registrar(Categoria categoria, out string Mensaje)
        {    
            return dataCategoria.Registrar(categoria, out Mensaje);
        }

        public bool Editar(Categoria categoria, out string Mensaje)
        {
            return dataCategoria.Editar(categoria, out Mensaje);
        }

        public bool Eliminar(Categoria categoria, out string Mensaje)
        {
            return dataCategoria.Eliminar(categoria, out Mensaje);
        }

    }
}
