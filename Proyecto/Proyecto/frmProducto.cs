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

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnModCat_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarCategoriaID_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            dtgcategoria = mysql.MostrarCategoria(dtgcategoria);
            dtgProducto = mysql.MostrarProducto(dtgProducto);
            comCategoria = mysql.Mostrarcategoriascombobox(comCategoria);
        }
    }
}
