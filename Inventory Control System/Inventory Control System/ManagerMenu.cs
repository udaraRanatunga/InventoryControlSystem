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
    public partial class ManagerMenu : MetroFramework.Forms.MetroForm

    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

       public int u_id;

        private void ManagerMenu_Load(object sender, EventArgs e)
        {

        }

        private void mtusers_Click(object sender, EventArgs e)
        {
            SystemUsers su = new SystemUsers();
            su.Show();
            this.Hide();
        }

        private void mtReports_Click(object sender, EventArgs e)
        {
            Reports rp = new Reports();
            rp.Show();
            this.Hide();
        }

        private void mtexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       public void setid(int a)
        {
            u_id = a;
        }

       private void metroLink1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }
    }
}
