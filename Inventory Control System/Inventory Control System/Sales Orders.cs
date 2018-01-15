using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Inventory_Control_System.DBSupplier;
using System.Data.SqlClient;
namespace Inventory_Control_System
{
    public partial class Sales_Orders : MetroFramework.Forms.MetroForm
    {
        int u_id, no;
        int count_tot = 0;
        int count_qty = 0;
        public void setid(int a , int num)
        {
            u_id = a;
            no = num;

        }
       
        public Sales_Orders()
        {
            InitializeComponent();
        }

        private void Sales_Orders_Load(object sender, EventArgs e)
        {
            txtdate.Text = System.DateTime.Today.ToString("M/d/yyyy");
            
            DBItem s = new DBItem();
            SqlDataReader DR;
            DR = s.getName();
            while (DR.Read())
            {
                cmbitemname.Items.Add(DR[0]);
               
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mtcancel_Click(object sender, EventArgs e)
        {
            txtdate.Text = "";
            txtprice.Text = "";
            txtqty.Text = "";
            txtstatus.Text = "";
            txttotqty.Text = "";
            cmbitemname.Text = "";
            

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void mtclear_Click(object sender, EventArgs e)
        {

        }

        private void mtadd_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtstatus_Click(object sender, EventArgs e)
        {

        }

        private void txtprice_Click(object sender, EventArgs e)
        {

        }

        private void txtdate_Click(object sender, EventArgs e)
        {

        }

        private void txtS_OrderNo_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtsubtot_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  dataGridView1.CurrentRow.Cells["itemName"].Value = cmbitemname.SelectedItem.ToString();
            //       dataGridView1.CurrentRow.Cells["itemQty"].Value = txtqty.Text.ToString();
            if (cmbitemname.SelectedIndex != 0 && txtqty.Text.Length != 0 )
            {
                String name = cmbitemname.SelectedItem.ToString();
                int qty = Convert.ToInt32(txtqty.Text.ToString());
                DBItem dbi = new DBItem();
                int price = dbi.getItemPrice(name);
                int subtot = price *qty;
                
                count_qty = count_qty + qty;
                count_tot = count_tot + subtot;
                txttotqty.Text = count_qty.ToString();
                txtprice.Text = count_tot.ToString();
                txtstatus.Text = "Active";
                String[] row = { name, qty.ToString(), subtot.ToString() };
                dataGridView1.Rows.Add(row);

            }
            else
            {
                MessageBox.Show("Please insert data to all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }


        }
                
        private void cmbitemname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txtqty_Click(object sender, EventArgs e)
        {
            //String name = cmbitemname.SelectedItem.ToString();
            //DBItems dbi = new DBItems();
            //int price = dbi.getItemPrice(name);
            //txtprice.Text =(Convert.ToInt32(txtqty.Text) * price).ToString();

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            ViewSOrder s = new ViewSOrder();
            s.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            UserMenu um = new UserMenu();
            um.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mtview_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSOrder s = new ViewSOrder();
            s.Show();
            s.setid(u_id,no);
        }

        private void mtcancel_Click_1(object sender, EventArgs e)
        {
            /*txtprice.Text = "";
            txtqty.Text = "";
            txtstatus.Text = "";
            txttotqty.Text = "";
            cmbitemname.SelectedIndex = 0;
            dataGridView1.CurrentRow.Cells["itemName"].Value = "";
            dataGridView1.CurrentRow.Cells["itemQty"].Value = "";
            dataGridView1.CurrentRow.Cells["itemPrice"].Value = ""; */
            this.Hide();
            Sales_Orders so = new Sales_Orders();
            so.setid(u_id,no);
            so.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mtadd_Click_1(object sender, EventArgs e)
        {  
            int flag = 1 ,error=0;
            String date = txtdate.Text;
            String status = txtstatus.Text;
            DBSales ds = new DBSales();
            if (txtqty.Text.Length==0 && txtprice.Text.Length==0 && txtstatus.Text.Length==0)
            {
                MessageBox.Show("Check if all the fields are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = 1;
            }
            if (txtprice.Text.Any(Char.IsLetter))
            {
                MessageBox.Show("Price cannot contain letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = 1;
            }
            if (txtqty.Text.Any(Char.IsLetter))
            {
                error = 1;
                MessageBox.Show("Quantity cannot contain letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cmbitemname.SelectedIndex == 0)
            {
                error = 1;
                MessageBox.Show("Please select an Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (error==1)
            {
                MessageBox.Show("Check if all the fields are filled correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            else
            {
                int so_no = ds.setSalesOrder(date, status, count_tot, count_qty, u_id, no);
                DBSales_Item_reference S_I_ref = new DBSales_Item_reference();
                foreach (DataGridViewRow Datarow in dataGridView1.Rows)
                {
                    if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null)
                    {
                        String itemName = dataGridView1.CurrentRow.Cells["itemName"].Value.ToString();
                        int itemqty = Convert.ToInt32(dataGridView1.CurrentRow.Cells["itemQty"].Value);
                        int itemtot = Convert.ToInt32(dataGridView1.CurrentRow.Cells["itemPrice"].Value);

                        DBItem di = new DBItem();
                        int itemno = di.getItemNo(itemName);
                        S_I_ref.setReference(so_no, itemno, itemqty, itemtot);
                        di.updateQty(itemno, itemqty, txtdate.Text.ToString(), flag);
                    }




                }

            }

        }
    }
}
