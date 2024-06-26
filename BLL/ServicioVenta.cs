﻿using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioVenta
    {

        private DataVenta dataVenta = new DataVenta();

        public bool RestarStock(int idproducto, int cantidad)
        {
            return dataVenta.RestarStock(idproducto, cantidad);
        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            return dataVenta.SumarStock(idproducto, cantidad);
        }

        public int ObtenerCorrelativo()
        {
            return dataVenta.ObtenerCorrelativo();
        }

        public bool Registrar(Venta venta, DataTable DetalleVenta, out string Mensaje)
        {
            return dataVenta.Registrar(venta, DetalleVenta, out Mensaje);
        }

        public Venta ObtenerVenta(string numero)
        {
            Venta venta = dataVenta.ObtenerFactura(numero);

            if (venta != null && venta.idVenta != 0) // Verifica si la venta no es null y si idVenta no es 0
            {
                List<DetalleVenta> detalleVenta = dataVenta.ObtenerDetalleVenta(venta.idVenta);
                venta.detallesVenta = detalleVenta;
            }
            else
            {
                venta = null; // Esta línea es redundante porque venta ya es null
            }

            return venta;
        }

    }
}
