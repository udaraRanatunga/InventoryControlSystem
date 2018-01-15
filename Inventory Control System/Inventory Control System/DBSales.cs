using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    class DBSales
    {
        SqlConnection con;
        SqlDataAdapter da = null;
        SqlDataReader DR = null;
        SqlCommand cmd;
        String Sales_Date, Sales_Status;
        int Sales_Qty, Sales_Total, Users_ID, Customer_No;
        public SqlDataReader getSalesOrderID()
        {
            
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select Sales_OrderNo from Sales_Order";
                cmd= new SqlCommand(Sql, con);
                DR = cmd.ExecuteReader();
            }
          catch(SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return DR;

        }
        public SqlDataAdapter getSalesOrders()
        {
            
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select * from Sales_Order";
                cmd = new SqlCommand(Sql, con);
                da = new SqlDataAdapter(cmd);

            }
            catch(SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return da;

        }
       
        public int setSalesOrder(String date, String status,int tot,int qty,int u_id,int no)
        {
            int so_no = 0;
            int line = 0;
            
            try
            {

                DataBase db = new DataBase();
                
                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Insert into Sales_Order(Sales_Total,Sales_Qty, Sales_Date,Sales_Status,Users_ID,Customer_No) values ('" +tot+ "','" + qty + "','" + date + "', '" + status + "','" + u_id + "','" + no + "')", con);
                line = cmd.ExecuteNonQuery();
                String Sql = "SELECT  TOP 1 Sales_Order.Sales_OrderNo FROM Sales_Order ORDER BY Sales_OrderNo DESC";
                cmd = new SqlCommand(Sql, con);
                DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    so_no =Convert.ToInt32(DR[0]);

                }
                if(line==1)
                {
                    MessageBox.Show("Data entered successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              

            }

            catch (SqlException e)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch(Exception ew)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return so_no;
        }


        public SqlDataReader getSalesOrderNo()
        {

            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select Sales_OrderNo from Sales_Order";
                cmd = new SqlCommand(Sql, con);
                DR = cmd.ExecuteReader();

            }
            catch (SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return DR;

        }
        public SqlDataReader getSalesOrder(int cusNo)
        {
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select Sales_OrderNo from Sales_Order where Customer_No ='"+cusNo+"'";
                cmd = new SqlCommand(Sql, con);
                DR = cmd.ExecuteReader();

            }
            catch (SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return DR;
        }

    }
}