using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioNegocio
    {

        private DataNegocio dataNegocio = new DataNegocio();


        public Negocio ObtenerDatos()
        {
            return dataNegocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio negocio, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (negocio.Nombre == "")
                Mensaje += "Es necesario el nombre\n";

            if (negocio.RUT == "")
                Mensaje += "Es necesario el numero de RUC\n";
            
            if (negocio.Direccion == "")
                Mensaje += "Es necesario la direccion\n";

            if (Mensaje != string.Empty)
                return false;
            else
                return dataNegocio.GuardarDatos(negocio, out Mensaje);
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return dataNegocio.ObtenerLogo(out obtenido);
        }


        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return dataNegocio.ActualizarLogo(imagen, out mensaje);
        }

    }
}
