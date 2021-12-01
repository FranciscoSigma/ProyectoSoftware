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
    public partial class ProductoMasVendido : Form
    {
        public ProductoMasVendido()
        {
            InitializeComponent();
        }

        private void ProductoMasVendido_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void LoadBestProductsReport(DateTime startDate, DateTime endDate)
        {
            SalesReport reportModel = new SalesReport();
            if(!chmenos.Checked)
                reportModel.createReporteProdcutosMasVendidos(startDate, endDate,1);
            else
                reportModel.createReporteProdcutosMenosVendidos(startDate, endDate, 1);
            SalesReportBindingSource.DataSource = reportModel;
            MejoresProductosBindingSource.DataSource = reportModel.listamejoresPorductos;
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;
            LoadBestProductsReport(fromDate, toDate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;
            LoadBestProductsReport(fromDate, toDate);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var toDate = DateTime.Now;
            LoadBestProductsReport(fromDate, toDate);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            var toDate = DateTime.Now;
            LoadBestProductsReport(fromDate, toDate);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var fromDate = dtmInicio.Value;
            var toDate = dtmFin.Value;
            LoadBestProductsReport(fromDate, new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59));
        }
    }
}
