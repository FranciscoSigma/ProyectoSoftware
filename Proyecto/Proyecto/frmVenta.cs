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
            venta v = new venta((cbocliente.SelectedIndex+1),DateTime.Now);
            if (mysql.InsertVenta(v))
            {
                MessageBox.Show("venta agregado correctamente");
            }
            else
            {
                MessageBox.Show("no se a podido agregar la venta");
            }
            dtgVenta = mysql.MostrarVenta(dtgVenta);
        }

        private void btnModificarVetna_Click(object sender, EventArgs e)
        {
            venta v = new venta((cbocliente.SelectedIndex + 1), DateTime.Now);
            if (mysql.updateVenta(v, int.Parse(txtBuscarDatosVentaID.Text)))
            {
                MessageBox.Show("venta modificado correctamente");
            }
            else
            {
                MessageBox.Show("no se pudo modificar");
            }
            dtgVenta = mysql.MostrarVenta(dtgVenta);
        }

        private void btneliminarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (mysql.deleteVenta(int.Parse(txtBuscarDatosVentaID.Text)))
                {
                    MessageBox.Show("venta dada de baja correctamente");
                    dtgVenta = mysql.MostrarVenta(dtgVenta);
                }
                else
                    MessageBox.Show("No se ha podiod eliminar los datos");
                dtgVenta = mysql.MostrarVenta(dtgVenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                dtgVenta = mysql.MostrarVenta(dtgVenta);
            }
            if (v != null)
            {
                cbocliente.SelectedIndex =v.id_cliente-1;              
            }
            else
            {
                
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            producto p = mysql.BuscarProducto(int.Parse(txtidarticulo.Text));
            VentaProducto xp = new VentaProducto(int.Parse(txtidventa.Text),int.Parse(txtidarticulo.Text),int.Parse(txtcantidad.Text),p.Precio);
            if(xp.cantidad <= p.Inventario && xp.cantidad != 0)
            {
                if (mysql.InsertVentaProducto(xp))
                {
                    p.Inventario = p.Inventario - xp.cantidad;
                    mysql.updateProducto(p, int.Parse(txtidarticulo.Text));
                    MessageBox.Show("no se a podido agregar la venta");
                }
                else
                {
                    MessageBox.Show("no se a podido agregar la venta");
                }
            }
            else
            {
                MessageBox.Show("La cantidad que se intenta vender es superior al inventario");
            }
            dtgVentaArticulo = mysql.MostrarVentaProducto(dtgVentaArticulo);
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            producto p = mysql.BuscarProducto(int.Parse(txtidarticulo.Text));
            VentaProducto xp = new VentaProducto(int.Parse(txtidventa.Text), int.Parse(txtidarticulo.Text), int.Parse(txtcantidad.Text), p.Precio);
            VentaProducto auxiliar = mysql.BuscarVentaProducto(int.Parse(txtBuscarIDVentaArticulo.Text));
            int auxiliarinventario = p.Inventario;
            p.Inventario = p.Inventario + auxiliar.cantidad;
            if(xp.cantidad <= p.Inventario && xp.cantidad != 0)
            {
                if(mysql.updateVentaProducto(xp, int.Parse(txtBuscarIDVentaArticulo.Text)))
                {
                    p.Inventario = p.Inventario - xp.cantidad;
                    mysql.updateProducto(p, int.Parse(txtidarticulo.Text));
                    MessageBox.Show("venta modificado correctamente");
                }
                else
                {
                    MessageBox.Show("no se pudo modificar");
                }
            }
            else
            {
                MessageBox.Show("La cantidad que se intenta vender es superior al inventario, no se modificara la compra");
            }
            dtgVentaArticulo = mysql.MostrarVentaProducto(dtgVentaArticulo);
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                VentaProducto auxiliar = mysql.BuscarVentaProducto(int.Parse(txtBuscarIDVentaArticulo.Text));
                producto p = mysql.BuscarProducto(int.Parse(txtidarticulo.Text));
                if (mysql.deleteVentaProducto(int.Parse(txtBuscarIDVentaArticulo.Text)))
                {
                    p.Inventario = p.Inventario + auxiliar.cantidad;
                    mysql.updateProducto(p, int.Parse(txtidarticulo.Text));
                    dtgVentaArticulo = mysql.MostrarVentaProducto(dtgVentaArticulo);
                    MessageBox.Show("venta dada de baja correctamente");

                }
                else
                    MessageBox.Show("No se ha podiod eliminar los datos");
                dtgVentaArticulo = mysql.MostrarVentaProducto(dtgVentaArticulo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtBuscarIDVentaArticulo_TextChanged(object sender, EventArgs e)
        {
            VentaProducto vp = null;
            if (txtBuscarIDVentaArticulo.Text != "")
            {
                vp = mysql.BuscarVentaProducto(int.Parse(txtBuscarIDVentaArticulo.Text));
                dtgVentaArticulo.Rows.Clear();
                dtgVentaArticulo = mysql.MostrarVentaProductoBuscada(dtgVentaArticulo, int.Parse(txtBuscarIDVentaArticulo.Text));
            }
            else
            {
                limpiar();
                dtgVentaArticulo = mysql.MostrarVentaProducto(dtgVentaArticulo);
            }
            if (vp != null)
            {
                txtidventa.Text = vp.id_Venta.ToString();
                txtidarticulo.Text = vp.id_Articulo.ToString();
                txtcantidad.Text = vp.cantidad.ToString();
            }
            else
            {
                limpiar();
            }
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            dtgVenta = mysql.MostrarVenta(dtgVenta);
            dtgVentaArticulo = mysql.MostrarVentaProducto(dtgVentaArticulo);
            cbocliente = mysql.MostrarClientecombobox(cbocliente);
            cbocliente.SelectedIndex = 0;
        }
    }
}
