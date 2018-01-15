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
    public partial class SalesReport : MetroFramework.Forms.MetroForm
    {
        int u_id;
        public void setid(int a)
        {
            u_id = a;
        }
        public SalesReport()
        {
            InitializeComponent();
        }

        private void SalesOrder_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMenu m = new ManagerMenu();
            m.Show();
            m.setid(u_id);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            using (InventoryEntities6 db = new InventoryEntities6())
            {
                GetSalesReport_ResultBindingSource.DataSource = db.GetSalesReport(dtFromDate.Value.ToString(), dtToDate.Value.ToString()).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("FromDate",dtFromDate.Value.Date.ToShortDateString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("ToDate", dtToDate.Value.Date.ToShortDateString())
                };
                reportViewer1.LocalReport.SetParameters(rParams);
                reportViewer1.RefreshReport();
            }

        }
    }
}
