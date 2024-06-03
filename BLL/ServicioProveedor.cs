using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioProveedor
    {
        private DataProveedor dataProveedor = new DataProveedor();


        public List<Proveedor> Listar()
        {
            return dataProveedor.Listar();
        }

        public int Registrar(Proveedor proveedor, out string Mensaje)
        {
            return dataProveedor.Registrar(proveedor, out Mensaje);
        }


        public bool Editar(Proveedor proveedor, out string Mensaje)
        {
            return dataProveedor.Editar(proveedor, out Mensaje);
        }


        public bool Eliminar(Proveedor proveedor, out string Mensaje)
        {
            return dataProveedor.Eliminar(proveedor, out Mensaje);
        }
    }
}
