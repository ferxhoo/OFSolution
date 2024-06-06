using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DAL
{
    public class DataCompra
    {
        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT ISNULL(MAX(idCompra), 0) + 1 FROM COMPRAS");
                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    idCorrelativo = Convert.ToInt32(comando.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idCorrelativo = 0;
                }
            }

            return idCorrelativo;
        }

        public bool Registrar(Compra compra, DataTable DetalleCompra, out string mensaje)
        {
            bool Respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("sp_RegistrarCompra", conexion);
                    comando.Parameters.AddWithValue("@idUsuario", compra.usuario.idUsuario);
                    comando.Parameters.AddWithValue("@idProveedor", compra.proveedor.idProveedor);
                    comando.Parameters.AddWithValue("@tipoDocumento", compra.tipoDocumento);
                    comando.Parameters.AddWithValue("@numeroDocumento", compra.numeroDocumento);
                    comando.Parameters.AddWithValue("@montoTotal", compra.montoTotal);

                    SqlParameter detalleCompraParam = new SqlParameter("@detalleCompra", SqlDbType.Structured);
                    detalleCompraParam.Value = DetalleCompra;
                    comando.Parameters.Add(detalleCompraParam);

                    comando.Parameters.Add("@resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comando.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    comando.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(comando.Parameters["@resultado"].Value);
                    mensaje = comando.Parameters["@mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    mensaje = ex.Message;
                }
            }
            return Respuesta;
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra compra = null;
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.idCompra,");
                    query.AppendLine("u.nombreCompleto,");
                    query.AppendLine("pr.documento, pr.razonSocial,");
                    query.AppendLine("c.tipoDocumento, c.numeroDocumento, c.montoTotal, CONVERT(char(10), c.fechaRegistro, 103) AS fechaRegistro");
                    query.AppendLine("FROM COMPRAS c");
                    query.AppendLine("INNER JOIN USUARIOS u ON u.idUsuario = c.idUsuario");
                    query.AppendLine("INNER JOIN PROVEEDORES pr ON pr.idProveedor = c.idProveedor");
                    query.AppendLine("WHERE c.numeroDocumento = @numero");

                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.Parameters.AddWithValue("@numero", numero);
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            compra = new Compra()
                            {
                                idCompra = Convert.ToInt32(reader["idCompra"]),
                                usuario = new Usuario() { nombreCompleto = reader["nombreCompleto"].ToString() },
                                proveedor = new Proveedor() { documento = reader["documento"].ToString(), razonSocial = reader["razonSocial"].ToString() },
                                tipoDocumento = reader["tipoDocumento"].ToString(),
                                numeroDocumento = reader["numeroDocumento"].ToString(),
                                montoTotal = Convert.ToDecimal(reader["montoTotal"]),
                                fechaRegistro = reader["fechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    compra = new Compra(); 
                }
            }
            return compra;
        }

        public List<DetalleCompra> ObtenerDetalleCompra(int idCompra)
        {
            List<DetalleCompra> lista = new List<DetalleCompra>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT p.nombre, dc.precioCompra, dc.cantidad, dc.montoTotal");
                    query.AppendLine("FROM DETALLES_COMPRA dc");
                    query.AppendLine("INNER JOIN PRODUCTOS p ON p.idProducto = dc.idProducto");
                    query.AppendLine("WHERE dc.idCompra = @idCompra");

                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.Parameters.AddWithValue("@idCompra", idCompra);
                    comando.CommandType = CommandType.Text;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DetalleCompra()
                            {
                                producto = new Producto() { nombre = reader["nombre"].ToString() },
                                precioCompra = Convert.ToDecimal(reader["precioCompra"]),
                                cantidad = Convert.ToInt32(reader["cantidad"]),
                                montoTotal = Convert.ToDecimal(reader["montoTotal"]),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<DetalleCompra>();
            }
            return lista;
        }
    }
}
