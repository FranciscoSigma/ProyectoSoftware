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
    public partial class frmVenta : Form
    {
        Conexion mysql = new Conexion();

        private void limpiar()
        {
            txtcantidad.Text = "";
            txtidarticulo.Text = "";
            txtidventa.Text = "";
        }

        public frmVenta()
        {
            InitializeComponent();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            venta v = new venta(int.Parse(txtIdCliente.Text),DateTime.Now);
            if (mysql.InsertVenta(v))
            {
                MessageBox.Show("venta agregado correctamente");
                txtIdCliente.Text = "";
            }
            else
            {
                MessageBox.Show("no se a podido agregar la venta");
                txtIdCliente.Text = "";
            }
            dtgVenta = mysql.MostrarVenta(dtgVenta);
        }

        private void btnModificarVetna_Click(object sender, EventArgs e)
        {
            venta v = new venta(int.Parse(txtIdCliente.Text), DateTime.Now);
            if (mysql.updateVenta(v, int.Parse(txtBuscarDatosVentaID.Text)))
            {
                MessageBox.Show("venta modificado correctamente");
                txtIdCliente.Text = "";
            }
            else
            {
                MessageBox.Show("no se pudo modificar");
                txtIdCliente.Text = "";
            }
            dtgVenta = mysql.MostrarVenta(dtgVenta);
        }

        private void btneliminarVenta_Click(object sender, EventArgs e)
        {
            if (mysql.deleteVenta(int.Parse(txtBuscarDatosVentaID.Text)))
            {
                MessageBox.Show("venta dada de baja correctamente");
                dtgVenta = mysql.MostrarVenta(dtgVenta);
                txtIdCliente.Text = "";
            }
            else
                MessageBox.Show("No se ha podiod eliminar los datos");
            dtgVenta = mysql.MostrarVenta(dtgVenta);
            txtIdCliente.Text = "";
        }
        private void txtBuscarDatosVentaID_TextChanged(object sender, EventArgs e)
        {
            venta v = null;
            if (txtBuscarDatosVentaID.Text != "")
            {
                v = mysql.BuscarVenta(int.Parse(txtBuscarDatosVentaID.Text));
                dtgVenta.Rows.Clear();
                dtgVenta = mysql.MostrarVentaBuscada(dtgVenta, int.Parse(txtBuscarDatosVentaID.Text));
            }
            else
            {
                txtIdCliente.Text = "";
                dtgVenta = mysql.MostrarVenta(dtgVenta);
            }
            if (v != null)
            {
                txtIdCliente.Text = v.id_cliente.ToString();                
            }
            else
            {
                txtIdCliente.Text = "";
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {

        }
        private void txtBuscarIDVentaArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            dtgVenta = mysql.MostrarVenta(dtgVenta);
            dtgVentaArticulo = mysql.MostrarVentaProducto(dtgVentaArticulo);
        }
    }
}
