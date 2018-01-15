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
    public partial class Purchase_Returns : MetroFramework.Forms.MetroForm
    {
        int u_id, count_tot = 0, count_qty = 0;
        SqlDataReader DR = null;
        SqlDataAdapter da = null;
        public void setid(int a)
        {
            u_id = a;
        }
        public Purchase_Returns()
        {
            InitializeComponent();
        }

        private void Purchase_Returns_Load(object sender, EventArgs e)
        {
            txtdate.Text = System.DateTime.Now.ToString("MM/dd/yyyy");
            DBSupplier s = new DBSupplier();
            DR = s.getSupplier();
            while (DR.Read())
            {
              cmbsupname.Items.Add(DR[0]);

            }
           
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            /*txtdate.Clear();
            txtprice.Clear();
            numQty.Value = 0;
            metroTextBox1.Text = "";
            cmbporder.SelectedText = "";
            cmbsupname.SelectedText="";
            txttotqty.Clear();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();*/
            this.Hide();
            Purchase_Returns pr = new Purchase_Returns();
            pr.setid(u_id);
            pr.Show();
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            UserMenu um = new UserMenu();
            um.Show();
        }

        private void cmbporder_SelectedIndexChanged(object sender, EventArgs e)
        {
            /////editable add the validations 
            DBPurchase_Item_reference p = new DBPurchase_Item_reference();
            int porder = Convert.ToInt32(cmbporder.SelectedItem);
            da = p.select(porder);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
           
        
        }

        private void txtdate_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void mtAdd_Click(object sender, EventArgs e) ////// editable
        {
            int error = 0;
            if (txttotqty.Text.Length == 0 && txtprice.Text.Length ==0)
            {
                error = 1;
                MessageBox.Show("Please fill out all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (numQty.Value ==0)
            {
                error = 1;
                MessageBox.Show("Please select Item Quantity to return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(cmbporder.SelectedIndex==0)
            {
                error = 1;
                MessageBox.Show("Please select a Purchase Order Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cmbsupname.SelectedIndex==0)
            {
                error = 1;
                MessageBox.Show("Please select a Supplier Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (error==0)
            {
                int flag = 0;
                int PurchNo = Convert.ToInt32(cmbporder.SelectedItem);
                String date = txtdate.Text;
                int Users_ID = u_id;
                String supname = cmbsupname.SelectedItem.ToString();
                DBSupplier sup = new DBSupplier();
                int sup_no = sup.getSupNo(supname);
                DBPurchaseReturn dp = new DBPurchaseReturn();
                int pr_no = dp.setPurchaseReturn(count_tot, count_qty, date, Users_ID, sup_no, PurchNo);
                DBPurchaseReturns_Item_reference PR_I_ref = new DBPurchaseReturns_Item_reference();
                foreach (DataGridViewRow Datarow in dataGridView1.Rows)
                {
                    if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null)
                    {
                        // String itemName = dataGridView1.CurrentRow.Cells["Item_Name"].Value.ToString();
                        int itemno = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Item_No"].Value);
                        int itemqty = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Item_Qty"].Value);
                        int itemtot = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Sub_Total"].Value);
                        DBItem di = new DBItem();
                        //int itemno = di.getItemNo(itemName);
                        flag = PR_I_ref.setReference(pr_no, itemno, itemqty, itemtot);
                        di.updateQty(itemno, itemqty, txtdate.Text.ToString(), flag);
                    }
                }

            }

        }

        private void cmbsupname_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            DBItem i = new DBItem();
            int itemno = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Item_No"].Value);
            DR = i.getName(itemno);
            while(DR.Read())
            {
                metroTextBox1.Text = DR[0].ToString();
            }
            int Qty = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Item_Qty"].Value); 
           /* DBPurchases pu = new DBPurchases();
            DR = pu.getQty(metroTextBox1.Text.ToString());
            while (DR.Read())
            {
                Qty = Convert.ToInt32(DR[0]);

            } */
            numQty.Maximum = Qty;
            numQty.Value = Qty;
        }

      
        private void metroButton2_Click(object sender, EventArgs e)
        { if (cmbsupname.SelectedIndex!=0 )
            {
                String name = cmbsupname.SelectedItem.ToString();
                DBSupplier sup = new DBSupplier();
                int sup_id = sup.getSupNo(name);
                DBPurchases p = new DBPurchases();
                DR = p.selectOrder(sup_id);
                while (DR.Read())
                {
                    cmbporder.Items.Add(DR[0].ToString());
                }

            }
            else
            {
                MessageBox.Show("Please select a supplier name ","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length!=0)
            {
                DBItem i = new DBItem();
                int no = i.getItemNo(metroTextBox1.Text.ToString());
                //dataGridView1.CurrentRow.Cells["Item_No"].Value = no.ToString();
                // dataGridView1.CurrentRow.Cells["Item_Qty"].Value = txtqty.Text;
                int qty = Convert.ToInt32(numQty.Value);
                int price = i.getItemPrice(metroTextBox1.Text.ToString());
                // dataGridView1.CurrentRow.Cells["Sub_Total"].Value = (price * Convert.ToInt32(txtqty.Text));
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
                MessageBox.Show("Please fill out all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
