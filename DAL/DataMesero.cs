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
    public class DataMesero : ICrudDB<Mesero>
    {
        public List<Mesero> Listar()
        {
            List<Mesero> lista = new List<Mesero>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT idMesero, documento, nombreCompleto, correo, telefono, estado FROM MESEROS");
                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.CommandType = CommandType.Text;
                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Mesero()
                            {
                                idMesero = Convert.ToInt32(reader["idMesero"]),
                                documento = reader["documento"].ToString(),
                                nombreCompleto = reader["nombreCompleto"].ToString(),
                                correo = reader["correo"].ToString(),
                                telefono = reader["telefono"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Mesero>();
                }
            }

            return lista;
        }

        public int Registrar(Mesero nuevoMesero, out string mensaje)
        {
            int idMeseroGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("REGISTRARMESERO", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@documento", nuevoMesero.documento);
                    comando.Parameters.AddWithValue("@nombreCompleto", nuevoMesero.nombreCompleto);
                    comando.Parameters.AddWithValue("@correo", nuevoMesero.correo);
                    comando.Parameters.AddWithValue("@telefono", nuevoMesero.telefono);
                    comando.Parameters.AddWithValue("@estado", nuevoMesero.estado);
                    comando.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    idMeseroGenerado = Convert.ToInt32(comando.Parameters["@resultado"].Value);
                    mensaje = comando.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idMeseroGenerado = 0;
                mensaje = ex.Message;
            }

            return idMeseroGenerado;
        }

        public bool Editar(Mesero meseroEditado, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("EDITARMESERO", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@idMesero", meseroEditado.idMesero);
                    comando.Parameters.AddWithValue("@documento", meseroEditado.documento);
                    comando.Parameters.AddWithValue("@nombreCompleto", meseroEditado.nombreCompleto);
                    comando.Parameters.AddWithValue("@correo", meseroEditado.correo);
                    comando.Parameters.AddWithValue("@telefono", meseroEditado.telefono);
                    comando.Parameters.AddWithValue("@estado", meseroEditado.estado);
                    comando.Parameters.Add("@resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(comando.Parameters["@resultado"].Value);
                    mensaje = comando.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                mensaje = ex.Message;
            }

            return resultado;
        }

        public bool Eliminar(Mesero mesero, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("ELIMINARMESERO", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@idMesero", mesero.idMesero);
                    comando.Parameters.Add("@respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(comando.Parameters["@respuesta"].Value);
                    mensaje = comando.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                mensaje = ex.Message;
            }

            return resultado;
        }

    }
}
