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
    public partial class Purchase_Order : MetroFramework.Forms.MetroForm
    {
       
        int no;
        int count_tot = 0;
        int count_qty = 0;
        SqlDataReader DR;
        private int Users_ID,Supplier_ID;
        private String Purchase_OrderDate;
        public void setid(int a)
        {
           Users_ID= a;
         }
        public Purchase_Order()
        {
            InitializeComponent();
        }

        private void Purchase_Order_Load(object sender, EventArgs e)
        {
            txtdate.Text = System.DateTime.Today.ToString("M/d/yyyy");

            
            DBSupplier ds = new DBSupplier();
            DR = ds.getSupplier();
            while (DR.Read())
            {
                cmbsupname.Items.Add(DR[0]);

            }

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            PrintPurchaseOrder a = new PrintPurchaseOrder();
            this.Hide();
            a.Show();
            a.setid(Users_ID);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            UserMenu um = new UserMenu();
            um.setid(Users_ID);
            um.Show();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (cmbsupname.SelectedIndex!=0 && cmbitemname.SelectedIndex!=0 && txtqty.Text.Length!=0)
            {
                String Item_Name = cmbitemname.SelectedItem.ToString();
                DBItem dbi = new DBItem();
                int price = dbi.getItemPrice(Item_Name);
                int subtot = price * Convert.ToInt32(txtqty.Text);
                count_qty = count_qty + Convert.ToInt32(txtqty.Text);
                count_tot = count_tot + subtot;
                txtprice.Text = count_tot.ToString();
                txtstatus.Text = "Active";
                String[] row = { Item_Name, txtqty.Text, subtot.ToString() };
                dataGridView1.Rows.Add(row);
                
            }
            else
            {
                MessageBox.Show("Please enter data to all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        private void mtclear_Click(object sender, EventArgs e)
        {
            /*txtprice.Text = "";
            txtqty.Text = "";
            txtstatus.Text = "";
            cmbitemname.Text = "";
            cmbsupname.Text = "";*/
            this.Hide();
            Purchase_Order p = new Purchase_Order();
            p.setid(Users_ID);
            p.Show();
          


        }

        private void mtadd_Click(object sender, EventArgs e)
        {
            int error = 0;
            if (txtprice.Text.Length==0 && txtstatus.Text.Length == 0 && txtqty.Text.Length==0)
            {
                error = 1;
                MessageBox.Show("Please fill out all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cmbitemname.SelectedIndex==0)
            {
                error = 1;
                MessageBox.Show("Please select an Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cmbsupname.SelectedIndex==0)
            {
                error = 1;
                MessageBox.Show("Please select a Supplier Name","Ërror",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (txtprice.Text.Any(Char.IsLetter))
            {
                error = 1;
                MessageBox.Show("Price cannot contain letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtqty.Text.Any(Char.IsLetter))
            {
                error = 1;
                MessageBox.Show("Quantity cannot contain letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (error!=1)
            {
                String date = txtdate.Text;
                String status = txtstatus.Text;
                String supname = cmbsupname.SelectedItem.ToString();
                DBSupplier sup = new DBSupplier();
                int sup_no = sup.getSupNo(supname);
                DBPurchases dp = new DBPurchases();
                int po_no = dp.setPurchaseOrder(date, status, count_tot, count_qty, Users_ID, sup_no);
                DBPurchase_Item_reference P_I_ref = new DBPurchase_Item_reference();
                foreach (DataGridViewRow Datarow in dataGridView1.Rows)
                {
                    if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null)
                    {
                        String itemName = dataGridView1.CurrentRow.Cells["Item_Name"].Value.ToString();
                        int itemqty = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Item_Qty"].Value);
                        int itemtot = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Sub_Total"].Value);
                        DBItem di = new DBItem();
                        int itemno = di.getItemNo(itemName);
                        P_I_ref.setReference(po_no, itemno, itemqty, itemtot);

                    }
                }


            }

        }

        private void cmbitemname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbsupname_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBItem dbi = new DBItem();

            DR = dbi.getItemNames(cmbsupname.SelectedItem.ToString());
            while (DR.Read())
            {
                cmbitemname.Items.Add(DR[0]).ToString();

            }

        }

        private void txtdate_Click(object sender, EventArgs e)
        {

        }
    }
}
