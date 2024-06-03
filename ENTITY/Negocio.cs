using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Negocio
    {
        public int IdNegocio { get; set; }
        public string Nombre { get; set; }
        public string RUC { get; set; }
        public string Direccion { get; set; }

        public Negocio()
        {
        }

        public Negocio(int idNegocio, string nombre, string ruc, string direccion)
        {
            IdNegocio = idNegocio;
            Nombre = nombre;
            RUC = ruc;
            Direccion = direccion;
        }
    }
}
