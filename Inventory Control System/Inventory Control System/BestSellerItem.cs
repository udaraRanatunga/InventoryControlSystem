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
    public partial class BestSellerItem : MetroFramework.Forms.MetroForm
    {
        public BestSellerItem()
        {
            InitializeComponent();
        }

        private void BestSellerItem_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports r = new Reports();
            r.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (InventoryEntities4 db = new InventoryEntities4())
            {
                BestSellerReport_ResultBindingSource.DataSource = db.BestSellerReport(dtFromDate.Value.ToString(), dtToDate.Value.ToString()).ToList();
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
