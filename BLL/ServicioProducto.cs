using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioProducto
    {

        private ICrudDB<Producto> dataProducto = new DataProducto();

        public List<Producto> Listar()
        {
            return dataProducto.Listar();
        }

        public int Registrar(Producto nuevoProducto, out string Mensaje)
        {
            return dataProducto.Registrar(nuevoProducto, out Mensaje);
        }

        public bool Editar(Producto productoEditado, out string Mensaje)
        {
            return dataProducto.Editar(productoEditado, out Mensaje);
        }

        public bool Eliminar(Producto eliminarProducto, out string Mensaje)
        {
            return dataProducto.Eliminar(eliminarProducto, out Mensaje);
        }

    }
}
