namespace Proyecto
{
    partial class frmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpRegistrosEmpleados = new System.Windows.Forms.GroupBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            this.lblBuscarEstudiante = new System.Windows.Forms.Label();
            this.grpDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar  (Nombre):";
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgEmpleados.ColumnHeadersHeight = 60;
            this.dtgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.Telefono});
            this.dtgEmpleados.EnableHeadersVisualStyles = false;
            this.dtgEmpleados.GridColor = System.Drawing.Color.DarkGray;
            this.dtgEmpleados.Location = new System.Drawing.Point(19, 66);
            this.dtgEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgEmpleados.MultiSelect = false;
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.ReadOnly = true;
            this.dtgEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgEmpleados.RowHeadersWidth = 60;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtgEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle12;
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
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
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
            this.lblBuscarEstudiante.Size = new System.Drawing.Size(89, 20);
            this.lblBuscarEstudiante.TabIndex = 4;
            this.lblBuscarEstudiante.Text = "Buscar  (ID):";
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
            this.grpDatosEmpleado.Text = "Datos del Cliente";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtTelefono, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCuenta, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblApellidoPaterno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtApellidoPaterno, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblApellidoMaterno, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtApellidoMaterno, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(831, 307);
            this.tableLayoutPanel1.TabIndex = 24;
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
            this.txtTelefono.Location = new System.Drawing.Point(418, 230);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(410, 30);
            this.txtTelefono.TabIndex = 21;
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
            this.lblNombre.Size = new System.Drawing.Size(409, 76);
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
            this.txtNombre.Location = new System.Drawing.Point(418, 2);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(410, 30);
            this.txtNombre.TabIndex = 7;
            // 
            // lblCuenta
            // 
            this.lblCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.ForeColor = System.Drawing.Color.Silver;
            this.lblCuenta.Location = new System.Drawing.Point(3, 228);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblCuenta.Size = new System.Drawing.Size(409, 79);
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
            this.lblApellidoPaterno.Location = new System.Drawing.Point(3, 76);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblApellidoPaterno.Size = new System.Drawing.Size(409, 76);
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
            this.txtApellidoPaterno.Location = new System.Drawing.Point(418, 78);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(410, 30);
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
            this.lblApellidoMaterno.Location = new System.Drawing.Point(3, 152);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblApellidoMaterno.Size = new System.Drawing.Size(409, 76);
            this.lblApellidoMaterno.TabIndex = 9;
            this.lblApellidoMaterno.Text = "Apellido materno:";
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
            this.txtApellidoMaterno.Location = new System.Drawing.Point(418, 154);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(410, 30);
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
            // frmCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1282, 768);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpRegistrosEmpleados);
            this.Controls.Add(this.grpDatosEmpleado);
            this.DoubleBuffered = true;
            this.Name = "frmCliente";
            this.Text = "frmCliente";
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
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}