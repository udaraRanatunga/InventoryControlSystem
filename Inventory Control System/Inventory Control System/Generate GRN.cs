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
    public partial class Generate_GRN : MetroFramework.Forms.MetroForm
    {
        int u_id;
        SqlDataReader DR = null;
        int count_tot=0;
        int count_qty = 0;
        int line;
        public void setid(int a)
        {
            u_id = a;
        }
        public Generate_GRN()
        {
            InitializeComponent();
        }

        private void Generate_GRN_Load(object sender, EventArgs e)
        {
            txtdate.Text = System.DateTime.Now.ToString("MM / dd / yyyy");
            DBPurchases p = new DBPurchases();
            DR= p.getPurchases();
            while(DR.Read())
            {
                cmbPorderNo.Items.Add(DR[0]);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            txtdate.Text = "";
            metroTextBox3.Text = "";
            metroTextBox4.Text = "";
            metroTextBox5.Text = "";
            cmbPorderNo.SelectedItem = "";
        }

        private void txtdate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMenu um = new UserMenu();
            um.Show();
            um.setid(u_id);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            int error = 0;

            if (metroTextBox4.Text.Length == 0 && metroTextBox3.Text.Length == 0 && metroTextBox5.Text.Length == 0)
            {
                error = 1;
                MessageBox.Show("Check if all the fields are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cmbPorderNo.SelectedIndex==0)
            {
                error = 1;
                MessageBox.Show("Please select a Purchase Order Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (metroComboBox1.SelectedIndex==0)
            {
                error = 1;
                MessageBox.Show("Please select an Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (metroTextBox4.Text.Any(Char.IsLetter))
            {
                error = 1;
                MessageBox.Show("Quantity cannot contain letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

            if (error==0)
            {
                int flag = 0;
                String date = txtdate.Text;
                int Purchase_OrderNo = Convert.ToInt32(cmbPorderNo.SelectedItem);
                DBGRN g = new DBGRN();
                int GRN_No = g.setGRN(count_qty, count_tot,date, u_id, Purchase_OrderNo);
                DBGRN_Item_reference gp = new DBGRN_Item_reference();
                foreach (DataGridViewRow Datarow in dataGridView1.Rows)
                {
                    if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null)
                    {
                        String itemname = dataGridView1.CurrentRow.Cells["Item_Name"].Value.ToString();
                        int itemqty = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Item_Qty"].Value);
                        int itemtot = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Sub_Total"].Value);
                        DBItem di = new DBItem();
                        int itemno = di.getItemNo(itemname);
                        line = gp.setData(itemno, itemqty, itemtot, GRN_No);
                        di.updateQty(itemno, itemqty, txtdate.Text.ToString(), flag);
                    }
                }
                if (line == 1)
                {
                    MessageBox.Show("Data Entered Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }


        }

        private void cmbPorderNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pordrNo = Convert.ToInt32(cmbPorderNo.SelectedItem);
            DBPurchase_Item_reference i = new DBPurchase_Item_reference();
            DR= i.getItemNo(pordrNo);
            while(DR.Read())
            {
                metroComboBox1.Items.Add(DR[0].ToString());
            }
        }

        private void mt_ADD_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex!=0 && metroTextBox4.Text.Length!=0)
            {
                DBItem i = new DBItem();
                String itemname = metroComboBox1.SelectedItem.ToString();
                int no = i.getItemNo(itemname);
                int qty = Convert.ToInt32(metroTextBox4.Text);
                int price = i.getItemPrice(metroComboBox1.SelectedItem.ToString());
                int subtot = price * qty;
                String[] row = { itemname, qty.ToString(), subtot.ToString() };
                dataGridView1.Rows.Add(row);
                count_qty = count_qty + qty;
                count_tot = count_tot + subtot;
                metroTextBox3.Text = count_tot.ToString();
                metroTextBox5.Text = count_qty.ToString();
            }
            else
            {
                MessageBox.Show("Please fill out all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
