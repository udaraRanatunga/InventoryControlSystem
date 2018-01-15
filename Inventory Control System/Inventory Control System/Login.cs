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

namespace Inventory_Control_System
{
    public partial class Login : MetroFramework.Forms.MetroForm

    {
        int u_id;
        public void setid(int a)
        {
            u_id = a;
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtpw.Text.Length != 0 && txtuname.Text.Length != 0)
            {
                String pw = txtpw.Text;
                String uname = txtuname.Text;
                DBLogin l = new DBLogin();
                u_id = l.login(pw, uname);


                if (u_id == 1)
                {
                    ManagerMenu mm = new ManagerMenu();
                    mm.Show();
                    this.Hide();
                    mm.setid(u_id);
                }
                else if (u_id == 2)
                {
                    UserMenu um = new UserMenu();
                    this.Hide();
                    um.Show();
                    um.setid(u_id);
                }

            }
           

           
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            txtpw.Text = "";
            txtuname.Text = "";
        }

       
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }
    }
}
