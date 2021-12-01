using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;
namespace Proyecto
{
    public class OrdenesVenta:Conexion
    {

        public DataTable getOrdenVentas(DateTime fromDate, DateTime toDate)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    //Cambiar esto
                    command.Connection = connection;
                    command.CommandText = @"SELECT  o.id_Venta, 
                    o.fecha_orden,
                    concat_ws(' ',c.nombre_cliente,c.apellido_Paterno_cliente,c.apellido_materno_cliente) as nombre,
                    concat_ws(' ',oi1.cantidad,p.nombre_articulo) as detalle,
                    sum(cantidad*precio)  as total_amount    
                    from Venta o
                    inner join cliente c on c.id_cliente=o.id_cliente 
                    inner join Venta_Producto oi1 on oi1.id_Venta =o.id_Venta 
                    inner join producto p on p.id_Articulo = oi1.id_Articulo
                    where o.fecha_orden between @fromDate and @toDate
                    group by o.id_Venta, oi1.id_Venta, o.fecha_orden
                    order by o.id_Venta asc";
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
