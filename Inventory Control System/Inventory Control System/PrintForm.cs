using Microsoft.Reporting.WinForms;
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
    public partial class PrintForm :MetroFramework.Forms.MetroForm
    {
        Orders _orders;
        OrdersDetail _orderdetail;  
        List<OrdersDetail> _list;

        int u_id;
        public void setid(int a)
        {
            u_id = a;
        }
        public PrintForm(Orders orders ,List<OrdersDetail> list)
        {
            InitializeComponent();
            _orders = orders;
            _list = list;
           // _orderdetail = orderdetail;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportPath = "C:\\Users\\Udara Ranatunga\\Documents\\Visual Studio 2015\\Projects\\Inventory Control System\\Inventory Control System\\PrintPurchaseReceipt.rdlc";
                _orderdetail= OrdersDetailBindingSource.Current as OrdersDetail;
                reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                OrdersDetailBindingSource.DataSource = _list;
                Microsoft.Reporting.WinForms.ReportParameter[] rparams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                new Microsoft.Reporting.WinForms.ReportParameter("Purchase_OrderNo",_orders.Purchase_OrderNo.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Purchase_OrderDate",_orders.Purchase_OrderDate.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Item_Name",_orders.Item_Name.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Item_Qty",_orders.Item_Qty.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Sub_Total",_orders.Sub_Total.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Supplier_Name",_orders.Supplier_Name.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("Users_ID",_orders.Users_ID.ToString())

                };
                 reportViewer1.LocalReport.SetParameters(rparams);
                reportViewer1.RefreshReport();
            }
            catch(Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
