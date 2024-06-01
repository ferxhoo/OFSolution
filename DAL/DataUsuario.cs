using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DAL
{
    public class DataUsuario
    {

        #region code
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.idUsuario, u.documento, u.nombreCompleto, u.nombreUsuario, u.clave, r.idRol, r.descripcion, u.correo, u.telefono, u.estado FROM USUARIOS u");
                    query.AppendLine("INNER JOIN ROLES r ON r.idRol = u.idRol");

                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            lista.Add(new Usuario()
                            {
                                idUsuario = Convert.ToInt32(reader["idUsuario"]),
                                documento = reader["documento"].ToString(),
                                nombreCompleto = reader["nombreCompleto"].ToString(),
                                nombreUsuario = reader["nombreUsuario"].ToString(),
                                clave = reader["clave"].ToString(),
                                correo = reader["correo"].ToString(),
                                telefono = reader["telefono"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"]),
                                rol = new Rol() { idRol = Convert.ToInt32(reader["idRol"]), descripcion = reader["descripcion"].ToString() }
                            });

                        }

                    }
                  

                }
                catch (Exception ex)
                {

                    lista = new List<Usuario>();
                }
            }

            return lista;

        }

        #endregion

        public int Registrar(Usuario nuevoUsuario, out string Mensaje)
        {
            int idUsuarioGenerado = 0;
            Mensaje = string.Empty;


            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand comando = new SqlCommand("PROC_REGISTRARUSUARIO", conexion);
                    comando.Parameters.AddWithValue("documento", nuevoUsuario.documento);
                    comando.Parameters.AddWithValue("nombreCompleto", nuevoUsuario.nombreCompleto);
                    comando.Parameters.AddWithValue("nombreUsuario", nuevoUsuario.nombreUsuario);
                    comando.Parameters.AddWithValue("clave", nuevoUsuario.clave);
                    comando.Parameters.AddWithValue("idRol", nuevoUsuario.rol.idRol);
                    comando.Parameters.AddWithValue("correo", nuevoUsuario.correo);
                    comando.Parameters.AddWithValue("telefono", nuevoUsuario.telefono);
                    comando.Parameters.AddWithValue("estado", nuevoUsuario.estado);
                    comando.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comando.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    comando.ExecuteNonQuery();

                    idUsuarioGenerado = Convert.ToInt32(comando.Parameters["idUsuarioResultado"].Value);
                    Mensaje = comando.Parameters["mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                idUsuarioGenerado = 0;
                Mensaje = ex.Message;
            }



            return idUsuarioGenerado;
        }

        public bool Editar(Usuario usuarioEditado, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand comando = new SqlCommand("PROC_EDITARUSUARIO", conexion);
                    comando.Parameters.AddWithValue("idUsuario", usuarioEditado.idUsuario);
                    comando.Parameters.AddWithValue("documento", usuarioEditado.documento);
                    comando.Parameters.AddWithValue("nombreCompleto", usuarioEditado.nombreCompleto);
                    comando.Parameters.AddWithValue("nombreUsuario", usuarioEditado.nombreUsuario);
                    comando.Parameters.AddWithValue("clave", usuarioEditado.clave);
                    comando.Parameters.AddWithValue("idRol", usuarioEditado.rol.idRol);
                    comando.Parameters.AddWithValue("correo", usuarioEditado.correo);
                    comando.Parameters.AddWithValue("telefono", usuarioEditado.telefono);
                    comando.Parameters.AddWithValue("estado", usuarioEditado.estado);
                    comando.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comando.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    comando.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(comando.Parameters["respuesta"].Value);
                    Mensaje = comando.Parameters["mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }



            return respuesta;
        }


        public bool Eliminar(Usuario eliminarUsuario, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand comando = new SqlCommand("PROC_ELIMINARUSUARIO", conexion);
                    comando.Parameters.AddWithValue("idUsuario", eliminarUsuario.idUsuario);
                    comando.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    comando.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    comando.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(comando.Parameters["respuesta"].Value);
                    Mensaje = comando.Parameters["mensaje"].Value.ToString();

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

