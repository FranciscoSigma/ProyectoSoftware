using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Proyecto
{
    public class OrdenesVenta:Conexion
    {

        public DataTable getOrdenVentas(DateTime fromDate, DateTime toDate)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Cambiar esto
                    command.Connection = connection;
                    command.CommandText = @"select  o.id_Venta, 
                                            o.fecha_orden,
                                            c.nombre_cliente+', '+c.apellido_Paterno_cliente as cliente, 
                                            producto=stuff((select ' - ' +'x'+convert(varchar (10),oi2.cantidad)+' '+ nombre_articulo
                                                  from Venta_Producto oi2
                                               inner join producto on producto.id_Articulo = oi2.id_Articulo
                                                  where oi2.id_Venta = oi1.id_Venta
                                                  for xml path('')), 1, 2, ''),
                                            sum((cantidad*precio)-descuento)  as total_amount    
                                        from Venta o
                                        inner join cliente c on c.id_cliente=o.id_cliente 
                                        inner join Venta_Producto oi1 on oi1.id_Venta =o.id_Venta 
                                        where o.fecha_orden between @fromDate and @toDate
                                        group by o.id_Venta, oi1.id_Venta, o.fecha_orden, c.nombre_cliente, c.apellido_Paterno_cliente
                                        order by o.id_Venta asc";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@fromDate", SqlDbType.Date).Value = fromDate;
                    command.Parameters.Add("@toDate", SqlDbType.Date).Value = toDate;
                    SqlDataReader reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }
    }
}
