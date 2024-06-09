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
    public class DataNegocio
    {
        public Negocio ObtenerDatos()
        {

            Negocio negocio = new Negocio();

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "SELECT idNegocio, nombre, RUT, correo, direccion FROM DATOSNEGOCIO WHERE idNegocio = 1";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.CommandType = CommandType.Text;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            negocio = new Negocio()
                            {
                                IdNegocio = int.Parse(reader["idNegocio"].ToString()),
                                Nombre = reader["nombre"].ToString(),
                                RUT = reader["RUT"].ToString(),
                                Correo = reader["correo"].ToString(),
                                Direccion = reader["direccion"].ToString()
                            };
                        }
                    }

                }


            }
            catch
            {
                negocio = new Negocio();
            }

            return negocio;
        }

        public bool GuardarDatos(Negocio negocio, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();


                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE DATOSNEGOCIO SET nombre = @nombre,");
                    query.AppendLine("RUT = @rut,");
                    query.AppendLine("correo = @correo,");
                    query.AppendLine("direccion = @direccion");
                    query.AppendLine("WHERE idNegocio = 1;");

                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.Parameters.AddWithValue("@nombre", negocio.Nombre);
                    comando.Parameters.AddWithValue("@rut", negocio.RUT);
                    comando.Parameters.AddWithValue("@correo", negocio.Correo);
                    comando.Parameters.AddWithValue("@direccion", negocio.Direccion);
                    comando.CommandType = CommandType.Text;

                    if (comando.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo guardar los datos";
                        respuesta = false;
                    }

                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }

            return respuesta;

        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "SELECT logo FROM DATOSNEGOCIO WHERE idNegocio = 1";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.CommandType = CommandType.Text;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LogoBytes = (byte[])reader["logo"];
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                obtenido = false;
                LogoBytes = new byte[0];
            }

            return LogoBytes;
        }

        public bool ActualizarLogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();


                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE DATOSNEGOCIO SET logo = @imagen");
                    query.AppendLine("WHERE idNegocio = 1;");

                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.Parameters.AddWithValue("@imagen", image);
                    comando.CommandType = CommandType.Text;

                    if (comando.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el logo";
                        respuesta = false;
                    }

                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }

    }
}
