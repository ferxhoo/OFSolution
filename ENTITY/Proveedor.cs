using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Proveedor : Persona
    {
        public int idProveedor { get; set; }
        public string razonSocial { get; set; }

        public Proveedor()
        {
        }

        public Proveedor(int idProveedor, string documento, string nombreCompleto, string correo, string telefono, bool estado, string razonSocial, string fechaRegistro)
        : base(documento, nombreCompleto, correo, telefono, estado, fechaRegistro)
        {
            this.idProveedor = idProveedor;
            this.razonSocial = razonSocial;
        }

    }

}
