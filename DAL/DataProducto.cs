using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProducto : ICrudDB<Producto>
    {

        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT idProducto, codigo, nombre, p.descripcion, c.idCategoria, c.descripcion AS descripcionCategoria, stock, precioCompra, precioVenta, p.estado");
                    query.AppendLine("FROM PRODUCTOS p");
                    query.AppendLine("INNER JOIN CATEGORIAS c ON c.idCategoria = p.idCategoria");

                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto()
                            {
                                idProducto = Convert.ToInt32(reader["idProducto"]),
                                codigo = reader["codigo"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                descripcion = reader["descripcion"].ToString(),
                                categoria = new Categoria()
                                {
                                    idCategoria = Convert.ToInt32(reader["idCategoria"]),
                                    descripcion = reader["descripcionCategoria"].ToString()
                                },
                                stock = Convert.ToInt32(reader["stock"]),
                                precioCompra = Convert.ToDecimal(reader["precioCompra"]),
                                precioVenta = Convert.ToDecimal(reader["precioVenta"]),
                                estado = Convert.ToBoolean(reader["estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Producto>();
                }
            }

            return lista;
        }

        public int Registrar(Producto nuevoProducto, out string mensaje)
        {
            int idProductoGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("PROC_REGISTRARPRODUCTO", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@codigo", nuevoProducto.codigo);
                    comando.Parameters.AddWithValue("@nombre", nuevoProducto.nombre);
                    comando.Parameters.AddWithValue("@descripcion", nuevoProducto.descripcion);
                    comando.Parameters.AddWithValue("@idCategoria", nuevoProducto.categoria.idCategoria);
                    comando.Parameters.AddWithValue("@estado", nuevoProducto.estado);
                    comando.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    idProductoGenerado = Convert.ToInt32(comando.Parameters["@resultado"].Value);
                    mensaje = comando.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idProductoGenerado = 0;
                mensaje = ex.Message;
            }

            return idProductoGenerado;
        }

        public bool Editar(Producto productoEditado, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("PROC_EDITARPRODUCTO", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@idProducto", productoEditado.idProducto);
                    comando.Parameters.AddWithValue("@codigo", productoEditado.codigo);
                    comando.Parameters.AddWithValue("@nombre", productoEditado.nombre);
                    comando.Parameters.AddWithValue("@descripcion", productoEditado.descripcion);
                    comando.Parameters.AddWithValue("@idCategoria", productoEditado.categoria.idCategoria);
                    comando.Parameters.AddWithValue("@estado", productoEditado.estado);
                    comando.Parameters.Add("@resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(comando.Parameters["@resultado"].Value);
                    mensaje = comando.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool Eliminar(Producto producto, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("PROC_ELIMINARPRODUCTO", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@idProducto", producto.idProducto);
                    comando.Parameters.Add("@respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(comando.Parameters["@respuesta"].Value);
                    mensaje = comando.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;
        }

    }
}
