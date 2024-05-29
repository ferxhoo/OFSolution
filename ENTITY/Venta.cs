using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Venta : Factura
    {
        public int idVenta { get; set; }
        public Mesero mesero { get; set; }
        public string documentoCliente { get; set; }
        public string nombreCliente { get; set; }
        public decimal montoCambio { get; set; }
        public decimal montoPago { get; set; }
        public List<DetalleVenta> detallesVenta { get; set; }

        public Venta()
        {
        }
        public Venta(int idVenta, Usuario usuario, Mesero mesero, string tipoDocumento, string numeroDocumento, string documentoCliente, string nombreCliente, List<DetalleVenta> detallesVenta, decimal montoCambio, decimal montoPago,  decimal montoTotal, string fechaRegistro)
        : base(usuario, tipoDocumento, numeroDocumento, montoTotal, fechaRegistro)
        {
            this.idVenta = idVenta;
            this.mesero = mesero;
            this.documentoCliente = documentoCliente;
            this.nombreCliente = nombreCliente;
            this.detallesVenta = detallesVenta;
            this.montoCambio = montoCambio;
            this.montoPago = montoPago;
        }
    }
}
