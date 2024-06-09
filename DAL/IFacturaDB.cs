using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IFacturaDB <T> where T : class
    {

        int ObtenerCorrelativo();
        bool Registrar(T factura, DataTable detalle, out string mensaje);
        T ObtenerFactura(string numero);

    }
}
