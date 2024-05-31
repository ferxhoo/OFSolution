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

    }
}
