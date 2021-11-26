using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto
{
    public partial class frmMenuPrincipal : Form
    {
        #region VARIABLES GLOBALES
        private Form frmFormularioActivo = null;

        //Variables que ayudan a poder modificar el tamaño de la forma
        private const int cGrip = 16, cCaption = 32;
        static bool estaMaximizada = false, estaLlena = false;
        static Point vieja_localizacion, default_localizacion;
        static Size viejo_tamano, default_tamano;


        #endregion

        #region METODOS INDEPENDIENTES
        //------------------------------------------------------------------------------------------------
        //Esto sirve para poder mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);


        //------------------------------------------------------------------------------------------------
        //Metodo para poder modificar el tamaño de la forma
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);

                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        #region METODOS PARA PODER MAXIMIZAR LA FORMA
        public static void setInitial(frmMenuPrincipal miMenu)
        {
            vieja_localizacion = miMenu.Location;
            viejo_tamano = miMenu.Size;
            default_localizacion = miMenu.Location;
            default_tamano = miMenu.Size;
        }
        public static void HacerMaximizacion(frmMenuPrincipal miMenu, Button btnMaximizar)
        {
            if (estaMaximizada == false)
            {
                vieja_localizacion = new Point(miMenu.Location.X, miMenu.Location.Y);
                viejo_tamano = new Size(miMenu.Size.Width, miMenu.Size.Height);
                Maximizar(miMenu);
                estaMaximizada = true;
                estaLlena = false;
            }
            else
            {
                miMenu.Location = vieja_localizacion;
                miMenu.Size = viejo_tamano;
                estaLlena = false;
                estaMaximizada = false;
            }
        }

        public static void HacerFullScreen(frmMenuPrincipal miMenu)
        {
            if (estaLlena == false)
            {
                vieja_localizacion = new Point(miMenu.Location.X, miMenu.Location.Y);
                viejo_tamano = new Size(miMenu.Size.Width, miMenu.Size.Height);
                Fullscreen(miMenu);
                estaMaximizada = false;
                estaLlena = true;
            }
            else
            {
                miMenu.Location = vieja_localizacion;
                miMenu.Size = viejo_tamano;
                Fullscreen(miMenu);
                estaLlena = false;
                estaMaximizada = false;
            }
        }
        static void Fullscreen(frmMenuPrincipal miMenu)
        {
            if (miMenu.WindowState == FormWindowState.Maximized)
                miMenu.WindowState = FormWindowState.Normal;
            else if (miMenu.WindowState == FormWindowState.Normal)
                miMenu.WindowState = FormWindowState.Maximized;
        }

        static void Maximizar(frmMenuPrincipal miMenu)
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            miMenu.WindowState = FormWindowState.Normal;
            miMenu.Location = new Point(0, 0);
            miMenu.Size = new Size(x, y);
        }
        #endregion

        private void PersonalizarDiseno()
        {
            
           
        }

        private void OcultarSubMenu()
        {

        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void AbrirFomulario(Form frmFormulario)
        {
            if (frmFormularioActivo != null)
                frmFormularioActivo.Close();
            frmFormularioActivo = frmFormulario;

            frmFormulario.TopLevel = false;
            frmFormulario.FormBorderStyle = FormBorderStyle.None;
            frmFormulario.Dock = DockStyle.Fill;

            panFormularios.Controls.Add(frmFormulario);
            panFormularios.Tag = frmFormulario;

            frmFormulario.BringToFront();
            frmFormulario.Show();
        }
        #endregion

        public frmMenuPrincipal()
        {
            InitializeComponent();
            PersonalizarDiseno();
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {

        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();

        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();

        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panCintillo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form miFormulario = new Login();
            miFormulario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void panFormularios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            HacerMaximizacion(this, btn);
        }
    }
}
