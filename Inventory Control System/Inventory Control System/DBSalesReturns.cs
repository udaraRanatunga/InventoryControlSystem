using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    class DBSalesReturns
    {
        SqlConnection con;
        SqlCommand cmd,cmdd;
        SqlDataAdapter da;
        SqlDataReader DR;
        String SalesReturns_Status;
        int SalesReturns_Qty, SalesReturns_Price, Users_ID, Sales_OrderNo, Customer_No;
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
            catch (SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return da;
        }

        internal int setSalesReturn(int count_tot, int count_qty, int users_ID, int cusno, int salesno)
        {

            int sr_no = 0;
            int line = 0;

            try
            {
                SalesReturns_Price = count_tot;
                SalesReturns_Qty = count_qty;
                Customer_No  = cusno;
                Users_ID = users_ID;
                Sales_OrderNo = salesno;

                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                cmd = new SqlCommand("Insert into SalesReturns(SalesReturns_Price,SalesReturns_Qty, SalesReturns_Status,Customer_No, Users_ID, Sales_OrderNo) values ('" + SalesReturns_Price + "','" + SalesReturns_Qty + "','" + SalesReturns_Status + "', '" + Customer_No + "','" + Users_ID + "','" +Sales_OrderNo + "')", con);
                line = cmd.ExecuteNonQuery();
                if (line == 1)
                {
                    String Sql = "SELECT  TOP 1 SalesReturns.SalesReturns_No FROM SalesReturns ORDER BY SalesReturns_No DESC";
                    cmdd = new SqlCommand(Sql, con);
                    DR = cmdd.ExecuteReader();
                    while (DR.Read())
                    {
                        sr_no = Convert.ToInt32(DR[0]);

                    }
                    MessageBox.Show("Data entered successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

            catch (SqlException re)
            {
                MessageBox.Show(re.ToString());
               // MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ew)
            {
                MessageBox.Show(ew.ToString());
                //MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return sr_no;
        }

       
    }
}
