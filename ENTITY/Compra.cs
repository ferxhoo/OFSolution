using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Compra : Factura
    {
        public int idCompra { get; set; }
        public Proveedor proveedor { get; set; }
        
        public Compra(int idCompra, Usuario usuario, Proveedor proveedor, string tipoDocumento, string numeroDocumento, decimal montoTotal,  string fechaRegistro)
        : base(usuario, tipoDocumento, numeroDocumento, montoTotal, fechaRegistro)
        {
            this.idCompra = idCompra;
            this.proveedor = proveedor;
        }

    }
}
