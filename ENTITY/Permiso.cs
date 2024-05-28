using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Permiso
    {
        public int idPermiso { get; set; }
        public Rol rol { get; set; }
        public string nombreMenu { get; set; }
        public string fechaRegistro { get; set; }
    }
}
