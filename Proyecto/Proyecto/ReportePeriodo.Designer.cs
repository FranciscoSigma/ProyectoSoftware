
namespace Proyecto
{
    partial class ReportePeriodo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.HOY = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NetSalesByPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.dtmInicio = new System.Windows.Forms.DateTimePicker();
            this.dtmFin = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NetSalesByPeriodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesListingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.dtmFin);
            this.panel1.Controls.Add(this.dtmInicio);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.HOY);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "ESTE AÑO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "ULTIMOS 30 DIAS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 43);
            this.button4.TabIndex = 2;
            this.button4.Text = "ESTE MES";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "ULTIMOS 7 DIAS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HOY
            // 
            this.HOY.Location = new System.Drawing.Point(23, 12);
            this.HOY.Name = "HOY";
            this.HOY.Size = new System.Drawing.Size(171, 43);
            this.HOY.TabIndex = 0;
            this.HOY.Text = "HOY";
            this.HOY.UseVisualStyleBackColor = true;
            this.HOY.Click += new System.EventHandler(this.HOY_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "NetSalesByPeriod";
            reportDataSource4.Value = this.NetSalesByPeriodBindingSource;
            reportDataSource5.Name = "SalesListing";
            reportDataSource5.Value = this.SalesListingBindingSource;
            reportDataSource6.Name = "SalesReport";
            reportDataSource6.Value = this.SalesReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(200, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(600, 450);
            this.reportViewer1.TabIndex = 2;
            // 
            // NetSalesByPeriodBindingSource
            // 
            this.NetSalesByPeriodBindingSource.DataSource = typeof(Proyecto.NetSalesByPeriod);
            // 
            // SalesListingBindingSource
            // 
            this.SalesListingBindingSource.DataSource = typeof(Proyecto.SalesListing);
            // 
            // SalesReportBindingSource
            // 
            this.SalesReportBindingSource.DataSource = typeof(Proyecto.SalesReport);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 257);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 43);
            this.button5.TabIndex = 5;
            this.button5.Text = "CUSTOM";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dtmInicio
            // 
            this.dtmInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmInicio.Location = new System.Drawing.Point(76, 318);
            this.dtmInicio.Name = "dtmInicio";
            this.dtmInicio.Size = new System.Drawing.Size(118, 22);
            this.dtmInicio.TabIndex = 6;
            // 
            // dtmFin
            // 
            this.dtmFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFin.Location = new System.Drawing.Point(76, 346);
            this.dtmFin.Name = "dtmFin";
            this.dtmFin.Size = new System.Drawing.Size(118, 22);
            this.dtmFin.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 384);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 43);
            this.button6.TabIndex = 8;
            this.button6.Text = "Mostrar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hasta:";
            // 
            // ReportePeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "ReportePeriodo";
            this.Text = "ReportePeriodo";
            this.Load += new System.EventHandler(this.ReportePeriodo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NetSalesByPeriodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesListingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button HOY;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NetSalesByPeriodBindingSource;
        private System.Windows.Forms.BindingSource SalesListingBindingSource;
        private System.Windows.Forms.BindingSource SalesReportBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker dtmFin;
        private System.Windows.Forms.DateTimePicker dtmInicio;
        private System.Windows.Forms.Button button5;
    }
}