using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto
{
    class DatosUsuario : Conexion
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Empleados where user=@user and password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.LoginName = reader.GetString(1);
                            UserLoginCache.Password = reader.GetString(2);
                            UserLoginCache.Nombre = reader.GetString(3);
                            UserLoginCache.ApellidoPaterno = reader.GetString(4);
                            UserLoginCache.ApellidoMaterno = reader.GetString(5);
                            UserLoginCache.Puesto = reader.GetString(6);
                            UserLoginCache.Email = reader.GetString(7);
                            UserLoginCache.Telefono = reader.GetDecimal(8);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
