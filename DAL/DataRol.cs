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
    public class DataRol
    {

        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdRol,Descripcion FROM ROLES");

                    SqlCommand comando = new SqlCommand(query.ToString(), conexion);
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Rol()
                            {
                                idRol = Convert.ToInt32(reader["IdRol"]),
                                descripcion = reader["Descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Rol>();
                }
            }

            return lista;
        }

    }
}
