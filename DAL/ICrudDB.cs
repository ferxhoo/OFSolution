using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICrudDB<T> where T : class
    {

        List<T> Listar();
        int Registrar(T entidadNueva, out string mensaje);
        bool Editar(T entidadEditada, out string mensaje);
        bool Eliminar(T entidadEliminar, out string mensaje);

    }
}
