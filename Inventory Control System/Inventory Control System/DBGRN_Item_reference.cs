using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    internal class DBGRN_Item_reference
    {
        SqlConnection con;
        SqlCommand cmd, cmdd;
        SqlDataReader DR = null;
        SqlDataAdapter da = null;
        int line;
        int Item_No, Item_Qty, Sub_Total, GRN_No;
        internal int setData(int item_No, int item_Qty, int sub_Total, int gRN_No)
        {
            try
            {   Item_No = item_No;
                Item_Qty = item_Qty;
                Sub_Total = sub_Total;
                GRN_No = gRN_No;

                
              //  Users_ID = u_id;
               
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Insert into GRN_Item_reference(GRN_No,Item_No,Item_Qty_Delivered,Sub_Total) values ('" + GRN_No + "','" + Item_No+ "', '" + Item_Qty + "','" + Sub_Total + "')", con);
                line = cmd.ExecuteNonQuery();
                if (line == 0)
                {
                    MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            catch (SqlException e)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return line;
        }
    }
}