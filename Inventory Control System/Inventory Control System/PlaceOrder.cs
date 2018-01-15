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
using System.Text.RegularExpressions;

namespace Inventory_Control_System
{
    public partial class PlaceOrder :MetroFramework.Forms.MetroForm
    {
        int u_id;
        String nic = "";
        int no=0;
        public void setid(int a)
        {
            u_id = a;
        }
        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            DBCustomer s = new DBCustomer();
            SqlDataReader DR= s.getNic();
            while (DR.Read())
            {
                comboBox1.Items.Add(DR[0]);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            nic=comboBox1.SelectedText.ToString();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer cus = new Customer();
            cus.Show();
            cus.setid(u_id);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            UserMenu um = new UserMenu();
            um.Show();
        }

        private void btnok_Click(object sender, EventArgs e)
        { if (comboBox1.SelectedIndex==0 || comboBox1.Text.Length!=10)
            {
                MessageBox.Show("Please select a NIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBCustomer cus = new DBCustomer();
                nic = comboBox1.SelectedItem.ToString();
                no = cus.getCusNo(nic);
                Sales_Orders s = new Sales_Orders();
                s.Show();
                s.setid(u_id, no);
                this.Hide();


            }



        }
    }
}
