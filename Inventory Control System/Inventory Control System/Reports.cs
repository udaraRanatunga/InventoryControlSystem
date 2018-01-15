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
    public partial class Reports : MetroFramework.Forms.MetroForm
    {
        int u_id;
        public void setid(int a)
        {
            u_id = a;
        }
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeliveryReport dr = new DeliveryReport();
            dr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            ManagerMenu um = new ManagerMenu();
            um.Show();
        }

        private void mtSales_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            this.Hide();
            sr.Show();

        }

        private void mtPurch_Click(object sender, EventArgs e)
        {
            Purchase_Report p = new Purchase_Report();
            this.Hide();
            p.Show();

        }

        private void mtStockStatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockStatusReport ssr = new StockStatusReport();
            ssr.Show();
        }

        private void mtBestSeller_Click(object sender, EventArgs e)
        {
            BestSellerItem b = new BestSellerItem();
            this.Hide();
            b.Show();
        }
    }
}
