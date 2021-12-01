using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Proyecto
{
    public abstract class Conexion
    {
        private readonly string connectionString;
        public Conexion()
        {
            connectionString = "server=192.254.224.20;port=3306;DataBase=gamineca_gameteca; User=gamineca_admin; password=admin";
        }
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
