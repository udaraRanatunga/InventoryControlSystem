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
    public partial class Suppliers : MetroFramework.Forms.MetroForm
    {
        int u_id;
        public void setid(int a)
        {
            u_id = a;
        }
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DBSupplier i = new DBSupplier();
            da = i.getSup();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dataGridView1.CurrentRow.Cells["Supplier_Name"].Value.ToString();
            txtadd.Text = dataGridView1.CurrentRow.Cells["Supplier_Address"].Value.ToString();
            txtstatus.Text = dataGridView1.CurrentRow.Cells["Supplier_Status"].Value.ToString();
            txttele.Text = dataGridView1.CurrentRow.Cells["Supplier_Mobile"].Value.ToString();
        }

        private void txtname_Click(object sender, EventArgs e)
        {

        }

        private void mtAdd_Click(object sender, EventArgs e)
        {
            String name;
            String add;
            int mob;
            String status;
            int flag = 0;
            if (txtname.Text.Any(Char.IsDigit))
            {
                flag = 1;
                MessageBox.Show("Name cannot contain digits", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           // if (txttele.Text.Length != 10)
            //{
              //  flag = 1;
                //MessageBox.Show("Wrong Telephone Number", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

           // }
            if (String.IsNullOrEmpty(txtname.Text) || String.IsNullOrEmpty(txtadd.Text) || String.IsNullOrEmpty(txttele.Text))
            {
                flag = 1;
                MessageBox.Show("Do not keep any fields empty", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (flag == 0)
            {
                name = txtname.Text;
                add = txtadd.Text;
                mob = Convert.ToInt32(txttele.Text);
                status = txtstatus.Text;
                DBSupplier c = new DBSupplier();
                c.setSupplier(name, add, mob, status, u_id);

            }

        }

        private void mtCancel_Click(object sender, EventArgs e)
        {

            txtadd.Text = "";
            txtname.Text = "";
            txtstatus.Text = "";
            txttele.Text = "";


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            UserMenu um = new UserMenu();
            um.Show();
        }

        private void mtUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr.ToString() == "Yes")
            {
                if (String.IsNullOrEmpty(txtname.Text) || String.IsNullOrEmpty(txtadd.Text) || String.IsNullOrEmpty(txtstatus.Text) || txttele.Text.Length != 10)
                {
                    MessageBox.Show("Check if all the fields are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else
                {

                    try
                    {
                        String name = txtname.Text;
                        String add = txtadd.Text;
                        String status = txtstatus.Text;
                        int tele = Convert.ToInt32(txttele.Text);
                        DBSupplier di = new DBSupplier();
                        int no = di.getSupNo(name);
                        int line = di.updateSupplier(name, add, status, tele, u_id, no);
                        if (line == 1)
                        {
                            MessageBox.Show("Data entered successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception )
                    {
                        MessageBox.Show("Please enter your data and try again");
                    }
                }
            }
            this.Hide();
            Suppliers s = new Suppliers();
            s.setid(u_id);
            s.Show();
        }
    }
}
