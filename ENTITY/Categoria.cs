using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public string fechaRegistro { get; set; }

        public Categoria()
        {
        }

        public Categoria(int idCategoria, string descripcion, bool estado, string fechaRegistro)
        {
            this.idCategoria = idCategoria;
            this.descripcion = descripcion;
            this.estado = estado;
            this.fechaRegistro = fechaRegistro;
        }
    }
}
