using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    internal class DBPurchaseReturns_Item_reference
    {
        SqlConnection con;
        SqlCommand cmd;
        int Item_No, PurchaseReturns_No, Item_Qty, Sub_Total;
         public int setReference(int pr_no, int itemno, int itemqty, int itemtot)
        {
            int line = 0;
            try
            {
                Item_No = itemno;
                PurchaseReturns_No = pr_no;
                Item_Qty = itemqty;
                Sub_Total = itemtot;
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Insert into PurchaseReturns_Item_reference(Item_No,PurchaseReturns_No,Sub_Total,Item_Qty) values ('" + Item_No + "','" + PurchaseReturns_No + "','" + Sub_Total + "', '" + Item_Qty + "')", con);
                line = cmd.ExecuteNonQuery();
                if (line==1)
                {
                    MessageBox.Show("Data entered Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch (SqlException e)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return line;
        }
    }
}