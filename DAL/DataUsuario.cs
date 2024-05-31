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

                    
                    string query = "SELECT idUsuario, documento, nombreCompleto, nombreUsuario, clave, idRol, correo, telefono, estado FROM USUARIOS";

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
                                //rol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]), Descripcion = dr["Descripcion"].ToString() }
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

    }
}
