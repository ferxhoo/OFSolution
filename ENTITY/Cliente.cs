using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cliente : Persona
    {
        public int idCliente { get; set; }

        public Cliente(int idCliente, string documento, string nombreCompleto, string correo, string telefono, bool estado, string fechaRegistro)
            : base(documento, nombreCompleto, correo, telefono, estado, fechaRegistro)
        {
            this.idCliente = idCliente;
        }
    }

}
