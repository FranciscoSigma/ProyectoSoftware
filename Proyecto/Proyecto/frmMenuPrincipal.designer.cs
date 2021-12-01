namespace Proyecto

{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panCintillo = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLogout = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProductosMasVendiso = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnEmpelados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblapellidos = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lnlPuesto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panFormularios = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblBiblioTecos = new System.Windows.Forms.Label();
            this.panCintillo.SuspendLayout();
            this.panMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCintillo
            // 
            this.panCintillo.BackColor = System.Drawing.Color.DimGray;
            this.panCintillo.Controls.Add(this.btnMaximizar);
            this.panCintillo.Controls.Add(this.btnMinimizar);
            this.panCintillo.Controls.Add(this.btnCerrar);
            this.panCintillo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panCintillo.Location = new System.Drawing.Point(0, 0);
            this.panCintillo.Name = "panCintillo";
            this.panCintillo.Size = new System.Drawing.Size(1770, 35);
            this.panCintillo.TabIndex = 0;
            this.panCintillo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panCintillo_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(1705, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(28, 30);
            this.btnMaximizar.TabIndex = 14;
            this.btnMaximizar.Text = "□";
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(1671, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 30);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1739, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 30);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panMenu
            // 
            this.panMenu.AutoScroll = true;
            this.panMenu.BackColor = System.Drawing.Color.DimGray;
            this.panMenu.Controls.Add(this.pictureBox2);
            this.panMenu.Controls.Add(this.lblLogout);
            this.panMenu.Controls.Add(this.btnReporte);
            this.panMenu.Controls.Add(this.btnVender);
            this.panMenu.Controls.Add(this.btnInventario);
            this.panMenu.Controls.Add(this.btnProductosMasVendiso);
            this.panMenu.Controls.Add(this.btncliente);
            this.panMenu.Controls.Add(this.btnProveedor);
            this.panMenu.Controls.Add(this.btnEmpelados);
            this.panMenu.Controls.Add(this.panel1);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenu.Location = new System.Drawing.Point(0, 35);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(300, 815);
            this.panMenu.TabIndex = 1;
            this.panMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panMenu_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.logout;
            this.pictureBox2.Location = new System.Drawing.Point(39, 764);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.Location = new System.Drawing.Point(86, 767);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(142, 25);
            this.lblLogout.TabIndex = 12;
            this.lblLogout.Text = "Cerrar sesión";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.DimGray;
            this.btnReporte.Location = new System.Drawing.Point(39, 593);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(226, 60);
            this.btnReporte.TabIndex = 11;
            this.btnReporte.Text = "Reporte por periodo";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.DimGray;
            this.btnVender.Location = new System.Drawing.Point(39, 329);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(226, 60);
            this.btnVender.TabIndex = 10;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.DimGray;
            this.btnInventario.Location = new System.Drawing.Point(39, 395);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(226, 60);
            this.btnInventario.TabIndex = 9;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnProductosMasVendiso
            // 
            this.btnProductosMasVendiso.BackColor = System.Drawing.Color.DimGray;
            this.btnProductosMasVendiso.Location = new System.Drawing.Point(39, 527);
            this.btnProductosMasVendiso.Name = "btnProductosMasVendiso";
            this.btnProductosMasVendiso.Size = new System.Drawing.Size(226, 60);
            this.btnProductosMasVendiso.TabIndex = 6;
            this.btnProductosMasVendiso.Text = "Productos mas vendidos";
            this.btnProductosMasVendiso.UseVisualStyleBackColor = false;
            this.btnProductosMasVendiso.Click += new System.EventHandler(this.btnProductosMasVendiso_Click);
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.Color.DimGray;
            this.btncliente.Location = new System.Drawing.Point(39, 254);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(226, 60);
            this.btncliente.TabIndex = 7;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.DimGray;
            this.btnProveedor.Location = new System.Drawing.Point(39, 461);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(226, 60);
            this.btnProveedor.TabIndex = 8;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = false;
            // 
            // btnEmpelados
            // 
            this.btnEmpelados.BackColor = System.Drawing.Color.DimGray;
            this.btnEmpelados.Location = new System.Drawing.Point(39, 186);
            this.btnEmpelados.Name = "btnEmpelados";
            this.btnEmpelados.Size = new System.Drawing.Size(226, 60);
            this.btnEmpelados.TabIndex = 0;
            this.btnEmpelados.Text = "Empleados";
            this.btnEmpelados.UseVisualStyleBackColor = false;
            this.btnEmpelados.Click += new System.EventHandler(this.btnEmpelados_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lblapellidos);
            this.panel1.Controls.Add(this.lblnombre);
            this.panel1.Controls.Add(this.lnlPuesto);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 152);
            this.panel1.TabIndex = 1;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(119, 97);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(65, 20);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "Email:";
            // 
            // lblapellidos
            // 
            this.lblapellidos.AutoSize = true;
            this.lblapellidos.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidos.Location = new System.Drawing.Point(119, 67);
            this.lblapellidos.Name = "lblapellidos";
            this.lblapellidos.Size = new System.Drawing.Size(85, 20);
            this.lblapellidos.TabIndex = 3;
            this.lblapellidos.Text = "apellidos";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(119, 47);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(85, 20);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre:";
            // 
            // lnlPuesto
            // 
            this.lnlPuesto.AutoSize = true;
            this.lnlPuesto.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlPuesto.Location = new System.Drawing.Point(119, 18);
            this.lnlPuesto.Name = "lnlPuesto";
            this.lnlPuesto.Size = new System.Drawing.Size(66, 20);
            this.lnlPuesto.TabIndex = 1;
            this.lnlPuesto.Text = "Puesto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(4, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panFormularios
            // 
            this.panFormularios.BackColor = System.Drawing.Color.Gray;
            this.panFormularios.Controls.Add(this.lblSubtitulo);
            this.panFormularios.Controls.Add(this.lblBiblioTecos);
            this.panFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFormularios.Location = new System.Drawing.Point(300, 35);
            this.panFormularios.Name = "panFormularios";
            this.panFormularios.Size = new System.Drawing.Size(1470, 815);
            this.panFormularios.TabIndex = 2;
            this.panFormularios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panFormularios_MouseDown);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(392, 457);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(708, 49);
            this.lblSubtitulo.TabIndex = 3;
            this.lblSubtitulo.Text = "Bienvenido a la interfaz del sistema";
            // 
            // lblBiblioTecos
            // 
            this.lblBiblioTecos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBiblioTecos.AutoSize = true;
            this.lblBiblioTecos.BackColor = System.Drawing.Color.Gray;
            this.lblBiblioTecos.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioTecos.ForeColor = System.Drawing.Color.White;
            this.lblBiblioTecos.Location = new System.Drawing.Point(415, 302);
            this.lblBiblioTecos.Name = "lblBiblioTecos";
            this.lblBiblioTecos.Size = new System.Drawing.Size(726, 142);
            this.lblBiblioTecos.TabIndex = 2;
            this.lblBiblioTecos.Text = "GameTeca";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1770, 850);
            this.Controls.Add(this.panFormularios);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panCintillo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1600, 850);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.panCintillo.ResumeLayout(false);
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panFormularios.ResumeLayout(false);
            this.panFormularios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCintillo;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Panel panFormularios;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;

        private System.Windows.Forms.Label lblBiblioTecos;

        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnProductosMasVendiso;
        private System.Windows.Forms.Button btnEmpelados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblapellidos;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lnlPuesto;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLogout;
    }
}