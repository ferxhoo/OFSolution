using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario : Persona
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string clave { get; set; }
        public Rol rol { get; set; }

        public Usuario()
        {
        }

        public Usuario(int idUsuario, string documento, string nombreCompleto, string nombreUsuario, string clave, Rol rol, string correo, string telefono, bool estado, string fechaRegistro)
            : base(documento, nombreCompleto, correo, telefono, estado, fechaRegistro)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.clave = clave;
            this.rol = rol;
        }
    }

}
