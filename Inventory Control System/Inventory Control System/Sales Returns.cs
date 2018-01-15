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
    public partial class Sales_Returns : MetroFramework.Forms.MetroForm
    {
        int u_id,count_qty, count_tot,cusno;
       
        SqlDataReader DR = null, DR2= null;
        public void setid(int a)
        {
            u_id = a;
        }
        public Sales_Returns()
        {
            InitializeComponent();
        }

        private void Sales_Returns_Load(object sender, EventArgs e)
        {
            txtdate.Text = System.DateTime.Now.ToString("M/d/yyyy");
          
           
            DBCustomer sd = new DBCustomer();
            DR  = sd.getNic();
            while(DR.Read())
            {
                cmbcusnic.Items.Add(DR[0]);
            }
            

           
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Sales_Returns sr = new Sales_Returns();
            sr.Show();
            sr.setid(u_id);

            

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            UserMenu um = new UserMenu();
            um.Show();
            um.setid(u_id);
        }

        private void cmbitemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Qty = 0;
            DBSales_Item_reference sal = new DBSales_Item_reference();
            String itemname = cmbitemname.SelectedItem.ToString();
            DBItem i = new DBItem();
            int itemno= i.getItemNo(itemname);
            DR=  sal.getQty(itemno);
            while (DR.Read())
            {
               Qty=Convert.ToInt32(DR[0]);
            }
                        
            numQty.Maximum = Qty;
            numQty.Value = Qty;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            

            DBCustomer c = new DBCustomer();
             cusno= c.getCusNo(cmbcusnic.SelectedItem.ToString());
            DBSales s = new DBSales();
            DR = s.getSalesOrder(cusno);
            while(DR.Read())
            {
                cmbsorder.Items.Add(Convert.ToInt32(DR[0]));
            }
           
        }

        private void cmbsorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int so_no = Convert.ToInt32(cmbsorder.SelectedItem);
            DBSales_Item_reference si = new DBSales_Item_reference();
            DR = si.getItems(so_no);
            int itemno;
            String itemname="";
            while (DR.Read())
            {
                itemno = Convert.ToInt32(DR[0]);
                DBItem i = new DBItem();
                DR2= i.getName(itemno);
                while(DR2.Read())
                {
                    itemname = DR2[0].ToString();
                }
                cmbitemname.Items.Add(itemname);
               

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (numQty.Value!=0)
            {
                DBItem i = new DBItem();
                int no = i.getItemNo(cmbitemname.Text.ToString());
                int qty = Convert.ToInt32(numQty.Value);
                int price = i.getItemPrice(cmbitemname.Text.ToString());
                
                int subtot = price * qty;
                String[] row = { no.ToString(), qty.ToString(), subtot.ToString() };
                dataGridView1.Rows.Add(row);
                count_qty = count_qty + qty;
                count_tot = count_tot + subtot;
                txtprice.Text = count_tot.ToString();
                txttotqty.Text = count_qty.ToString();
            }
            else
            {
                MessageBox.Show("Please select item return quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mtAdd_Click(object sender, EventArgs e)
        {
            int error = 0;
            if (cmbcusnic.SelectedIndex==0)
            {
                error = 1;
                MessageBox.Show("Please select a NIC number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (cmbitemname.SelectedIndex==0)
            {
                error = 1;
                MessageBox.Show("Please select an Item Name");
            }
            if (txttotqty.Text.Length == 0 && txtprice.Text.Length == 0)
            {
                error = 1;
                MessageBox.Show("Please fill out all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtprice.Text.Any(Char.IsLetter))
            {
                error = 1;
                MessageBox.Show("Price cannot contain letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            if (error==0)
            
            {
                int flag = 0;
                int salesno = Convert.ToInt32(cmbsorder.SelectedItem);
                String date = txtdate.Text;
                int Users_ID = u_id;
                DBSalesReturns dp = new DBSalesReturns();
                int sr_no = dp.setSalesReturn(count_tot, count_qty, Users_ID, cusno, salesno);
                DBSalesReturns_Item_reference SR_I_ref = new DBSalesReturns_Item_reference();
                foreach (DataGridViewRow Datarow in dataGridView1.Rows)
                {
                    if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null)
                    {
                        int itemno = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Item_No"].Value);
                        int itemqty = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Item_Qty"].Value);
                        int itemtot = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Sub_Total"].Value);
                        DBItem di = new DBItem();
                        SR_I_ref.setReference(sr_no, itemno, itemqty, itemtot);
                        di.updateQty(itemno, itemqty, txtdate.Text.ToString(), flag);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
