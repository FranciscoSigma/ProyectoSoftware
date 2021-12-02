namespace Proyecto
{
    partial class frmProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpRegistrosProductos = new System.Windows.Forms.GroupBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgProducto = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            this.lblBuscarEstudiante = new System.Windows.Forms.Label();
            this.grpDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comCategoria = new System.Windows.Forms.ComboBox();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarCategoriaID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombrecategoria = new System.Windows.Forms.TextBox();
            this.txtdescripcioncategoria = new System.Windows.Forms.TextBox();
            this.dtgcategoria = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnModCat = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.grpRegistrosProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).BeginInit();
            this.grpDatosEmpleado.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcategoria)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegistrosProductos
            // 
            this.grpRegistrosProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRegistrosProductos.Controls.Add(this.txtBuscarNombre);
            this.grpRegistrosProductos.Controls.Add(this.label1);
            this.grpRegistrosProductos.Controls.Add(this.dtgProducto);
            this.grpRegistrosProductos.Controls.Add(this.txtBuscarID);
            this.grpRegistrosProductos.Controls.Add(this.lblBuscarEstudiante);
            this.grpRegistrosProductos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegistrosProductos.ForeColor = System.Drawing.Color.Silver;
            this.grpRegistrosProductos.Location = new System.Drawing.Point(12, 416);
            this.grpRegistrosProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRegistrosProductos.Name = "grpRegistrosProductos";
            this.grpRegistrosProductos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRegistrosProductos.Size = new System.Drawing.Size(1386, 341);
            this.grpRegistrosProductos.TabIndex = 19;
            this.grpRegistrosProductos.TabStop = false;
            this.grpRegistrosProductos.Text = "Registros de Producto";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarNombre.BackColor = System.Drawing.Color.DarkGray;
            this.txtBuscarNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarNombre.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarNombre.Location = new System.Drawing.Point(729, 26);
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
            this.label1.Location = new System.Drawing.Point(526, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar producto (Nombre):";
            // 
            // dtgProducto
            // 
            this.dtgProducto.AllowUserToAddRows = false;
            this.dtgProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgProducto.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtgProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProducto.ColumnHeadersHeight = 60;
            this.dtgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Categoria,
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Inventario});
            this.dtgProducto.EnableHeadersVisualStyles = false;
            this.dtgProducto.GridColor = System.Drawing.Color.DarkGray;
            this.dtgProducto.Location = new System.Drawing.Point(19, 66);
            this.dtgProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgProducto.MultiSelect = false;
            this.dtgProducto.Name = "dtgProducto";
            this.dtgProducto.ReadOnly = true;
            this.dtgProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProducto.RowHeadersWidth = 60;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtgProducto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProducto.RowTemplate.Height = 24;
            this.dtgProducto.Size = new System.Drawing.Size(1346, 267);
            this.dtgProducto.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Inventario
            // 
            this.Inventario.HeaderText = "Inventario";
            this.Inventario.MinimumWidth = 6;
            this.Inventario.Name = "Inventario";
            this.Inventario.ReadOnly = true;
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarID.BackColor = System.Drawing.Color.DarkGray;
            this.txtBuscarID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarID.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarID.Location = new System.Drawing.Point(355, 26);
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
            this.lblBuscarEstudiante.Location = new System.Drawing.Point(192, 31);
            this.lblBuscarEstudiante.Name = "lblBuscarEstudiante";
            this.lblBuscarEstudiante.Size = new System.Drawing.Size(151, 20);
            this.lblBuscarEstudiante.TabIndex = 4;
            this.lblBuscarEstudiante.Text = "Buscar Producto (ID):";
            // 
            // grpDatosEmpleado
            // 
            this.grpDatosEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatosEmpleado.Controls.Add(this.tableLayoutPanel2);
            this.grpDatosEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosEmpleado.ForeColor = System.Drawing.Color.Silver;
            this.grpDatosEmpleado.Location = new System.Drawing.Point(12, 11);
            this.grpDatosEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosEmpleado.MaximumSize = new System.Drawing.Size(1000, 353);
            this.grpDatosEmpleado.Name = "grpDatosEmpleado";
            this.grpDatosEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosEmpleado.Size = new System.Drawing.Size(416, 322);
            this.grpDatosEmpleado.TabIndex = 17;
            this.grpDatosEmpleado.TabStop = false;
            this.grpDatosEmpleado.Text = "Datos del Producto";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Controls.Add(this.comCategoria, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtInventario, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPrecio, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtcodigo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtNombre, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(382, 313);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // comCategoria
            // 
            this.comCategoria.BackColor = System.Drawing.Color.DimGray;
            this.comCategoria.FormattingEnabled = true;
            this.comCategoria.Location = new System.Drawing.Point(136, 3);
            this.comCategoria.Name = "comCategoria";
            this.comCategoria.Size = new System.Drawing.Size(243, 35);
            this.comCategoria.TabIndex = 28;
            // 
            // txtInventario
            // 
            this.txtInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInventario.BackColor = System.Drawing.Color.DarkGray;
            this.txtInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInventario.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtInventario.Location = new System.Drawing.Point(136, 250);
            this.txtInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(243, 30);
            this.txtInventario.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(127, 62);
            this.label7.TabIndex = 1;
            this.label7.Text = "Categoria";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.BackColor = System.Drawing.Color.DarkGray;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecio.Location = new System.Drawing.Point(136, 188);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(243, 30);
            this.txtPrecio.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(3, 248);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(127, 65);
            this.label8.TabIndex = 9;
            this.label8.Text = "Inventario";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(3, 62);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(127, 62);
            this.label9.TabIndex = 2;
            this.label9.Text = "Codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcodigo.BackColor = System.Drawing.Color.DarkGray;
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtcodigo.Location = new System.Drawing.Point(136, 64);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(243, 30);
            this.txtcodigo.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(3, 124);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(127, 62);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(3, 186);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(127, 62);
            this.label11.TabIndex = 10;
            this.label11.Text = "Precio";
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
            this.txtNombre.Location = new System.Drawing.Point(136, 126);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 30);
            this.txtNombre.TabIndex = 15;
            // 
            // grpAcciones
            // 
            this.grpAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAcciones.Controls.Add(this.btnEliminarProducto);
            this.grpAcciones.Controls.Add(this.btnModificarProducto);
            this.grpAcciones.Controls.Add(this.btnAgregarProducto);
            this.grpAcciones.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAcciones.ForeColor = System.Drawing.Color.Silver;
            this.grpAcciones.Location = new System.Drawing.Point(441, 23);
            this.grpAcciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAcciones.Size = new System.Drawing.Size(204, 199);
            this.grpAcciones.TabIndex = 23;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Black;
            this.btnEliminarProducto.Location = new System.Drawing.Point(23, 147);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(150, 36);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.Black;
            this.btnModificarProducto.Location = new System.Drawing.Point(23, 88);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(150, 36);
            this.btnModificarProducto.TabIndex = 1;
            this.btnModificarProducto.Text = "modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.Location = new System.Drawing.Point(23, 33);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(150, 36);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtBuscarCategoriaID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.dtgcategoria);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(655, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.MaximumSize = new System.Drawing.Size(2000, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(501, 353);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos dela categoria";
            // 
            // txtBuscarCategoriaID
            // 
            this.txtBuscarCategoriaID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCategoriaID.BackColor = System.Drawing.Color.DarkGray;
            this.txtBuscarCategoriaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCategoriaID.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCategoriaID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarCategoriaID.Location = new System.Drawing.Point(254, 149);
            this.txtBuscarCategoriaID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCategoriaID.Name = "txtBuscarCategoriaID";
            this.txtBuscarCategoriaID.Size = new System.Drawing.Size(182, 30);
            this.txtBuscarCategoriaID.TabIndex = 14;
            this.txtBuscarCategoriaID.TextChanged += new System.EventHandler(this.txtBuscarCategoriaID_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Buscar ID";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.33F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtnombrecategoria, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtdescripcioncategoria, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 100);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(131, 50);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(131, 50);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripcion";
            // 
            // txtnombrecategoria
            // 
            this.txtnombrecategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombrecategoria.BackColor = System.Drawing.Color.DarkGray;
            this.txtnombrecategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombrecategoria.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecategoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtnombrecategoria.Location = new System.Drawing.Point(140, 2);
            this.txtnombrecategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombrecategoria.Name = "txtnombrecategoria";
            this.txtnombrecategoria.Size = new System.Drawing.Size(231, 30);
            this.txtnombrecategoria.TabIndex = 14;
            // 
            // txtdescripcioncategoria
            // 
            this.txtdescripcioncategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescripcioncategoria.BackColor = System.Drawing.Color.DarkGray;
            this.txtdescripcioncategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcioncategoria.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcioncategoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtdescripcioncategoria.Location = new System.Drawing.Point(140, 52);
            this.txtdescripcioncategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescripcioncategoria.Name = "txtdescripcioncategoria";
            this.txtdescripcioncategoria.Size = new System.Drawing.Size(231, 30);
            this.txtdescripcioncategoria.TabIndex = 15;
            // 
            // dtgcategoria
            // 
            this.dtgcategoria.AllowUserToAddRows = false;
            this.dtgcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgcategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgcategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgcategoria.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtgcategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgcategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgcategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgcategoria.ColumnHeadersHeight = 60;
            this.dtgcategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.dtgcategoria.EnableHeadersVisualStyles = false;
            this.dtgcategoria.GridColor = System.Drawing.Color.DarkGray;
            this.dtgcategoria.Location = new System.Drawing.Point(6, 186);
            this.dtgcategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgcategoria.MultiSelect = false;
            this.dtgcategoria.Name = "dtgcategoria";
            this.dtgcategoria.ReadOnly = true;
            this.dtgcategoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgcategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgcategoria.RowHeadersWidth = 60;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtgcategoria.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgcategoria.RowTemplate.Height = 24;
            this.dtgcategoria.Size = new System.Drawing.Size(489, 163);
            this.dtgcategoria.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnDeleteCat);
            this.groupBox2.Controls.Add(this.btnModCat);
            this.groupBox2.Controls.Add(this.btnAgregarCategoria);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(1173, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(204, 199);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.BackColor = System.Drawing.Color.Black;
            this.btnDeleteCat.Location = new System.Drawing.Point(23, 147);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(150, 36);
            this.btnDeleteCat.TabIndex = 2;
            this.btnDeleteCat.Text = "eliminar";
            this.btnDeleteCat.UseVisualStyleBackColor = false;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // btnModCat
            // 
            this.btnModCat.BackColor = System.Drawing.Color.Black;
            this.btnModCat.Location = new System.Drawing.Point(23, 88);
            this.btnModCat.Name = "btnModCat";
            this.btnModCat.Size = new System.Drawing.Size(150, 36);
            this.btnModCat.TabIndex = 1;
            this.btnModCat.Text = "modificar";
            this.btnModCat.UseVisualStyleBackColor = false;
            this.btnModCat.Click += new System.EventHandler(this.btnModCat_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.Black;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(23, 33);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(150, 36);
            this.btnAgregarCategoria.TabIndex = 0;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1452, 768);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpRegistrosProductos);
            this.Controls.Add(this.grpDatosEmpleado);
            this.DoubleBuffered = true;
            this.Name = "frmProducto";
            this.Text = "frmEmpleadosAdministrador";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.grpRegistrosProductos.ResumeLayout(false);
            this.grpRegistrosProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).EndInit();
            this.grpDatosEmpleado.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grpAcciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcategoria)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpRegistrosProductos;
        private System.Windows.Forms.TextBox txtBuscarID;
        private System.Windows.Forms.Label lblBuscarEstudiante;
        private System.Windows.Forms.GroupBox grpDatosEmpleado;
        private System.Windows.Forms.DataGridView dtgProducto;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarCategoriaID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombrecategoria;
        private System.Windows.Forms.TextBox txtdescripcioncategoria;
        private System.Windows.Forms.DataGridView dtgcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.Button btnModCat;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.ComboBox comCategoria;
    }
}