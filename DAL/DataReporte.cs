using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataReporte
    {

        public List<Reporte> ObtenerReporteMensual(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Reporte> reporteMensual = new List<Reporte>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                WITH Meses AS (
                    SELECT 1 AS Mes UNION ALL
                    SELECT 2 UNION ALL
                    SELECT 3 UNION ALL
                    SELECT 4 UNION ALL
                    SELECT 5 UNION ALL
                    SELECT 6 UNION ALL
                    SELECT 7 UNION ALL
                    SELECT 8 UNION ALL
                    SELECT 9 UNION ALL
                    SELECT 10 UNION ALL
                    SELECT 11 UNION ALL
                    SELECT 12
                ),
                ComprasMensuales AS (
                    SELECT
                        MONTH(fechaRegistro) AS Mes,
                        SUM(montoTotal) AS TotalCompras
                    FROM
                        Compras
                    WHERE
                        fechaRegistro BETWEEN @FechaInicial AND @FechaFinal
                    GROUP BY
                        MONTH(fechaRegistro)
                ),
                VentasMensuales AS (
                    SELECT
                        MONTH(fechaRegistro) AS Mes,
                        SUM(montoTotal) AS TotalVentas
                    FROM
                        Ventas
                    WHERE
                        fechaRegistro BETWEEN @FechaInicial AND @FechaFinal
                    GROUP BY
                        MONTH(fechaRegistro)
                )
                SELECT
                    m.Mes,
                    COALESCE(v.TotalVentas, 0) AS TotalVentas,
                    COALESCE(c.TotalCompras, 0) AS TotalCompras,
                    COALESCE(v.TotalVentas, 0) - COALESCE(c.TotalCompras, 0) AS Resto
                FROM
                    Meses m
                LEFT JOIN
                    ComprasMensuales c ON m.Mes = c.Mes
                LEFT JOIN
                    VentasMensuales v ON m.Mes = v.Mes
                ORDER BY
                    m.Mes;";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@FechaInicial", fechaInicio);
                    comando.Parameters.AddWithValue("@FechaFinal", fechaFin);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reporte reporte = new Reporte
                            {
                                Mes = Convert.ToInt32(reader["Mes"]),
                                TotalVentas = Convert.ToDecimal(reader["TotalVentas"]),
                                TotalCompras = Convert.ToDecimal(reader["TotalCompras"]),
                                Resto = Convert.ToDecimal(reader["Resto"])
                            };
                            reporteMensual.Add(reporte);
                        }
                    }
                }
                catch (Exception ex)
                {
                    return reporteMensual;
                }
            }

            return reporteMensual;
        }


    }
}
