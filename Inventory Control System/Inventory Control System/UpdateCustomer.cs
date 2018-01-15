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
    public partial class UpdateCustomer :MetroFramework.Forms.MetroForm
    {

        int u_id;
        public void setid(int a)
        {
            u_id = a;
        }
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DBCustomer i = new DBCustomer();
            da = i.getCustomer();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            UserMenu um = new UserMenu();
            um.Show();
            um.setid(u_id);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }

        private void mtCancel_Click(object sender, EventArgs e)
        {
            txtadd.Text = "";
            txtname.Text = "";
            txtnic.Text = "";
            txttele.Text = "";
        }

        private void mtUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to update?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr.ToString() == "Yes")
            {
                if (String.IsNullOrEmpty(txtname.Text) || String.IsNullOrEmpty(txtadd.Text) || String.IsNullOrEmpty(txtnic.Text) || txttele.Text.Length!=10 )
                {
                    MessageBox.Show("Check if all the fields are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else
                {

                    try
                    {
                        String name = txtname.Text;
                        String add = txtadd.Text;
                        String nic = txtnic.Text;
                        DBCustomer di = new DBCustomer();
                        int tele = Convert.ToInt32(txttele.Text);
                        int no = di.getCusNo(nic);
                        int line = di.updateCustomer(name,add,nic,tele,u_id,no);
                        if (line == 1)
                        {
                            MessageBox.Show("Data entered successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception )
                    {
                        MessageBox.Show("Error,please try again", "Warning" , MessageBoxButtons.OK, MessageBoxIcon.Warning );
                    }
                }
            }
            UpdateCustomer upd = new UpdateCustomer();
            this.Hide();
            upd.Show();
            upd.setid(u_id);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dataGridView1.CurrentRow.Cells["Customer_Name"].Value.ToString();
            txtadd.Text = dataGridView1.CurrentRow.Cells["Customer_Address"].Value.ToString();
            txtnic.Text = dataGridView1.CurrentRow.Cells["Customer_NIC"].Value.ToString();
            txttele.Text = dataGridView1.CurrentRow.Cells["Customer_Mobile"].Value.ToString();
            
        }
    }
}
