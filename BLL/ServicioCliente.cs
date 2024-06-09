using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioCliente
    {
        private ICrudDB<Cliente> dataCliente = new DataCliente();

        public List<Cliente> Listar()
        {
            return dataCliente.Listar();
        }

        public int Registrar(Cliente nuevoCliente, out string Mensaje)
        {
            return dataCliente.Registrar(nuevoCliente, out Mensaje);
        }

        public bool Editar(Cliente clienteEditado, out string Mensaje)
        {
            return dataCliente.Editar(clienteEditado, out Mensaje);
        }

        public bool Eliminar(Cliente cliente, out string Mensaje)
        {
            return dataCliente.Eliminar(cliente, out Mensaje);
        }

    }
}
