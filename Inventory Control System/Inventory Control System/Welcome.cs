using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Inventory_Control_System
{
    public partial class Welcome : MetroFramework.Forms.MetroForm
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            CustomerMenu c = new CustomerMenu();
            c.Show();
            this.Hide();

        }

       
        private void mtl_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
           
        }

        private void mtexit_Click(object sender, EventArgs e)
        {
         
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
          

        }
    }
}
