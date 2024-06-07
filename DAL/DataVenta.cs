﻿using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataVenta
    {
        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT ISNULL(MAX(IdVenta), 0) + 1 FROM VENTAS");
                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    idCorrelativo = Convert.ToInt32(comando.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    // Registro del error (puede ser en un log, base de datos, etc.)
                    Console.WriteLine($"Error al obtener el correlativo: {ex.Message}");
                    // O lanzar una excepción específica si es necesario
                    throw new ApplicationException("Error al obtener el correlativo de la venta.", ex);
                }
            }

            return idCorrelativo;
        }



        public bool RestarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE PRODUCTOS SET stock = stock - @cantidad WHERE idProducto = @idProducto");

                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.Parameters.AddWithValue("@idProducto", idProducto);
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    // Usar una transacción para asegurar la integridad de los datos
                    using (SqlTransaction transaccion = conexion.BeginTransaction())
                    {
                        comando.Transaction = transaccion;

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            transaccion.Commit();
                        }
                        else
                        {
                            transaccion.Rollback();
                            respuesta = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Registrar o manejar el error según sea necesario
                    Console.WriteLine($"Error al restar el stock: {ex.Message}");
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool SumarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE PRODUCTOS SET stock = stock + @cantidad WHERE idProducto = @idProducto");

                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.Parameters.AddWithValue("@idProducto", idProducto);
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    // Usar una transacción para asegurar la integridad de los datos
                    using (SqlTransaction transaccion = conexion.BeginTransaction())
                    {
                        comando.Transaction = transaccion;

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            transaccion.Commit();
                        }
                        else
                        {
                            transaccion.Rollback();
                            respuesta = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Registrar o manejar el error según sea necesario
                    Console.WriteLine($"Error al sumar el stock: {ex.Message}");
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Registrar(Venta venta, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("usp_RegistrarVenta", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros al comando
                    comando.Parameters.AddWithValue("idUsuario", venta.usuario.idUsuario);
                    comando.Parameters.AddWithValue("idMesero", venta.mesero.idMesero); // Nuevo parámetro para idMesero
                    comando.Parameters.AddWithValue("tipoDocumento", venta.tipoDocumento);
                    comando.Parameters.AddWithValue("numeroDocumento", venta.numeroDocumento);
                    comando.Parameters.AddWithValue("documentoCliente", venta.documentoCliente);
                    comando.Parameters.AddWithValue("nombreCliente", venta.nombreCliente);
                    comando.Parameters.AddWithValue("montoPago", venta.montoPago);
                    comando.Parameters.AddWithValue("montoCambio", venta.montoCambio);
                    comando.Parameters.AddWithValue("montoTotal", venta.montoTotal);
                    comando.Parameters.AddWithValue("DetalleVenta", DetalleVenta);

                    // Parámetros de salida
                    comando.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    // Obtener los valores de los parámetros de salida
                    Respuesta = Convert.ToBoolean(comando.Parameters["Resultado"].Value);
                    Mensaje = comando.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }



        public Venta ObtenerVenta(string numero)
        {
            Venta venta = null;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT v.idVenta, u.nombreCompleto AS nombreUsuario,");
                    query.AppendLine("m.documento AS documentoMesero, m.nombreCompleto AS nombreMesero,");
                    query.AppendLine("v.documentoCliente, v.nombreCliente,");
                    query.AppendLine("v.tipoDocumento, v.numeroDocumento,");
                    query.AppendLine("v.montoPago, v.montoCambio, v.montoTotal,");
                    query.AppendLine("CONVERT(char(10), v.fechaRegistro, 103) AS fechaRegistro");
                    query.AppendLine("FROM VENTAS v");
                    query.AppendLine("INNER JOIN MESEROS m ON m.idMesero = v.idMesero");
                    query.AppendLine("INNER JOIN USUARIOS u ON u.idUsuario = v.idUsuario");
                    query.AppendLine("WHERE v.numeroDocumento = @numero");

                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.Parameters.AddWithValue("@numero", numero);
                    comando.CommandType = CommandType.Text;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            venta = new Venta()
                            {
                                idVenta = int.Parse(reader["idVenta"].ToString()),
                                usuario = new Usuario() { nombreCompleto = reader["nombreUsuario"].ToString() },
                                mesero = new Mesero()
                                {
                                    documento = reader["documentoMesero"].ToString(),
                                    nombreCompleto = reader["nombreMesero"].ToString()
                                },
                                documentoCliente = reader["documentoCliente"].ToString(),
                                nombreCliente = reader["nombreCliente"].ToString(),
                                tipoDocumento = reader["tipoDocumento"].ToString(),
                                numeroDocumento = reader["numeroDocumento"].ToString(),
                                montoPago = Convert.ToDecimal(reader["montoPago"].ToString()),
                                montoCambio = Convert.ToDecimal(reader["montoCambio"].ToString()),
                                montoTotal = Convert.ToDecimal(reader["montoTotal"].ToString()),
                                fechaRegistro = reader["fechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine($"Error al obtener la venta: {ex.Message}");
                    venta = new Venta();
                }
            }

            return venta;
        }

        public List<DetalleVenta> ObtenerDetalleVenta(int idVenta)
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.nombre, dv.precioVenta, dv.cantidad, dv.subTotal");
                    query.AppendLine("FROM DETALLES_VENTA dv");
                    query.AppendLine("INNER JOIN PRODUCTOS p ON p.idProducto = dv.idProducto");
                    query.AppendLine("WHERE dv.idVenta = @idVenta");

                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.Parameters.AddWithValue("@idVenta", idVenta);
                    comando.CommandType = CommandType.Text;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DetalleVenta()
                            {
                                producto = new Producto() { nombre = reader["nombre"].ToString() },
                                precioVenta = Convert.ToDecimal(reader["precioVenta"]),
                                cantidad = Convert.ToInt32(reader["cantidad"]),
                                subTotal = Convert.ToDecimal(reader["subTotal"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine($"Error al obtener los detalles de la venta: {ex.Message}");
                    lista = new List<DetalleVenta>();
                }
            }
            return lista;
        }

    }
}
