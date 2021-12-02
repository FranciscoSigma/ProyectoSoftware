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
    public partial class frmProducto : Form
    {
        Conexion mysql = new Conexion();

        private void limpiarcontrolproducto()
        {
            txtNombre.Text = "";
            txtcodigo.Text = "";
            txtPrecio.Text = "";
            txtInventario.Text = "";
        }
        private void limpiarcontrolcategoria()
        {
            txtnombrecategoria.Text = "";
            txtdescripcioncategoria.Text = "";
        }

        public frmProducto()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            producto p = new producto((comCategoria.SelectedIndex+1), txtcodigo.Text, txtNombre.Text, decimal.Parse(txtPrecio.Text),
                int.Parse(txtInventario.Text));
            if (mysql.InsertProducto(p))
            {
                MessageBox.Show("producto guardado correctamnete");
                limpiarcontrolproducto();
            }
            else
            {
                MessageBox.Show("producto guardado correctamnete");
                limpiarcontrolproducto();
            }
            dtgProducto = mysql.MostrarProducto(dtgProducto);
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                producto p = new producto(comCategoria.SelectedIndex + 1, txtcodigo.Text, txtNombre.Text, decimal.Parse(txtPrecio.Text),
                int.Parse(txtInventario.Text));
                if (mysql.updateProducto(p, int.Parse(txtBuscarID.Text)))
                {
                    MessageBox.Show("Producto modificado correctamente");
                }
                else
                {
                    MessageBox.Show("no se pudo modificar el producto");
                }
                limpiarcontrolproducto();
                dtgProducto = mysql.MostrarProducto(dtgProducto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (mysql.deleteProducto(int.Parse(txtBuscarID.Text)))
                {
                    MessageBox.Show("producto dado de baja correctamente");
                    dtgProducto = mysql.MostrarProducto(dtgProducto);
                }
                else
                    MessageBox.Show("No se ha podiod eliminar los datos");
                limpiarcontrolproducto();
                dtgProducto = mysql.MostrarProducto(dtgProducto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarID_TextChanged(object sender, EventArgs e)
        {
            producto p = null;
            if (txtBuscarID.Text != "")
            {
                p = mysql.BuscarProducto(int.Parse(txtBuscarID.Text));
                dtgProducto.Rows.Clear();
                dtgProducto = mysql.MostrarProductoBuscado(dtgProducto, int.Parse(txtBuscarID.Text));
            }
            else
            {
                limpiarcontrolproducto();
                dtgProducto = mysql.MostrarProducto(dtgProducto);
            }
            if (p != null)
            {
                comCategoria.SelectedIndex = p.id_categoria-1;
                txtcodigo.Text = p.codigo;
                txtNombre.Text = p.Nombre;
                txtPrecio.Text = p.Precio.ToString();
                txtInventario.Text = p.Inventario.ToString();
            }
            else
            {
                limpiarcontrolproducto();
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            Categoria c = new Categoria(txtnombrecategoria.Text,txtdescripcioncategoria.Text);
            if (mysql.InsertCategoria(c))
            {
                MessageBox.Show("categoria guardada correctamnete");
                limpiarcontrolcategoria();
            }
            else
            {
                MessageBox.Show("categoria no se pudo guardar");
                limpiarcontrolcategoria();
            }
            dtgcategoria = mysql.MostrarCategoria(dtgcategoria);
            comCategoria = mysql.Mostrarcategoriascombobox(comCategoria);
        }

        private void btnModCat_Click(object sender, EventArgs e)
        {
            Categoria c = new Categoria(txtnombrecategoria.Text, txtdescripcioncategoria.Text);
            if (mysql.updatecategoria(c, int.Parse(txtBuscarCategoriaID.Text)))
            {
                MessageBox.Show("categoria modificado correctamente");
            }
            else
            {
                MessageBox.Show("no se pudo modificar la categoria");
            }
            limpiarcontrolcategoria();
            dtgcategoria = mysql.MostrarCategoria(dtgcategoria);
            comCategoria = mysql.Mostrarcategoriascombobox(comCategoria);
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            try
            {
                if (mysql.deleteCategoria(int.Parse(txtBuscarCategoriaID.Text)))
                {
                    MessageBox.Show("categoria dada de baja correctamente");
                    dtgcategoria = mysql.MostrarCategoria(dtgcategoria);
                }
                else
                    MessageBox.Show("No se ha podiod eliminar los datos");
                limpiarcontrolcategoria();
                dtgcategoria = mysql.MostrarCategoria(dtgcategoria);
                comCategoria = mysql.Mostrarcategoriascombobox(comCategoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarCategoriaID_TextChanged(object sender, EventArgs e)
        {
            Categoria c = null;
            if (txtBuscarCategoriaID.Text != "")
            {
                c = mysql.BuscarCategoria(int.Parse(txtBuscarCategoriaID.Text));
                dtgcategoria.Rows.Clear();
                dtgcategoria = mysql.MostrarCategoriaBuscada(dtgcategoria, int.Parse(txtBuscarCategoriaID.Text));
            }
            else
            {
                limpiarcontrolcategoria();
                dtgcategoria = mysql.MostrarCategoria(dtgcategoria);
            }
            if (c != null)
            {
                txtnombrecategoria.Text = c.Nombre;
                txtdescripcioncategoria.Text = c.Descripcion;
            }
            else
            {
                limpiarcontrolcategoria();
            }
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            dtgcategoria = mysql.MostrarCategoria(dtgcategoria);
            dtgProducto = mysql.MostrarProducto(dtgProducto);
            comCategoria = mysql.Mostrarcategoriascombobox(comCategoria);
            comCategoria.SelectedIndex = 0;
        }
    }
}
