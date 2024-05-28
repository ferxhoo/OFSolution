using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class DetalleCompra : Detalle
    {
        public int idDetalleCompra { get; set; }
        public Compra compra { get; set; }
        public decimal precioCompra { get; set; }
        public decimal montoTotal { get; set; }

        public DetalleCompra()
        {
        }

        public DetalleCompra(int idDetalleCompra, Compra compra, Producto producto, decimal precioCompra, decimal precioVenta, int cantidad, decimal montoTotal, string fechaRegistro)
        : base(producto, precioVenta, cantidad, fechaRegistro)
        {
            this.idDetalleCompra = idDetalleCompra;
            this.precioCompra = precioCompra;
            this.montoTotal = montoTotal;
        }

    }
}
