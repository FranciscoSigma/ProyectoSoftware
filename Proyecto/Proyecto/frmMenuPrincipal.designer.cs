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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogotipo = new System.Windows.Forms.PictureBox();
            this.panFormularios = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblBiblioTecos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panCintillo.SuspendLayout();
            this.panMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipo)).BeginInit();
            this.panFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCintillo
            // 
            this.panCintillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.panCintillo.Controls.Add(this.btnMaximizar);
            this.panCintillo.Controls.Add(this.btnMinimizar);
            this.panCintillo.Controls.Add(this.btnCerrar);
            this.panCintillo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panCintillo.Location = new System.Drawing.Point(0, 0);
            this.panCintillo.Name = "panCintillo";
            this.panCintillo.Size = new System.Drawing.Size(1600, 35);
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
            this.btnMaximizar.Location = new System.Drawing.Point(1535, 3);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1501, 3);
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
            this.btnCerrar.Location = new System.Drawing.Point(1569, 3);
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
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panMenu.Controls.Add(this.button6);
            this.panMenu.Controls.Add(this.button5);
            this.panMenu.Controls.Add(this.button4);
            this.panMenu.Controls.Add(this.button3);
            this.panMenu.Controls.Add(this.button2);
            this.panMenu.Controls.Add(this.button1);
            this.panMenu.Controls.Add(this.panel1);
            this.panMenu.Controls.Add(this.picLogotipo);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenu.Location = new System.Drawing.Point(0, 35);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(300, 815);
            this.panMenu.TabIndex = 1;
            this.panMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panMenu_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 152);
            this.panel1.TabIndex = 1;
            // 
            // picLogotipo
            // 
            this.picLogotipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogotipo.Image = global::Proyecto.Properties.Resources.icons8_game_64__1_;
            this.picLogotipo.Location = new System.Drawing.Point(0, 0);
            this.picLogotipo.Name = "picLogotipo";
            this.picLogotipo.Size = new System.Drawing.Size(300, 150);
            this.picLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogotipo.TabIndex = 0;
            this.picLogotipo.TabStop = false;
            // 
            // panFormularios
            // 
            this.panFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panFormularios.Controls.Add(this.lblSubtitulo);
            this.panFormularios.Controls.Add(this.lblBiblioTecos);
            this.panFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFormularios.Location = new System.Drawing.Point(300, 35);
            this.panFormularios.Name = "panFormularios";
            this.panFormularios.Size = new System.Drawing.Size(1300, 815);
            this.panFormularios.TabIndex = 2;
            this.panFormularios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panFormularios_MouseDown);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(307, 457);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(708, 49);
            this.lblSubtitulo.TabIndex = 3;
            this.lblSubtitulo.Text = "Bienvenido a la interfaz del sistema";
            // 
            // lblBiblioTecos
            // 
            this.lblBiblioTecos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBiblioTecos.AutoSize = true;
            this.lblBiblioTecos.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioTecos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            this.lblBiblioTecos.Location = new System.Drawing.Point(330, 302);
            this.lblBiblioTecos.Name = "lblBiblioTecos";
            this.lblBiblioTecos.Size = new System.Drawing.Size(726, 142);
            this.lblBiblioTecos.TabIndex = 2;
            this.lblBiblioTecos.Text = "GameTeca";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(47, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Empleados";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(47, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "Graficas";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(47, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 60);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cliente";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(47, 627);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 60);
            this.button4.TabIndex = 8;
            this.button4.Text = "Proveedor";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Location = new System.Drawing.Point(47, 707);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(226, 60);
            this.button5.TabIndex = 9;
            this.button5.Text = "Producto";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.Location = new System.Drawing.Point(47, 474);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(226, 60);
            this.button6.TabIndex = 10;
            this.button6.Text = "Vender";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1600, 850);
            this.Controls.Add(this.panFormularios);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panCintillo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1600, 850);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.panCintillo.ResumeLayout(false);
            this.panMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipo)).EndInit();
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
        private System.Windows.Forms.PictureBox picLogotipo;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label lblBiblioTecos;

        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}