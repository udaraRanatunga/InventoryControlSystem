using Inventory_Control_System;
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
    public partial class Customer : MetroFramework.Forms.MetroForm
    {
        int u_id;
        public void setid(int a)
        {
            u_id = a;
        }
       

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mtCancel_Click(object sender, EventArgs e)
        {
            txtadd.Text = "";
            txtname.Text = "";
            txtnic.Text = "";
            txttele.Text = "";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PlaceOrder po = new PlaceOrder();
            this.Hide();
            po.Show();
        }

        
        
        private void btnadd_Click(object sender, EventArgs e)
        {

            String name;
            String add;
            int tp;
            String nic;
            int flag = 0;
            string item = "V";
            try
            {
                if (String.IsNullOrEmpty(txtname.Text) || String.IsNullOrEmpty(txtadd.Text) || String.IsNullOrEmpty(txttele.Text) || String.IsNullOrEmpty(txtnic.Text))
                {
                    flag = 1;
                    MessageBox.Show("Do not keep any fields empty", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                if (txtname.Text.Any(Char.IsDigit))
                {
                    flag = 1;

                    MessageBox.Show("Name cannot contain digits", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                if (item.Contains(txtnic.Text.Last()))
                {
                    flag = 0;
                }
                if (txttele.Text.Length != 10 )
                {
                    flag = 1;
                    MessageBox.Show("Wrong format of Telephone Number", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
                if (txtnic.Text.Length != 10)
                {
                    flag = 1;
                    MessageBox.Show("Wrong NIC number format ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (flag == 0)
                {
                    name = txtname.Text;
                    add = txtadd.Text;
                    tp = Convert.ToInt32(txttele.Text);
                    nic = txtnic.Text;
                    DBCustomer c = new DBCustomer();
                    int x = c.setCustomer(name, add, tp, nic, u_id);
                    if (x == 1)
                    {
                        this.Hide();
                        int no = c.getCus_No(name);
                        Sales_Orders so = new Sales_Orders();
                        so.Show();
                        so.setid(u_id, no);
                    }
                }



            }
            catch(Exception)
            {
                MessageBox.Show("An error occured please fill all the fields");
            }





        }

    }
}
