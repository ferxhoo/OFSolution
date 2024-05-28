using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Mesero : Persona
    {
        public int idMesero { get; set; }

        public Mesero(int idMesero, string documento, string nombreCompleto, string correo, string telefono, bool estado, string fechaRegistro)
            : base(documento, nombreCompleto, correo, telefono, estado, fechaRegistro)
        {
            this.idMesero = idMesero;
        }
    }

}
