using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Persona
    {
        public string documento { get; set; }
        public string nombreCompleto { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }
        public string fechaRegistro { get; set; }

        public Persona()
        {
        }

        public Persona(string documento, string nombreCompleto, string correo, string telefono, bool estado, string fechaRegistro)
        {
            this.documento = documento;
            this.nombreCompleto = nombreCompleto;
            this.correo = correo;
            this.telefono = telefono;
            this.estado = estado;
            this.fechaRegistro = fechaRegistro;
        }

    }
}
