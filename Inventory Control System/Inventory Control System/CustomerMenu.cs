﻿using System;
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
    public partial class CustomerMenu : MetroFramework.Forms.MetroForm
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DBItem i = new DBItem();
            da = i.getItemDetails();
            DataTable dt = new DataTable();
            da.Fill(dt);
            metroGrid1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
