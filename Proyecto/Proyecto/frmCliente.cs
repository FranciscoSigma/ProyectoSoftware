using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmCliente : Form
    {
        Conexion mysql = new Conexion();
        public frmCliente()
        {
            InitializeComponent();
        }
        private void limpiar()
        {
            txtTelefono.Text = "";
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente(txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, decimal.Parse(txtTelefono.Text));
                if (mysql.InsertCliente(c))
                {
                    MessageBox.Show("Cliente agregado correctamente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("no se a podido agregar el cliente");
                    limpiar();
                }
                dtgEmpleados = mysql.MostrarCliente(dtgEmpleados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente(txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, decimal.Parse(txtTelefono.Text));
                if (mysql.updateCliente(c, int.Parse(txtBuscarID.Text)))
                {
                    MessageBox.Show("cliente modificado correctamente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("no se pudo modificar");
                    limpiar();
                }
                dtgEmpleados = mysql.MostrarCliente(dtgEmpleados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mysql.deleteCliente(int.Parse(txtBuscarID.Text)))
                {
                    MessageBox.Show("cliente dado de baja correctamente");
                    dtgEmpleados = mysql.MostrarCliente(dtgEmpleados);
                    limpiar();
                }
                else
                    MessageBox.Show("No se ha podiod eliminar los datos");
                dtgEmpleados = mysql.MostrarCliente(dtgEmpleados);
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            dtgEmpleados = mysql.MostrarCliente(dtgEmpleados);
        }

        private void txtBuscarID_TextChanged(object sender, EventArgs e)
        {
            Cliente c = null;
            if (txtBuscarID.Text != "")
            {
                c = mysql.BuscarCliente(int.Parse(txtBuscarID.Text));
                dtgEmpleados.Rows.Clear();
                dtgEmpleados = mysql.MostrarClienteBuscado(dtgEmpleados, int.Parse(txtBuscarID.Text));
            }
            else
            {
                limpiar();
                dtgEmpleados = mysql.MostrarCliente(dtgEmpleados);
            }
            if (c != null)
            {
                txtNombre.Text = c.Nombre;
                txtApellidoMaterno.Text = c.ApellidoMaterno;
                txtApellidoPaterno.Text = c.ApellidoPaterno;
                txtTelefono.Text = c.Telefono.ToString();
            }
            else
            {
                limpiar();
            }
        }
    }
}
