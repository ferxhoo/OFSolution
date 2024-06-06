using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioCompra
    {
        private DataCompra dataCompra = new DataCompra();

        public int ObtenerCorrelativo()
        {
            return dataCompra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra compra, DataTable detalleCompra, out string mensaje)
        {
            return dataCompra.Registrar(compra, detalleCompra, out mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra compra = dataCompra.ObtenerCompra(numero);

            if (compra != null && compra.idCompra != 0)
            {
                List<DetalleCompra> detallesCompra = dataCompra.ObtenerDetalleCompra(compra.idCompra);
                compra.detallesCompra = detallesCompra;
            }

            return compra;
        }
    }

}
