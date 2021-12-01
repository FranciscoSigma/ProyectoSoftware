using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto.conexion
{
    class ProductosMasVendidos: Conexion
    {

        public DataTable getMejoresVentas(DateTime fromDate, DateTime toDate)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    //Cambiar esto
                    command.Connection = connection;
                    command.CommandText = @"SELECT  
                    p.id_Articulo,
                    p.nombre_articulo,
                    p.precio_Articulo as precio_unitario,
                    SUM(oi.cantidad) as cantidadvendida,
                    SUM(oi.precio*oi.cantidad) as VentaTotal
                    FROM
                    Venta o
                    inner join Venta_Producto oi on oi.id_Venta =o.id_Venta 
                    inner join producto p on p.id_Articulo = oi.id_Articulo
                    where o.fecha_orden between @startDate and @toDate
                    GROUP by p.id_Articulo,p.nombre_articulo,p.precio_Articulo
                    ORDER by cantidadvendida DESC LIMIT 0,10
                    ";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@fromDate", MySqlDbType.Date).Value = fromDate;
                    command.Parameters.Add("@toDate", MySqlDbType.Date).Value = toDate;
                    MySqlDataReader reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }
    }
}
