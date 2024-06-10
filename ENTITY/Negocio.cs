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
        public string RUT { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Direccion { get; set; }

        public Negocio()
        {
        }

        public Negocio(int idNegocio, string nombre, string rUT, string correo, string contraseña, string direccion)
        {
            IdNegocio = idNegocio;
            Nombre = nombre;
            RUT = rUT;
            Correo = correo;
            Contraseña = contraseña;
            Direccion = direccion;
        }

    }
}
