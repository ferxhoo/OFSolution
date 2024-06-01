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
    public class DataCategoria
    {

        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {

                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT idCategoria, descripcion, estado FROM CATEGORIAS");
                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            lista.Add(new Categoria()
                            {
                                idCategoria = Convert.ToInt32(reader["idCategoria"]),
                                descripcion = reader["descripcion"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Categoria>();
                }
            }

            return lista;

        }

        public int Registrar(Categoria nuevaCategoria, out string mensaje)
        {
            int idCategoriaGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("PROC_REGISTRARCATEGORIA", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@descripcion", nuevaCategoria.descripcion);
                    comando.Parameters.AddWithValue("@estado", nuevaCategoria.estado);
                    comando.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    idCategoriaGenerado = Convert.ToInt32(comando.Parameters["@resultado"].Value);
                    mensaje = comando.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idCategoriaGenerado = 0;
                mensaje = ex.Message;
            }

            return idCategoriaGenerado;
        }


        public bool Editar(Categoria CategoriaEditada, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("PROC_EDITARCATEGORIA", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@idCategoria", CategoriaEditada.idCategoria);
                    comando.Parameters.AddWithValue("@descripcion", CategoriaEditada.descripcion);
                    comando.Parameters.AddWithValue("@estado", CategoriaEditada.estado);
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

        public bool Eliminar(Categoria categoria, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("PROC_ELIMINARCATEGORIA", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@idCategoria", categoria.idCategoria);
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



    }


}

