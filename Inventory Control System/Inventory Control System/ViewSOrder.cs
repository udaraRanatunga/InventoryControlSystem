using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    public partial class ViewSOrder : MetroFramework.Forms.MetroForm
    {
        int u_id,cus_no;
        public void setid(int a ,int b)
        {
            u_id = a;
            cus_no = b;
        }
        public ViewSOrder()
        {
            InitializeComponent();
        }

        private void ViewSOrder_Load(object sender, EventArgs e)
        {
            DBSales s = new DBSales();
            SqlDataAdapter da;
            da = s.getSalesOrders();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales_Orders s = new Sales_Orders();
            s.Show();
            s.setid(u_id,cus_no);
        }
    }
}
