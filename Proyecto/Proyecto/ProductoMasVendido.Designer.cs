
namespace Proyecto
{
    partial class ProductoMasVendido
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SalesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MejoresProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chmenos = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtmFin = new System.Windows.Forms.DateTimePicker();
            this.dtmInicio = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MejoresProductosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesReportBindingSource
            // 
            this.SalesReportBindingSource.DataSource = typeof(Proyecto.SalesReport);
            // 
            // MejoresProductosBindingSource
            // 
            this.MejoresProductosBindingSource.DataSource = typeof(Proyecto.MejoresProductos);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SalesReportBindingSource;
            reportDataSource2.Name = "MejoresPorductos";
            reportDataSource2.Value = this.MejoresProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto.productosmasvendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(891, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.chmenos);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtmFin);
            this.panel1.Controls.Add(this.dtmInicio);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 79);
            this.panel1.TabIndex = 1;
            // 
            // chmenos
            // 
            this.chmenos.AutoSize = true;
            this.chmenos.Location = new System.Drawing.Point(751, 26);
            this.chmenos.Name = "chmenos";
            this.chmenos.Size = new System.Drawing.Size(135, 21);
            this.chmenos.TabIndex = 9;
            this.chmenos.Text = "Menos Vendidos";
            this.chmenos.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(639, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 45);
            this.button5.TabIndex = 8;
            this.button5.Text = "Mostrar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desde";
            // 
            // dtmFin
            // 
            this.dtmFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFin.Location = new System.Drawing.Point(500, 36);
            this.dtmFin.Name = "dtmFin";
            this.dtmFin.Size = new System.Drawing.Size(114, 22);
            this.dtmFin.TabIndex = 5;
            // 
            // dtmInicio
            // 
            this.dtmInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmInicio.Location = new System.Drawing.Point(500, 13);
            this.dtmInicio.Name = "dtmInicio";
            this.dtmInicio.Size = new System.Drawing.Size(114, 22);
            this.dtmInicio.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ultimo año";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 45);
            this.button4.TabIndex = 2;
            this.button4.Text = "Ultimo mes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ultimos 7 dias";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hoy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductoMasVendido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ProductoMasVendido";
            this.Text = "ProductoMasVendido";
            this.Load += new System.EventHandler(this.ProductoMasVendido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MejoresProductosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesReportBindingSource;
        private System.Windows.Forms.BindingSource MejoresProductosBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmFin;
        private System.Windows.Forms.DateTimePicker dtmInicio;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chmenos;
    }
}