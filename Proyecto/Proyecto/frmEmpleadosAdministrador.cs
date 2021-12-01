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
    public partial class frmEmpleadosAdministrador : Form
    {
        Conexion mysql = new Conexion();
        public frmEmpleadosAdministrador()
        {
            InitializeComponent();
            dtgEmpleados = mysql.MostrarEmpleado(dtgEmpleados);
        }
        private void limpiarcontrol()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            txtNombre.Text = "";
            txtApellidoMaterno.Text = "";
            txtApellidoPaterno.Text = "";
            txtEmail.Text = "";
            txtPuesto.Text = "";
            txtTelefono.Text = "";
        }

        private void frmEmpleadosAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado em = new Empleado(txtUsuario.Text, txtContrasena.Text, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, decimal.Parse(txtTelefono.Text), txtPuesto.Text, txtEmail.Text);
                if (mysql.InsertEmpleado(em))
                {
                    MessageBox.Show("Empleado guardado correctamnete");
                    limpiarcontrol();
                }
                else
                {
                    MessageBox.Show("Nose pudo guardar el empleado");
                    limpiarcontrol();
                }

                dtgEmpleados = mysql.MostrarEmpleado(dtgEmpleados);
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
                if (mysql.deleteEmpelado(int.Parse(txtBuscarID.Text)))
                {
                    MessageBox.Show("Empleado dado de baja correctamente");
                    dtgEmpleados = mysql.MostrarEmpleado(dtgEmpleados);
                }
                else
                    MessageBox.Show("No se ha podido eliminar los datos");
                dtgEmpleados = mysql.MostrarEmpleado(dtgEmpleados);
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
                Empleado em = new Empleado(txtUsuario.Text, txtContrasena.Text, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, decimal.Parse(txtTelefono.Text), txtPuesto.Text, txtEmail.Text);
                if (mysql.updateEmpleado(em, int.Parse(txtBuscarID.Text)))
                {
                    MessageBox.Show("empleado modificado correctamente");
                }
                else
                {
                    MessageBox.Show("no se a modificado el empleado");
                }
                dtgEmpleados = mysql.MostrarEmpleado(dtgEmpleados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarID_TextChanged(object sender, EventArgs e)
        {
            Empleado em = null;
            if (txtBuscarID.Text != "")
            {
                em = mysql.buscarempelado(int.Parse(txtBuscarID.Text));
                dtgEmpleados.Rows.Clear();
                dtgEmpleados = mysql.MostrarEmpleadoBuscado(dtgEmpleados, int.Parse(txtBuscarID.Text));

            }
            else
            {
                limpiarcontrol();
                dtgEmpleados = mysql.MostrarEmpleado(dtgEmpleados);
            }
            if (em != null)
            {
                txtUsuario.Text = em.usuario;
                txtContrasena.Text = em.Password;
                txtNombre.Text = em.Nombre;
                txtApellidoMaterno.Text = em.ApellidoMaterno;
                txtApellidoPaterno.Text = em.ApellidoPaterno;
                txtTelefono.Text = em.Telefono.ToString();
                txtPuesto.Text = em.Puesto;
                txtEmail.Text = em.Email;
            }
            else
            {
                limpiarcontrol();
            }
        }
    }
}
