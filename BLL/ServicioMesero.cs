using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioMesero
    {
        private DataMesero dataMesero = new DataMesero();

        public List<Mesero> Listar()
        {
            return dataMesero.Listar();
        }

        public int Registrar(Mesero nuevoMesero, out string Mensaje)
        {
            return dataMesero.Registrar(nuevoMesero, out Mensaje);
        }

        public bool Editar(Mesero meseroEditado, out string Mensaje)
        {
            return dataMesero.Editar(meseroEditado, out Mensaje);
        }

        public bool Eliminar(Mesero mesero, out string Mensaje)
        {
            return dataMesero.Eliminar(mesero, out Mensaje);
        }

    }
}
