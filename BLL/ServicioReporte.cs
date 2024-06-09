using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioReporte
    {
        DataReporte dataReporte = new DataReporte();

        public List<Reporte> ObtenerReporteMensual(DateTime fechaInicio, DateTime fechaFin)
        {
            return dataReporte.ObtenerReporteMensual(fechaInicio, fechaFin);
        }

    }
}
