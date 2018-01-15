using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    public partial class Purchase_Report : MetroFramework.Forms.MetroForm
    {
        public Purchase_Report()
        {
            InitializeComponent();
        }

        private void Purchase_Report_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports re = new Reports();
            re.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           using (InventoryEntities db = new InventoryEntities())
            {
                GetPurchaseReport_ResultBindingSource.DataSource = db.GetPurchaseReport(dtFromDate.Value.ToString(), dtToDate.Value.ToString()).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("FromDate",dtFromDate.Value.Date.ToShortDateString()),
                     new Microsoft.Reporting.WinForms.ReportParameter("ToDate", dtToDate.Value.Date.ToShortDateString())

                };
                reportViewer1.LocalReport.SetParameters(rParams);
                reportViewer1.RefreshReport();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
