using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Factura
    {
        public Usuario usuario { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public decimal montoTotal { get; set; }
        public string fechaRegistro { get; set; }

        public Factura()
        {
        }

        public Factura(Usuario usuario, string tipoDocumento, string numeroDocumento, decimal montoTotal, string fechaRegistro)
        {
            this.usuario = usuario;
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
            this.montoTotal = montoTotal;
            this.fechaRegistro = fechaRegistro;
        }

    }
}
