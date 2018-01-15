using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Inventory_Control_System.DBSupplier;

namespace Inventory_Control_System
{
    public partial class Items : MetroFramework.Forms.MetroForm
    {
        int u_id;
        int no=0;
        public void setid(int a)
        {
            u_id = a;
        }
       
        public Items()
        {
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            try
            {
               
                SqlDataAdapter da;
                DBItem i = new DBItem();
                da = i.getItem();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                DBSupplier s = new DBSupplier();
                SqlDataReader DR;
                DR= s.getSupplier();
                while (DR.Read())
                {
                    comboBox1.Items.Add(DR[0]);

                }

                
            }
            catch(Exception )
            {
                MessageBox.Show("Please fill out all the fields","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                txtname.Text = dataGridView1.CurrentRow.Cells["Item_Name"].Value.ToString();
                txtdes.Text = dataGridView1.CurrentRow.Cells["Item_Description"].Value.ToString();
                txtstatus.Text = dataGridView1.CurrentRow.Cells["Item_Status"].Value.ToString();
                txtprice.Text = dataGridView1.CurrentRow.Cells["Item_Price"].Value.ToString();
                txtqty.Text = dataGridView1.CurrentRow.Cells["Item_Qty"].Value.ToString();
                int sup = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Supplier_ID"].Value);
                no = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Item_No"].Value);
                DBSupplier ds = new DBSupplier();
                String name = ds.getName(sup);
                comboBox1.SelectedItem = name;
            

        }
       

        private void mtSearch_Click(object sender, EventArgs e)
        {

        }

        private void mtUpdate_Click(object sender, EventArgs e)
        {
          
                DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr.ToString()=="Yes")
                {
                    if (String.IsNullOrEmpty(txtname.Text) || String.IsNullOrEmpty(txtqty.Text) || String.IsNullOrEmpty(txtprice.Text) || String.IsNullOrEmpty(txtstatus.Text) || String.IsNullOrEmpty(txtdes.Text) || comboBox1.Text == "")
                    {
                        MessageBox.Show("Check if all the fields are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    else
                    {

                        try
                        {
                            String name = txtname.Text;
                            int price = Convert.ToInt32(txtprice.Text);
                            int qty = Convert.ToInt32(txtqty.Text);
                            String status = txtstatus.Text;
                            String des = txtdes.Text;
                            int sup = comboBox1.SelectedIndex;
                            DBItem di = new DBItem();
                            int line = di.updateItem(no,name, price, qty, status, des, u_id, sup, System.DateTime.Now.ToShortDateString());
                            if (line == 1)
                            {
                                MessageBox.Show("Data entered successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                SqlDataAdapter da;
                                DBItem i = new DBItem();
                                da = i.getItem();
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                dataGridView1.DataSource = dt;
                                
                        }
                        }
                        catch (Exception )
                        {
                            MessageBox.Show("Error , please try again", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                }
         
        }

        private void mtAdd_Click(object sender, EventArgs e)
        {
            int error = 0;
            if (String.IsNullOrEmpty(txtname.Text) || String.IsNullOrEmpty(txtqty.Text) || String.IsNullOrEmpty(txtprice.Text) || String.IsNullOrEmpty(txtstatus.Text) || String.IsNullOrEmpty(txtdes.Text) || comboBox1.Text == "")
            {
                error = 1;
                MessageBox.Show("Check if all the fields are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtprice.Text.Any(Char.IsLetter))
            {
                error = 1;
                MessageBox.Show("Price cannot contain letters","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (txtqty.Text.Any(Char.IsLetter))
            {
                error = 1;
                MessageBox.Show("Quanity cannot contain letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (txtname.Text.Any(Char.IsDigit))
            {
                error = 1;
                MessageBox.Show("Name cannot contain digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (error==1)
            {
                MessageBox.Show("Check if all the fields are filled correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    String name = txtname.Text;
                    int price = Convert.ToInt32(txtprice.Text);
                    int qty = Convert.ToInt32(txtqty.Text);
                    String status = txtstatus.Text;
                    String des = txtdes.Text;
                    int sup = comboBox1.SelectedIndex;
                    DBItem di = new DBItem();
                    int line = di.setItem(name, price, qty, status, des, u_id, sup);
                    if (line == 1)
                    {
                        MessageBox.Show("Data entered successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please re-enter the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception er)
                {
                    MessageBox.Show("An Error occured, Please re-enter your data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                   
                }
            }

        
        
        private void mtCancel_Click(object sender, EventArgs e)
        {
            /* txtname.Text = "";
             txtdes.Text = "";
             txtprice.Text = "";
             txtqty.Text = "";
             txtstatus.Text = "";
             comboBox1.Text = "";
             */
            this.Hide();
            Items i = new Items();
            i.setid(u_id);
            i.Show();
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMenu u = new UserMenu();
            u.Show();
            u.setid(u_id);
        }

        private void mtcmbsupname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
