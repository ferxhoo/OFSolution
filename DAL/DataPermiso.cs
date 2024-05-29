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
    public class DataPermiso
    {
        public List<Permiso> Listar(int idUsuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.idRol,p.nombreMenu FROM PERMISOS p");
                    query.AppendLine("INNER JOIN ROLES r ON r.idRol = p.idRol");
                    query.AppendLine("INNER JOIN USUARIOS u ON u.idRol = r.idRol");
                    query.AppendLine("WHERE u.idUsuario = @idusuario");

                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.Parameters.AddWithValue("@idusuario", idUsuario);
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            lista.Add(new Permiso()
                            {
                                rol = new Rol() { idRol = Convert.ToInt32(reader["idRol"]) },
                                nombreMenu = reader["nombreMenu"].ToString(),
                            });

                        }

                    }
                    return lista;

                }
                catch (Exception ex)
                {

                    lista = new List<Permiso>();
                }
            }

            return lista;

        }
    }
}
