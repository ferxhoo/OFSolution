using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Detalle
    {
        public Producto producto { get; set; }
        public decimal precioVenta { get; set; }
        public int cantidad { get; set; }
        public string fechaRegistro { get; set; }

        public Detalle()
        {
        }

        public Detalle(Producto producto, decimal precioVenta, int cantidad, string fechaRegistro)
        {
            this.producto = producto;
            this.precioVenta = precioVenta;
            this.cantidad = cantidad;
            this.fechaRegistro = fechaRegistro;
        }

    }
}
