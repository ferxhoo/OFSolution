using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class DataFactura
    {
        public List<Compra> ObtenerComprasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Compra> compras = new List<Compra>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("ObtenerComprasEntreFechas", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@fechainicio", fechaInicio);
                    comando.Parameters.AddWithValue("@fechafin", fechaFin);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Compra compra = new Compra()
                            {
                                fechaRegistro = reader["fechaRegistro"].ToString(),
                                tipoDocumento = reader["tipoDocumento"].ToString(),
                                numeroDocumento = reader["numeroDocumento"].ToString(),
                                usuario = new Usuario { nombreCompleto = reader["usuarioRegistro"].ToString() },
                                proveedor = new Proveedor
                                {
                                    documento = reader["documentoProveedor"].ToString(),
                                    razonSocial = reader["proveedor"].ToString()
                                },
                                montoTotal = Convert.ToDecimal(reader["montoTotal"])
                            };
                            compras.Add(compra);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    return compras;
                }
            }

            return compras;
        }


        public decimal ObtenerGastosEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            decimal totalGastos = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"SELECT 
                                SUM(c.montoTotal) AS gastos
                            FROM COMPRAS c
                            WHERE CONVERT(DATE, c.fechaRegistro) BETWEEN @FechaInicio AND @FechaFin";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    comando.Parameters.AddWithValue("@FechaFin", fechaFin);

                    conexion.Open();
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        totalGastos = Convert.ToDecimal(resultado);
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    return totalGastos;
                }
            }

            return totalGastos;
        }


        public List<Venta> ObtenerVentasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Venta> ventas = new List<Venta>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("ObtenerVentasEntreFechas", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@fechainicio", fechaInicio);
                    comando.Parameters.AddWithValue("@fechafin", fechaFin);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venta venta = new Venta()
                            {
                                fechaRegistro = reader["fechaRegistro"].ToString(),
                                tipoDocumento = reader["tipoDocumento"].ToString(),
                                numeroDocumento = reader["numeroDocumento"].ToString(),
                                usuario = new Usuario { nombreCompleto = reader["usuarioRegistro"].ToString() },
                                mesero = new Mesero { nombreCompleto = reader["mesero"].ToString() },
                                numeroMesa = Convert.ToInt32(reader["NumeroMesa"]),
                                documentoCliente = reader["documentoCliente"].ToString(),
                                nombreCliente = reader["nombreCliente"].ToString(),
                                montoPago = Convert.ToDecimal(reader["montoPago"]),
                                montoCambio = Convert.ToDecimal(reader["montoCambio"]),
                                montoTotal = Convert.ToDecimal(reader["montoTotal"])
                            };
                            ventas.Add(venta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    return ventas;
                }
            }
            return ventas;
        }

        public decimal ObtenerGananciasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            decimal ganancias = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT SUM(v.montoTotal) AS ganancias FROM VENTAS v WHERE CONVERT(DATE, v.fechaRegistro) BETWEEN @fechaInicio AND @fechaFin", conexion);
                    comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    comando.Parameters.AddWithValue("@fechaFin", fechaFin);

                    conexion.Open();

                    object result = comando.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        ganancias = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    return ganancias;
                }
            }

            return ganancias;
        }

    }
}
