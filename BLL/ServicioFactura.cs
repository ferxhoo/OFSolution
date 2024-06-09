using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class ServicioFactura
    {
        DataFactura dataFactura = new DataFactura();

        public List<Compra> ObtenerComprasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            return dataFactura.ObtenerComprasEntreFechas(fechaInicio, fechaFin);
        }

        public decimal ObtenerGastosEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            return dataFactura.ObtenerGastosEntreFechas(fechaInicio, fechaFin);
        }

        public List<Venta> ObtenerVentasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            return dataFactura.ObtenerVentasEntreFechas(fechaInicio, fechaFin);
        }

        public decimal ObtenerGananciasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            return dataFactura.ObtenerGananciasEntreFechas(fechaInicio, fechaFin);
        }

    }
}
