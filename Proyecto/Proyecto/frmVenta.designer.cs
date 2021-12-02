namespace Proyecto
{
    partial class frmVenta
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
            this.txtBuscarIDArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgVentaArticulo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDvENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idarticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarIDVentaArticulo = new System.Windows.Forms.TextBox();
            this.lblBuscarEstudiante = new System.Windows.Forms.Label();
            this.grpDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtidventa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtidarticulo = new System.Windows.Forms.TextBox();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbocliente = new System.Windows.Forms.ComboBox();
            this.txtBuscarDatosVentaID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgVenta = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btneliminarVenta = new System.Windows.Forms.Button();
            this.btnModificarVetna = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.grpRegistrosProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaArticulo)).BeginInit();
            this.grpDatosEmpleado.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegistrosProductos
            // 
            this.grpRegistrosProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRegistrosProductos.Controls.Add(this.txtBuscarIDArticulo);
            this.grpRegistrosProductos.Controls.Add(this.label1);
            this.grpRegistrosProductos.Controls.Add(this.dtgVentaArticulo);
            this.grpRegistrosProductos.Controls.Add(this.txtBuscarIDVentaArticulo);
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
            this.grpRegistrosProductos.Text = "Registros Ventas de Articulos";
            // 
            // txtBuscarIDArticulo
            // 
            this.txtBuscarIDArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarIDArticulo.BackColor = System.Drawing.Color.DarkGray;
            this.txtBuscarIDArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarIDArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarIDArticulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarIDArticulo.Location = new System.Drawing.Point(729, 26);
            this.txtBuscarIDArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarIDArticulo.Name = "txtBuscarIDArticulo";
            this.txtBuscarIDArticulo.Size = new System.Drawing.Size(182, 30);
            this.txtBuscarIDArticulo.TabIndex = 12;
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
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar (ID Articulo):";
            // 
            // dtgVentaArticulo
            // 
            this.dtgVentaArticulo.AllowUserToAddRows = false;
            this.dtgVentaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVentaArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVentaArticulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVentaArticulo.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtgVentaArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgVentaArticulo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVentaArticulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVentaArticulo.ColumnHeadersHeight = 60;
            this.dtgVentaArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDvENTA,
            this.idarticulo,
            this.Inventario,
            this.Precio});
            this.dtgVentaArticulo.EnableHeadersVisualStyles = false;
            this.dtgVentaArticulo.GridColor = System.Drawing.Color.DarkGray;
            this.dtgVentaArticulo.Location = new System.Drawing.Point(19, 66);
            this.dtgVentaArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgVentaArticulo.MultiSelect = false;
            this.dtgVentaArticulo.Name = "dtgVentaArticulo";
            this.dtgVentaArticulo.ReadOnly = true;
            this.dtgVentaArticulo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVentaArticulo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgVentaArticulo.RowHeadersWidth = 60;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtgVentaArticulo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgVentaArticulo.RowTemplate.Height = 24;
            this.dtgVentaArticulo.Size = new System.Drawing.Size(1346, 267);
            this.dtgVentaArticulo.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Venta Articulo";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // IDvENTA
            // 
            this.IDvENTA.HeaderText = "Id Venta";
            this.IDvENTA.MinimumWidth = 6;
            this.IDvENTA.Name = "IDvENTA";
            this.IDvENTA.ReadOnly = true;
            // 
            // idarticulo
            // 
            this.idarticulo.HeaderText = "ID Articulo";
            this.idarticulo.MinimumWidth = 6;
            this.idarticulo.Name = "idarticulo";
            this.idarticulo.ReadOnly = true;
            // 
            // Inventario
            // 
            this.Inventario.HeaderText = "Cantidad";
            this.Inventario.MinimumWidth = 6;
            this.Inventario.Name = "Inventario";
            this.Inventario.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // txtBuscarIDVentaArticulo
            // 
            this.txtBuscarIDVentaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarIDVentaArticulo.BackColor = System.Drawing.Color.DarkGray;
            this.txtBuscarIDVentaArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarIDVentaArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarIDVentaArticulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarIDVentaArticulo.Location = new System.Drawing.Point(355, 26);
            this.txtBuscarIDVentaArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarIDVentaArticulo.Name = "txtBuscarIDVentaArticulo";
            this.txtBuscarIDVentaArticulo.Size = new System.Drawing.Size(153, 30);
            this.txtBuscarIDVentaArticulo.TabIndex = 7;
            this.txtBuscarIDVentaArticulo.TextChanged += new System.EventHandler(this.txtBuscarIDVentaArticulo_TextChanged);
            // 
            // lblBuscarEstudiante
            // 
            this.lblBuscarEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscarEstudiante.AutoSize = true;
            this.lblBuscarEstudiante.BackColor = System.Drawing.Color.Gray;
            this.lblBuscarEstudiante.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarEstudiante.ForeColor = System.Drawing.Color.White;
            this.lblBuscarEstudiante.Location = new System.Drawing.Point(168, 31);
            this.lblBuscarEstudiante.Name = "lblBuscarEstudiante";
            this.lblBuscarEstudiante.Size = new System.Drawing.Size(185, 20);
            this.lblBuscarEstudiante.TabIndex = 4;
            this.lblBuscarEstudiante.Text = "Buscar (ID Venta Articulo):";
            // 
            // grpDatosEmpleado
            // 
            this.grpDatosEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatosEmpleado.Controls.Add(this.tableLayoutPanel2);
            this.grpDatosEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosEmpleado.ForeColor = System.Drawing.Color.Silver;
            this.grpDatosEmpleado.Location = new System.Drawing.Point(833, 23);
            this.grpDatosEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosEmpleado.MaximumSize = new System.Drawing.Size(1000, 353);
            this.grpDatosEmpleado.Name = "grpDatosEmpleado";
            this.grpDatosEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDatosEmpleado.Size = new System.Drawing.Size(384, 322);
            this.grpDatosEmpleado.TabIndex = 17;
            this.grpDatosEmpleado.TabStop = false;
            this.grpDatosEmpleado.Text = "Articulos de la venta";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.9162F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0838F));
            this.tableLayoutPanel2.Controls.Add(this.txtcantidad, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtidventa, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtidarticulo, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(358, 272);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcantidad.BackColor = System.Drawing.Color.DarkGray;
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtcantidad.Location = new System.Drawing.Point(127, 182);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(228, 30);
            this.txtcantidad.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(118, 90);
            this.label9.TabIndex = 2;
            this.label9.Text = "id venta";
            // 
            // txtidventa
            // 
            this.txtidventa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtidventa.BackColor = System.Drawing.Color.DarkGray;
            this.txtidventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidventa.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidventa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtidventa.Location = new System.Drawing.Point(127, 2);
            this.txtidventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidventa.Name = "txtidventa";
            this.txtidventa.Size = new System.Drawing.Size(228, 30);
            this.txtidventa.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(3, 90);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(118, 90);
            this.label10.TabIndex = 9;
            this.label10.Text = "id articulo";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(3, 180);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(118, 92);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cantidad";
            // 
            // txtidarticulo
            // 
            this.txtidarticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtidarticulo.BackColor = System.Drawing.Color.DarkGray;
            this.txtidarticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidarticulo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidarticulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtidarticulo.Location = new System.Drawing.Point(127, 92);
            this.txtidarticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidarticulo.Name = "txtidarticulo";
            this.txtidarticulo.Size = new System.Drawing.Size(228, 30);
            this.txtidarticulo.TabIndex = 15;
            // 
            // grpAcciones
            // 
            this.grpAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAcciones.Controls.Add(this.btnEliminarArticulo);
            this.grpAcciones.Controls.Add(this.btnModificarArticulo);
            this.grpAcciones.Controls.Add(this.btnAgregarArticulo);
            this.grpAcciones.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAcciones.ForeColor = System.Drawing.Color.Silver;
            this.grpAcciones.Location = new System.Drawing.Point(1236, 48);
            this.grpAcciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAcciones.Size = new System.Drawing.Size(204, 199);
            this.grpAcciones.TabIndex = 23;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.Black;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(23, 147);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(150, 36);
            this.btnEliminarArticulo.TabIndex = 2;
            this.btnEliminarArticulo.Text = "eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.BackColor = System.Drawing.Color.Black;
            this.btnModificarArticulo.Location = new System.Drawing.Point(23, 88);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(150, 36);
            this.btnModificarArticulo.TabIndex = 1;
            this.btnModificarArticulo.Text = "modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = false;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.Black;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(23, 33);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(150, 36);
            this.btnAgregarArticulo.TabIndex = 0;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbocliente);
            this.groupBox1.Controls.Add(this.txtBuscarDatosVentaID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtgVenta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(31, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.MaximumSize = new System.Drawing.Size(2000, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(551, 353);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la venta";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cliente";
            // 
            // cbocliente
            // 
            this.cbocliente.BackColor = System.Drawing.Color.DimGray;
            this.cbocliente.FormattingEnabled = true;
            this.cbocliente.Location = new System.Drawing.Point(235, 34);
            this.cbocliente.Name = "cbocliente";
            this.cbocliente.Size = new System.Drawing.Size(299, 35);
            this.cbocliente.TabIndex = 15;
            // 
            // txtBuscarDatosVentaID
            // 
            this.txtBuscarDatosVentaID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarDatosVentaID.BackColor = System.Drawing.Color.DarkGray;
            this.txtBuscarDatosVentaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarDatosVentaID.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDatosVentaID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarDatosVentaID.Location = new System.Drawing.Point(352, 85);
            this.txtBuscarDatosVentaID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarDatosVentaID.Name = "txtBuscarDatosVentaID";
            this.txtBuscarDatosVentaID.Size = new System.Drawing.Size(182, 30);
            this.txtBuscarDatosVentaID.TabIndex = 14;
            this.txtBuscarDatosVentaID.TextChanged += new System.EventHandler(this.txtBuscarDatosVentaID_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(101, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Buscar ID";
            // 
            // dtgVenta
            // 
            this.dtgVenta.AllowUserToAddRows = false;
            this.dtgVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgVenta.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtgVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(146)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgVenta.ColumnHeadersHeight = 60;
            this.dtgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Paterno,
            this.materno});
            this.dtgVenta.EnableHeadersVisualStyles = false;
            this.dtgVenta.GridColor = System.Drawing.Color.DarkGray;
            this.dtgVenta.Location = new System.Drawing.Point(6, 147);
            this.dtgVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgVenta.MultiSelect = false;
            this.dtgVenta.Name = "dtgVenta";
            this.dtgVenta.ReadOnly = true;
            this.dtgVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgVenta.RowHeadersWidth = 60;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtgVenta.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgVenta.RowTemplate.Height = 24;
            this.dtgVenta.Size = new System.Drawing.Size(545, 202);
            this.dtgVenta.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 119;
            // 
            // Paterno
            // 
            this.Paterno.HeaderText = "Ap. Paterno";
            this.Paterno.MinimumWidth = 6;
            this.Paterno.Name = "Paterno";
            this.Paterno.ReadOnly = true;
            this.Paterno.Width = 138;
            // 
            // materno
            // 
            this.materno.HeaderText = "Ap. Materno";
            this.materno.MinimumWidth = 6;
            this.materno.Name = "materno";
            this.materno.ReadOnly = true;
            this.materno.Width = 145;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btneliminarVenta);
            this.groupBox2.Controls.Add(this.btnModificarVetna);
            this.groupBox2.Controls.Add(this.btnAgregarVenta);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(609, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(204, 199);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btneliminarVenta
            // 
            this.btneliminarVenta.BackColor = System.Drawing.Color.Black;
            this.btneliminarVenta.Location = new System.Drawing.Point(23, 147);
            this.btneliminarVenta.Name = "btneliminarVenta";
            this.btneliminarVenta.Size = new System.Drawing.Size(150, 36);
            this.btneliminarVenta.TabIndex = 2;
            this.btneliminarVenta.Text = "eliminar";
            this.btneliminarVenta.UseVisualStyleBackColor = false;
            this.btneliminarVenta.Click += new System.EventHandler(this.btneliminarVenta_Click);
            // 
            // btnModificarVetna
            // 
            this.btnModificarVetna.BackColor = System.Drawing.Color.Black;
            this.btnModificarVetna.Location = new System.Drawing.Point(23, 88);
            this.btnModificarVetna.Name = "btnModificarVetna";
            this.btnModificarVetna.Size = new System.Drawing.Size(150, 36);
            this.btnModificarVetna.TabIndex = 1;
            this.btnModificarVetna.Text = "modificar";
            this.btnModificarVetna.UseVisualStyleBackColor = false;
            this.btnModificarVetna.Click += new System.EventHandler(this.btnModificarVetna_Click);
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.BackColor = System.Drawing.Color.Black;
            this.btnAgregarVenta.Location = new System.Drawing.Point(23, 33);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(150, 36);
            this.btnAgregarVenta.TabIndex = 0;
            this.btnAgregarVenta.Text = "Agregar";
            this.btnAgregarVenta.UseVisualStyleBackColor = false;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // frmVenta
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
            this.Name = "frmVenta";
            this.Text = "frmEmpleadosAdministrador";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.grpRegistrosProductos.ResumeLayout(false);
            this.grpRegistrosProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaArticulo)).EndInit();
            this.grpDatosEmpleado.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grpAcciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpRegistrosProductos;
        private System.Windows.Forms.TextBox txtBuscarIDVentaArticulo;
        private System.Windows.Forms.Label lblBuscarEstudiante;
        private System.Windows.Forms.GroupBox grpDatosEmpleado;
        private System.Windows.Forms.DataGridView dtgVentaArticulo;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.TextBox txtBuscarIDArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtidventa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtidarticulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarDatosVentaID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btneliminarVenta;
        private System.Windows.Forms.Button btnModificarVetna;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDvENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbocliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn materno;
    }
}