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
    public partial class Delivery : MetroFramework.Forms.MetroForm
    {
        int u_id;
        int no =0;
        public void setid(int a)
        {
            u_id = a;
        }
        public Delivery()
        {
            InitializeComponent();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            txtdate.Text = System.DateTime.Now.ToString("MM/dd/yyyy");
            DBSales s = new DBSales();
            SqlDataReader DR;
            DR = s.getSalesOrderID();
            while (DR.Read())
            {
                cmbsalesorder.Items.Add(DR[0]);

            }
            SqlDataAdapter da;
            DBDelivery i = new DBDelivery();
            da = i.getDelivery();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            // txtdate.Text = "";
            //cmbsalesorder.SelectedText = "";
            //txtstatus.Text="";
            this.Hide();
            Delivery d = new Delivery();
            d.setid(u_id);
            d.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMenu um = new UserMenu();
            um.Show();

        }

        private void txtdate_Click(object sender, EventArgs e)
        {

        }

        private void mtadd_Click(object sender, EventArgs e)
        {
            if (txtstatus.Text.Length != 0 && txtdate.Text.Length != 0 && cmbsalesorder.SelectedIndex!=0)
            {
                String date = txtdate.Text;
                String status = "Active";
                int so_no = Convert.ToInt32(cmbsalesorder.Text);
                
                DBDelivery d = new DBDelivery();
                int line = d.setDelivery(date,status,u_id,so_no);
                if (line==1)
                {
                    MessageBox.Show("Data entered successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           else
            {
                MessageBox.Show("Check if all the fields are filled", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdate.Text = dataGridView1.CurrentRow.Cells["Delivery_Date"].Value.ToString();
            txtstatus.Text = dataGridView1.CurrentRow.Cells["Delivery_Status"].Value.ToString();
            cmbsalesorder.Text = dataGridView1.CurrentRow.Cells["Sales_OrderNo"].Value.ToString();
            no = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Delivery_No"].Value);
            

           
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (txtstatus.Text.Length==0|| txtdate.Text.Length==0 || cmbsalesorder.Text=="")
            {
                MessageBox.Show("Please check if your entered data to all the fields","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                String status = txtstatus.Text;
                DBDelivery de = new DBDelivery();
                int line = de.update(status, no);
                if (line==1)
                {
                    MessageBox.Show("Data entered successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
    }
}
