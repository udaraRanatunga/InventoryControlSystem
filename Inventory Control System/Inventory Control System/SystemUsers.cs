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
    public partial class SystemUsers : MetroFramework.Forms.MetroForm
    {
        int u_id;
        public void setid(int a)
        {
            u_id = a;
        }
        public SystemUsers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            SqlDataAdapter da;
            DBSystemUsers sys = new DBSystemUsers();
            da = sys.getUser();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txttele_Click(object sender, EventArgs e)
        {

        }

        private void mtCancel_Click(object sender, EventArgs e)
        {
            txtadd.Text = "";
            txtname.Text = "";
            txtstatus.Text = "";
            txttele.Text = "";
            txtpw.Clear();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            ManagerMenu um = new ManagerMenu();
            um.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dataGridView1.CurrentRow.Cells["User_Name"].Value.ToString();
            txtadd.Text = dataGridView1.CurrentRow.Cells["User_Address"].Value.ToString();
            txtstatus.Text = dataGridView1.CurrentRow.Cells["User_Status"].Value.ToString();
            txttele.Text = txtname.Text = dataGridView1.CurrentRow.Cells["User_Mobile"].Value.ToString();
        }

        private void mtAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtname.Text) || String.IsNullOrEmpty(txtadd.Text) || String.IsNullOrEmpty(txtstatus.Text)||txttele.Text.Length==0)
                {
                    MessageBox.Show("Please check all the fields are filled");

                }
                else
                {

                    try
                    {
                        String name = txtname.Text;
                        String add = txtadd.Text;
                        String status = txtstatus.Text;
                        String pw = txtpw.Text;
                        DBSystemUsers di = new DBSystemUsers();
                        int tele = Convert.ToInt32(txttele.Text);
                        int line = di.setSystemUser(u_id,name, add, status, tele,pw);
                        if (line == 1)
                        {
                            MessageBox.Show("Data entered successfully");
                        }
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }
                }
            }
            catch(Exception )
            {

            }
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
                        String pw = txtpw.Text;
                        DBSystemUsers di = new DBSystemUsers();
                        int tele = Convert.ToInt32(txttele.Text);
                        int no = di.getSysNo(name);
                        int line = di.updateSysUser(name, add, status, tele, no,pw);
                        if (line == 1)
                        {
                            MessageBox.Show("Data entered successfully");
                        }
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }
                }
            }

        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
