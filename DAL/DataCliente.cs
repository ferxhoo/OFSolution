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
    public class DataCliente : ICrudDB<Cliente>
    {

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {

                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT idCliente, documento, nombreCompleto, correo, telefono, estado FROM CLIENTES");
                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.CommandType = CommandType.Text;
                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                idCliente = Convert.ToInt32(reader["idCliente"]),
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

                    lista = new List<Cliente>();
                }
            }

            return lista;

        }

        public int Registrar(Cliente nuevoCliente, out string mensaje)
        {
            int idClienteGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("REGISTRARCLIENTE", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@documento", nuevoCliente.documento);
                    comando.Parameters.AddWithValue("@nombreCompleto", nuevoCliente.nombreCompleto);
                    comando.Parameters.AddWithValue("@correo", nuevoCliente.correo);
                    comando.Parameters.AddWithValue("@telefono", nuevoCliente.telefono);
                    comando.Parameters.AddWithValue("@estado", nuevoCliente.estado);
                    comando.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    idClienteGenerado = Convert.ToInt32(comando.Parameters["@resultado"].Value);
                    mensaje = comando.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idClienteGenerado = 0;
                mensaje = ex.Message;
            }

            return idClienteGenerado;
        }

        public bool Editar(Cliente clienteEditado, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("EDITARCLIENTE", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@idCliente", clienteEditado.idCliente);
                    comando.Parameters.AddWithValue("@documento", clienteEditado.documento);
                    comando.Parameters.AddWithValue("@nombreCompleto", clienteEditado.nombreCompleto);
                    comando.Parameters.AddWithValue("@correo", clienteEditado.correo);
                    comando.Parameters.AddWithValue("@telefono", clienteEditado.telefono);
                    comando.Parameters.AddWithValue("@estado", clienteEditado.estado);
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

        public bool Eliminar(Cliente cliente, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand comando = new SqlCommand("DELETE FROM CLIENTES WHERE idCliente = @id", conexion);
                    comando.Parameters.AddWithValue("@id", cliente.idCliente);
                    comando.CommandType = CommandType.Text;
                    conexion.Open();
                    respuesta = comando.ExecuteNonQuery() > 0 ? true : false;
                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

    }
}
