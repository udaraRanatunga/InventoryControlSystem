using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    internal class DBSalesReturns_Item_reference
    {
        internal void setReference(int salesretno, int itemno, int itemqty, int itemtot)
        {
            int line = 0,SalesReturns_No,Item_Qty,Sub_Total,Item_No;
            SqlConnection con;
            SqlCommand cmd;
            try
            {
                Item_No = itemno;
                SalesReturns_No = salesretno;
                Item_Qty = itemqty;
                Sub_Total = itemtot;
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Insert into SalesReturns_Item_reference(SalesReturns_No,Item_No,Item_Qty,Sub_Total) values ('" + SalesReturns_No + "','" + Item_No + "', '" + Item_Qty + "','" + Sub_Total + "')", con);
                line = cmd.ExecuteNonQuery();
               // if (line == 1)
                //{
                 //   MessageBox.Show("Data entered Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

            }

            catch (SqlException e)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }
    }
}