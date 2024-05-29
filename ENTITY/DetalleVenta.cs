using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class DetalleVenta : Detalle
    {
        public int idDetalleVenta { get; set; }
        public decimal subTotal { get; set; }

        public DetalleVenta()
        {
        }

        public DetalleVenta(int idDetalleVenta, Producto producto, decimal precioVenta, int cantidad, decimal subTotal, string fechaRegistro)
        : base(producto, precioVenta, cantidad, fechaRegistro)
        {
            this.idDetalleVenta = idDetalleVenta;
            this.subTotal = subTotal;
        }

    }
}
