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
    public partial class UserMenu : MetroFramework.Forms.MetroForm
    {
        int u_id;
        public UserMenu()
        {
            InitializeComponent();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }

        private void mtSup_Click(object sender, EventArgs e)
        {
            Suppliers s = new Suppliers();
            s.Show();
            this.Hide();
            s.setid(u_id);
        }

        private void mtCus_Click(object sender, EventArgs e)
        {
            
            UpdateCustomer c = new UpdateCustomer();
            c.Show();
            this.Hide();
            c.setid(u_id);
            
        }

        private void mtItems_Click(object sender, EventArgs e)
        {
            Items i = new Items();
            i.Show();
            this.Hide();
            i.setid(u_id);

   
        }

        private void mtSalesRet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales_Returns sr = new Sales_Returns();
            sr.Show();
            sr.setid(u_id);
        }

        private void mtGrn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Generate_GRN gr = new Generate_GRN();
            gr.Show();
            gr.setid(u_id);
        }

        private void mtPurchRet_Click(object sender, EventArgs e)
        {
            this.Hide();
           Purchase_Returns pr = new Purchase_Returns();
            pr.Show();
            pr.setid(u_id);
        }

        private void mtDelivery_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delivery d = new Delivery();
            d.Show();
            d.setid(u_id);
        }

        private void mtSalesOrd_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlaceOrder po = new PlaceOrder();
            po.Show();
            po.setid(u_id);

        }

        private void mtPurchOrd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Purchase_Order p =new Purchase_Order();
            p.Show();
            p.setid(u_id);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login um = new Login();
            um.Show();
        }

        public void setid(int a)
        {
            u_id = a;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }
    }
}
