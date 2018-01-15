using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    internal class DBDelivery
    {
        SqlConnection con;
        SqlCommand cmd;
        int line;
        private String Delivery_Date, Delivery_Status;
        private int Delivery_No, Users_ID, Sales_OrderNo;
        public int setDelivery(String date, String status, int u_id, int so_no)
        {
            try
            {
                Delivery_Date = date;
                Delivery_Status = status;
                Users_ID = u_id;
                Sales_OrderNo = so_no;
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Insert into Delivery (Delivery_Date, Delivery_Status,Users_ID,Sales_OrderNo) values ('" + Delivery_Date + "','" + Delivery_Status + "','" + Users_ID + "', '" +Sales_OrderNo + "')", con);
                line = cmd.ExecuteNonQuery();


            }

            catch (SqlException )
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return line;
        }

        public SqlDataAdapter getDelivery()
        {
            SqlDataAdapter da = null;
           
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                cmd = new SqlCommand("Select Delivery_No,Delivery_Date, Delivery_Status,Users_ID,Sales_OrderNo from Delivery", con);
                da = new SqlDataAdapter(cmd);
            }
            catch (SqlException)
            {

                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return da;
        }
        public int update (String status ,int no)
        {
            try
            {
                Delivery_Status = status;
                Delivery_No = no;
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Update Delivery set Delivery_Status ='" + Delivery_Status + "' where Delivery_No='" + Delivery_No + "'", con);
                line = cmd.ExecuteNonQuery();
            }
            catch(SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return line;
        }
        
    }
}