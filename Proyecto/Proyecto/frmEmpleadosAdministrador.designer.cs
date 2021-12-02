namespace Proyecto
{
    partial class frmEmpleadosAdministrador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpRegistrosEmpleados = new System.Windows.Forms.GroupBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            this.lblBuscarEstudiante = new System.Windows.Forms.Label();
            this.grpDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpRegistrosEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.grpDatosEmpleado.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegistrosEmpleados
            // 
            this.grpRegistrosEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRegistrosEmpleados.Controls.Add(this.txtBuscarNombre);
            this.grpRegistrosEmpleados.Controls.Add(this.label1);
            this.grpRegistrosEmpleados.Controls.Add(this.dtgEmpleados);
            this.grpRegistrosEmpleados.Controls.Add(this.txtBuscarID);
            this.grpRegistrosEmpleados.Controls.Add(this.lblBuscarEstudiante);
            this.grpRegistrosEmpleados.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegistrosEmpleados.ForeColor = System.Drawing.Color.Silver;
            this.grpRegistrosEmpleados.Location = new System.Drawing.Point(12, 416);
            this.grpRegistrosEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRegistrosEmpleados.Name = "grpRegistrosEmpleados";
            this.grpRegistrosEmpleados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRegistrosEmpleados.Size = new System.Drawing.Size(1216, 341);
            this.grpRegistrosEmpleados.TabIndex = 19;
            this.grpRegistrosEmpleados.TabStop = false;
            this.grpRegistrosEmpleados.Text = "Registros de empleados";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarNombre.BackColor = System.Drawing.Color.DarkGray;
            this.txtBuscarNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarNombre.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarNombre.Location = new System.Drawing.Point(559, 26);
            this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(182, 30);
            this.txtBuscarNombre.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(356, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar empleado (Nombre):";
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.AllowUserToAddRows = false;
            this.dtgEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgEmpleados.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtgEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgEmpleados.ColumnHeadersHeight = 60;
            this.dtgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.usuario,
            this.Contrasena,
            this.Telefono,
            this.Puesto,
            this.email});
            this.dtgEmpleados.EnableHeadersVisualStyles = false;
            this.dtgEmpleados.GridColor = System.Drawing.Color.DarkGray;
            this.dtgEmpleados.Location = new System.Drawing.Point(19, 66);
            this.dtgEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgEmpleados.MultiSelect = false;
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.ReadOnly = true;
            this.dtgEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgEmpleados.RowHeadersWidth = 60;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtgEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgEmpleados.RowTemplate.Height = 24;
            this.dtgEmpleados.Size = new System.Drawing.Size(1176, 267);
            this.dtgEmpleados.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.HeaderText = "Apellido paterno";
            this.ApellidoPaterno.MinimumWidth = 6;
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.ReadOnly = true;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "Apellido materno";
            this.ApellidoMaterno.MinimumWidth = 6;
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // Contrasena
            // 
            this.Contrasena.HeaderText = "Contraseña";
            this.Contrasena.MinimumWidth = 6;
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.MinimumWidth = 6;
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarID.BackColor = System.Drawing.Color.DarkGray;
            this.txtBuscarID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarID.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarID.Location = new System.Drawing.Point(185, 26);
            this.txtBuscarID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(153, 30);
            this.txtBuscarID.TabIndex = 7;
            this.txtBuscarID.TextChanged += new System.EventHandler(this.txtBuscarID_TextChanged);
            // 
            // lblBuscarEstudiante
            // 
            this.lblBuscarEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscarEstudiante.AutoSize = true;
            this.lblBuscarEstudiante.BackColor = System.Drawing.Color.Gray;
            this.lblBuscarEstudiante.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarEstudiante.ForeColor = System.Drawing.Color.White;
            this.lblBuscarEstudiante.Location = new System.Drawing.Point(22, 31);
            this.lblBuscarEstudiante.Name = "lblBuscarEstudiante";
            this.lblBuscarEstudiante.Size = new System.Drawing.Size(157, 20);
            this.lblBuscarEstudiante.TabIndex = 4;
            this.lblBuscarEstudiante.Text = "Buscar empleado (ID):";
            // 
            // grpDatosEmpleado
            // 
            this.grpDatosEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatosEmpleado.Controls.Add(this.tableLayoutPanel1);
            this.grpDatosEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosEmpleado.ForeColor = System.Drawing.Color.Silver;
            this.grpDatosEmpleado.Location = new System.Drawing.Point(12, 11);
            this.grpDatosEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosEmpleado.MaximumSize = new System.Drawing.Size(1000, 353);
            this.grpDatosEmpleado.Name = "grpDatosEmpleado";
            this.grpDatosEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosEmpleado.Size = new System.Drawing.Size(852, 353);
            this.grpDatosEmpleado.TabIndex = 17;
            this.grpDatosEmpleado.TabStop = false;
            this.grpDatosEmpleado.Text = "Datos del empleado";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtContrasena, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtUsuario, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefono, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblContraseña, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPuesto, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCuenta, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblApellidoPaterno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtApellidoPaterno, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblApellidoMaterno, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTelefono, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtApellidoMaterno, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(827, 313);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContrasena.BackColor = System.Drawing.Color.DarkGray;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtContrasena.Location = new System.Drawing.Point(416, 275);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(408, 30);
            this.txtContrasena.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.DarkGray;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(416, 197);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(408, 30);
            this.txtEmail.TabIndex = 17;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.Location = new System.Drawing.Point(416, 236);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(408, 30);
            this.txtUsuario.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(3, 234);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(407, 39);
            this.label3.TabIndex = 17;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 195);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(407, 39);
            this.label2.TabIndex = 17;
            this.label2.Text = "Email:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.BackColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.Location = new System.Drawing.Point(416, 158);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(408, 30);
            this.txtTelefono.TabIndex = 21;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.Silver;
            this.lblContraseña.Location = new System.Drawing.Point(3, 273);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblContraseña.Size = new System.Drawing.Size(407, 40);
            this.lblContraseña.TabIndex = 9;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblNombre.Size = new System.Drawing.Size(407, 39);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.DarkGray;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Location = new System.Drawing.Point(416, 2);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(408, 30);
            this.txtNombre.TabIndex = 7;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPuesto.BackColor = System.Drawing.Color.DarkGray;
            this.txtPuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPuesto.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPuesto.Location = new System.Drawing.Point(416, 119);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(408, 30);
            this.txtPuesto.TabIndex = 17;
            // 
            // lblCuenta
            // 
            this.lblCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.ForeColor = System.Drawing.Color.Silver;
            this.lblCuenta.Location = new System.Drawing.Point(3, 156);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblCuenta.Size = new System.Drawing.Size(407, 39);
            this.lblCuenta.TabIndex = 9;
            this.lblCuenta.Text = "Telefono:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.ForeColor = System.Drawing.Color.Silver;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(3, 39);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblApellidoPaterno.Size = new System.Drawing.Size(407, 39);
            this.lblApellidoPaterno.TabIndex = 2;
            this.lblApellidoPaterno.Text = "Apellido paterno:";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoPaterno.BackColor = System.Drawing.Color.DarkGray;
            this.txtApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(416, 41);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(408, 30);
            this.txtApellidoPaterno.TabIndex = 9;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.ForeColor = System.Drawing.Color.Silver;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(3, 78);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblApellidoMaterno.Size = new System.Drawing.Size(407, 39);
            this.lblApellidoMaterno.TabIndex = 9;
            this.lblApellidoMaterno.Text = "Apellido materno:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Silver;
            this.lblTelefono.Location = new System.Drawing.Point(3, 117);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblTelefono.Size = new System.Drawing.Size(407, 39);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Puesto:";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoMaterno.BackColor = System.Drawing.Color.DarkGray;
            this.txtApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(416, 80);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(408, 30);
            this.txtApellidoMaterno.TabIndex = 15;
            // 
            // grpAcciones
            // 
            this.grpAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAcciones.Controls.Add(this.btnEliminar);
            this.grpAcciones.Controls.Add(this.btnModificar);
            this.grpAcciones.Controls.Add(this.btnAgregar);
            this.grpAcciones.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAcciones.ForeColor = System.Drawing.Color.Silver;
            this.grpAcciones.Location = new System.Drawing.Point(1024, 11);
            this.grpAcciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAcciones.Size = new System.Drawing.Size(204, 199);
            this.grpAcciones.TabIndex = 23;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(23, 147);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 36);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(23, 88);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 36);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(23, 33);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 36);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmEmpleadosAdministrador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1282, 768);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpRegistrosEmpleados);
            this.Controls.Add(this.grpDatosEmpleado);
            this.DoubleBuffered = true;
            this.Name = "frmEmpleadosAdministrador";
            this.Text = "frmEmpleadosAdministrador";
            this.Load += new System.EventHandler(this.frmEmpleadosAdministrador_Load);
            this.grpRegistrosEmpleados.ResumeLayout(false);
            this.grpRegistrosEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.grpDatosEmpleado.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpRegistrosEmpleados;
        private System.Windows.Forms.TextBox txtBuscarID;
        private System.Windows.Forms.Label lblBuscarEstudiante;
        private System.Windows.Forms.GroupBox grpDatosEmpleado;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}