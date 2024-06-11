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
    public class DataProveedor : ICrudDB<Proveedor>
    {

        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT idProveedor, documento, nombreCompleto, razonSocial, correo, telefono, estado FROM PROVEEDORES");

                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            lista.Add(new Proveedor()
                            {
                                idProveedor = Convert.ToInt32(reader["idProveedor"]),
                                documento = reader["documento"].ToString(),
                                nombreCompleto = reader["nombreCompleto"].ToString(),
                                razonSocial = reader["razonSocial"].ToString(),
                                correo = reader["correo"].ToString(),
                                telefono = reader["telefono"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"])
                            });

                        }

                    }


                }
                catch (Exception ex)
                {

                    lista = new List<Proveedor>();
                }
            }

            return lista;

        }

        public int Registrar(Proveedor nuevoProveedor, out string mensaje)
        {
            int idProveedorGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("REGISTRARPROVEEDOR", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@documento", nuevoProveedor.documento);
                    comando.Parameters.AddWithValue("@nombreCompleto", nuevoProveedor.nombreCompleto);
                    comando.Parameters.AddWithValue("@razonSocial", nuevoProveedor.razonSocial);
                    comando.Parameters.AddWithValue("@correo", nuevoProveedor.correo);
                    comando.Parameters.AddWithValue("@telefono", nuevoProveedor.telefono);
                    comando.Parameters.AddWithValue("@estado", nuevoProveedor.estado);
                    comando.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    idProveedorGenerado = Convert.ToInt32(comando.Parameters["@resultado"].Value);
                    mensaje = comando.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idProveedorGenerado = 0;
                mensaje = ex.Message;
            }

            return idProveedorGenerado;
        }

        public bool Editar(Proveedor proveedorEditado, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("EDITARPROVEEDOR", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@idProveedor", proveedorEditado.idProveedor);
                    comando.Parameters.AddWithValue("@documento", proveedorEditado.documento);
                    comando.Parameters.AddWithValue("@nombreCompleto", proveedorEditado.nombreCompleto);
                    comando.Parameters.AddWithValue("@razonSocial", proveedorEditado.razonSocial);
                    comando.Parameters.AddWithValue("@correo", proveedorEditado.correo);
                    comando.Parameters.AddWithValue("@telefono", proveedorEditado.telefono);
                    comando.Parameters.AddWithValue("@estado", proveedorEditado.estado);
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

        public bool Eliminar(Proveedor proveedor, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("ELIMINARPROVEEDOR", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@idProveedor", proveedor.idProveedor);
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

    }
}
