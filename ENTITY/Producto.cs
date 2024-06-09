using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Categoria categoria { get; set; }
        public int stock { get; set; }
        public decimal precioCompra { get; set; }
        public decimal precioVenta { get; set; }
        public bool estado { get; set; }
        public string fechaRegistro { get; set; }

        public Producto()
        {
        }

        public Producto(int idProducto, string codigo, string nombre, string descripcion, Categoria categoria, int stock, decimal precioCompra, decimal precioVenta, bool estado, string fechaRegistro)
        {
            this.idProducto = idProducto;
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.stock = stock;
            this.estado = estado;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.fechaRegistro = fechaRegistro;
        }

    }
}
