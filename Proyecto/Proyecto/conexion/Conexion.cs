using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Proyecto
{
    public class Conexion
    {
        static string connectionString = "server=192.254.224.20;port=3306;DataBase=gamineca_gameteca; User=gamineca_admin; password=admin";
        public Conexion()
        {
            connectionString = "server=192.254.224.20;port=3306;DataBase=gamineca_gameteca; User=gamineca_admin; password=admin";
        }
        MySqlConnection cnn = new MySqlConnection(connectionString);
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
        public void abrirConexion()
        {
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void cerrarConexion()
        {
            cnn.Close();
        }

        #region Empleado

        public DataGridView MostrarEmpleado(DataGridView dtg)
        {
            dtg.Rows.Clear();
            abrirConexion();
            if (UserLoginCache.Puesto == "administrador")
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Empleados", cnn);
                MySqlDataReader consultar;
                consultar = cmd.ExecuteReader();
                while (consultar.Read())
                {
                    dtg.Rows.Add(consultar.GetInt32(0), consultar.GetString(3), consultar.GetString(4), consultar.GetString(5),
                        consultar.GetString(1), consultar.GetString(2), consultar.GetDecimal(8), consultar.GetString(6), consultar.GetString(7)
                        );
                }
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT IDEmpleado,nombre,apellido_paterno,apellido_materno,telefono,Posicion,email FROM Empleados", cnn);
                MySqlDataReader consultar;
                consultar = cmd.ExecuteReader();
                while (consultar.Read())
                {
                    dtg.Rows.Add(consultar.GetInt32(0), consultar.GetString(1), consultar.GetString(2), consultar.GetString(3), "", "",
                        consultar.GetDecimal(4), consultar.GetString(5), consultar.GetString(6)
                        );
                }
            }


            cerrarConexion();
            return dtg;
        }

        public bool InsertEmpleado(Empleado e)
        {
            abrirConexion();
            string cmd = "insert into Empleados values(null,'" + e.usuario + "', '" + e.Password + "', '" + e.Nombre +
                "', '" + e.ApellidoPaterno + "', '" + e.ApellidoMaterno + "', '" + e.Puesto + "', '" + e.Email + "'," + e.Telefono + "); ";
            MySqlCommand query = new MySqlCommand(cmd, cnn);
            int filas = query.ExecuteNonQuery();
            if (filas > 0)
            {
                cerrarConexion();
                return true;
            }
            else
            {
                cerrarConexion();
                return false;
            }
        }

        public Empleado buscarempelado(int id_empleado)
            {
                abrirConexion();
                if (UserLoginCache.Puesto == "administrador")
                {
                    string cmd = "select * from Empleados where IDEmpleado = " + id_empleado;
                    MySqlCommand query = new MySqlCommand(cmd, cnn);
                    MySqlDataReader consultar;
                    consultar = query.ExecuteReader();
                    Empleado e;
                    while (consultar.Read())
                    {
                        e = new Empleado(consultar.GetString(1), consultar.GetString(2), consultar.GetString(3),
                            consultar.GetString(4), consultar.GetString(5), consultar.GetDecimal(8), consultar.GetString(6), consultar.GetString(7));
                        cerrarConexion();
                        return e;
                    }
                }
                else
                {
                    string cmd = "SELECT IDEmpleado,nombre,apellido_paterno,apellido_materno,telefono,Posicion,email FROM Empleados where IDEmpleado = " + id_empleado;
                    MySqlCommand query = new MySqlCommand(cmd, cnn);
                    MySqlDataReader consultar;
                    consultar = query.ExecuteReader();
                    Empleado e;
                    while (consultar.Read())
                    {
                        e = new Empleado("", "", consultar.GetString(1),
                            consultar.GetString(2), consultar.GetString(3), consultar.GetDecimal(4), consultar.GetString(5), consultar.GetString(6));
                        cerrarConexion();
                        return e;
                    }
                }
                cerrarConexion();
                return null;
            }

        public bool updateEmpleado(Empleado e, int id_empleado)
        {
            abrirConexion();
            string cmd = ("update Empleados set user = '" + e.usuario + "', password = '" + e.Password +
                "', nombre = '" + e.Nombre + "',apellido_paterno = '" + e.ApellidoPaterno +
                "', apellido_materno = '" + e.ApellidoMaterno + "',Posicion = '" + e.Puesto + "',email = '" + e.Email +
                "',telefono = " + e.Telefono + " where IDEmpleado = " + id_empleado + "; ");
            MySqlCommand query = new MySqlCommand(cmd, cnn);
            int filas = query.ExecuteNonQuery();
            if (filas > 0)
            {
                cerrarConexion();
                return true;
            }
            else
            {
                cerrarConexion();
                return false;
            }
        }

        public bool deleteEmpelado(int numcontrol)
        {
            abrirConexion();
            string cmd = "delete from Empleados where IDEmpleado = " + numcontrol;
            MySqlCommand query = new MySqlCommand(cmd, cnn);
            int filas = query.ExecuteNonQuery();
            if (filas > 0)
            {
                cerrarConexion();
                return true;
            }
            else
            {
                cerrarConexion();
                return false;
            }
        }

        public DataGridView MostrarEmpleadoBuscado(DataGridView dtg, int id_empleado)
        {
            dtg.Rows.Clear();
            abrirConexion();
            if (UserLoginCache.Puesto == "administrador")
            {
                string cmd = "select * from Empleados where IDEmpleado like '%" + id_empleado + "%'";
                MySqlCommand query = new MySqlCommand(cmd, cnn);
                MySqlDataReader consultar;
                consultar = query.ExecuteReader();
                while (consultar.Read())
                {
                    dtg.Rows.Add(consultar.GetInt32(0), consultar.GetString(3), consultar.GetString(4), consultar.GetString(5),
                        consultar.GetString(1), consultar.GetString(2), consultar.GetDecimal(8), consultar.GetString(6), consultar.GetString(7)
                        );
                }
            }
            else
            {
                string cmd = "SELECT IDEmpleado,nombre,apellido_paterno,apellido_materno,telefono,Posicion,email FROM Empleados where IDEmpleado like '%" + id_empleado + "%'";
                MySqlCommand query = new MySqlCommand(cmd, cnn);
                MySqlDataReader consultar;
                consultar = query.ExecuteReader();
                while (consultar.Read())
                {
                    dtg.Rows.Add(consultar.GetInt32(0), consultar.GetString(1), consultar.GetString(2), consultar.GetString(3), "", "",
                        consultar.GetDecimal(4), consultar.GetString(5), consultar.GetString(6));
                }
            }
            cerrarConexion();
            return dtg;
        }

        #endregion

        #region Cliente
        public DataGridView MostrarCliente(DataGridView dtg)
        {
            dtg.Rows.Clear();
            abrirConexion();
            MySqlCommand cmd = new MySqlCommand("select * from cliente", cnn);
            MySqlDataReader consultar;
            consultar = cmd.ExecuteReader();
            while (consultar.Read())
            {
                dtg.Rows.Add(consultar.GetDecimal(0), consultar.GetString(1), consultar.GetString(2), consultar.GetString(3),
                    consultar.GetDecimal(4));
            }
            cerrarConexion();
            return dtg;
        }

        public bool InsertCliente(Cliente c)
        {
            abrirConexion();
            string cmd = "insert into cliente values(null,'" + c.Nombre + "', '" + c.ApellidoPaterno + "', '" + c.ApellidoMaterno +"'," + c.Telefono + "); ";
            MySqlCommand query = new MySqlCommand(cmd, cnn);
            int filas = query.ExecuteNonQuery();
            if (filas > 0)
            {
                cerrarConexion();
                return true;
            }
            else
            {
                cerrarConexion();
                return false;
            }
        }
        public Cliente BuscarCliente(int id_cliente)
        {
            abrirConexion();
                string cmd = "select * from cliente where id_cliente = " + id_cliente;
                MySqlCommand query = new MySqlCommand(cmd, cnn);
                MySqlDataReader consultar;
                consultar = query.ExecuteReader();
                Cliente c;
                while (consultar.Read())
                {
                    c = new Cliente(consultar.GetString(1), consultar.GetString(2), consultar.GetString(3),
                        consultar.GetDecimal(4));
                    cerrarConexion();
                    return c;
                }
            cerrarConexion();
            return null;
        }

        public bool updateCliente(Cliente c, int id_cliente)
        {
            abrirConexion();
            string cmd = ("update cliente set nombre_cliente = '" + c.Nombre + "',apellido_Paterno_cliente = '" + c.ApellidoPaterno +
                "', apellido_materno_cliente = '" + c.ApellidoMaterno + "',telefono = " + c.Telefono + " where id_cliente = " + id_cliente + "; ");
            MySqlCommand query = new MySqlCommand(cmd, cnn);
            int filas = query.ExecuteNonQuery();
            if (filas > 0)
            {
                cerrarConexion();
                return true;
            }
            else
            {
                cerrarConexion();
                return false;
            }
        }

        public bool deleteCliente(int id_cliente)
        {
            abrirConexion();
            string cmd = "delete from cliente where id_cliente = " + id_cliente;
            MySqlCommand query = new MySqlCommand(cmd, cnn);
            int filas = query.ExecuteNonQuery();
            if (filas > 0)
            {
                cerrarConexion();
                return true;
            }
            else
            {
                cerrarConexion();
                return false;
            }
        }

        public DataGridView MostrarClienteBuscado(DataGridView dtg, int id_cliente)
        {
            dtg.Rows.Clear();
            abrirConexion();
            string cmd = "select * from cliente where id_cliente like '%" + id_cliente + "%'";
            MySqlCommand query = new MySqlCommand(cmd, cnn);
            MySqlDataReader consultar;
            consultar = query.ExecuteReader();
            while (consultar.Read())
            {
                dtg.Rows.Add(consultar.GetInt32(0), consultar.GetString(1), consultar.GetString(2), consultar.GetString(3),
                consultar.GetDecimal(4));
            }
            cerrarConexion();
            return dtg;
        }

        #endregion

        #region Categoria
        public DataGridView MostrarCategoria(DataGridView dtg)
        {
            dtg.Rows.Clear();
            abrirConexion();
            MySqlCommand cmd = new MySqlCommand("select * from categoria", cnn);
            MySqlDataReader consultar;
            consultar = cmd.ExecuteReader();
            while (consultar.Read())
            {
                dtg.Rows.Add(consultar.GetDecimal(0), consultar.GetString(1), consultar.GetString(2));
            }
            cerrarConexion();
            return dtg;
        }

        public bool InsertCategoria(Categoria c)
        {
            abrirConexion();
            string cmd = "insert into categoria values(null,'" + c.Nombre + "', '" + c.Descripcion + "'); ";
            MySqlCommand query = new MySqlCommand(cmd, cnn);
            int filas = query.ExecuteNonQuery();
            if (filas > 0)
            {
                cerrarConexion();
                return true;
            }
            else
            {
                cerrarConexion();
                return false;
            }
        }
        public Categoria BuscarCategoria(int id_categoria)
        {
            abrirConexion();
            string cmd = "select * from categoria where id_categoria = " + id_categoria;
            MySqlCommand query = new MySqlCommand(cmd, cnn);
            MySqlDataReader consultar;
            consultar = query.ExecuteReader();
            Categoria c;
            while (consultar.Read())
            {
                c = new Categoria(consultar.GetString(1), consultar.GetString(2));
                cerrarConexion();
                return c;
            }
            cerrarConexion();
            return null;
        }

        public bool updatecategoria(Categoria c, int id_categoria)
        {
            abrirConexion();
            string cmd = ("update categoria set nombre_categoria = '" + c.Nombre + "',descripcion_categoria = '" + c.Descripcion  + "; ");
            MySqlCommand query = new MySqlCommand(cmd, cnn);
            int filas = query.ExecuteNonQuery();
            if (filas > 0)
            {
                cerrarConexion();
                return true;
            }
            else
            {
                cerrarConexion();
                return false;
            }
        }

        public bool deleteCategoria(int id_categoria)
        {
            abrirConexion();
            string cmd = "delete from categoria where id_categoria = " + id_categoria;
            MySqlCommand query = new MySqlCommand(cmd, cnn);
            int filas = query.ExecuteNonQuery();
            if (filas > 0)
            {
                cerrarConexion();
                return true;
            }
            else
            {
                cerrarConexion();
                return false;
            }
        }

        public DataGridView MostrarCategoriaBuscada(DataGridView dtg, int id_categoria)
        {
            dtg.Rows.Clear();
            abrirConexion();
            string cmd = "select * from categoria where id_categoria like '%" + id_categoria + "%'";
            MySqlCommand query = new MySqlCommand(cmd, cnn);
            MySqlDataReader consultar;
            consultar = query.ExecuteReader();
            while (consultar.Read())
            {
                dtg.Rows.Add(consultar.GetInt32(0), consultar.GetString(1), consultar.GetString(2));
            }
            cerrarConexion();
            return dtg;
        }

        #endregion
    }
}
