using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    internal class DBPurchase_Item_reference
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader DR;
        SqlDataAdapter da;
        private int  Item_Qty, Sub_Total, Item_No, Purchase_OrderNo;
        public DBPurchase_Item_reference()
        {
        }

     public SqlDataAdapter select(int pOrderNo) // in purchase returns
       {
            try
            {
                Purchase_OrderNo = pOrderNo;
                DataBase db = new DataBase();
                con = db.getConnection();
                String sql = "Select Item.Item_No, Item.Item_Qty, Purchase_Item_reference.Sub_Total from Purchase_Item_reference inner join Item on Item.Item_No = Purchase_Item_reference.Item_No where Purchase_Item_reference.Purchase_OrderNo ='" + Purchase_OrderNo + "'";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
           
            }
            catch(SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return da;
        }
        
        internal SqlDataReader getItemNo(int porderNo)
        {
            try
            {
                Purchase_OrderNo = porderNo;
                DataBase db = new DataBase();
                con= db.getConnection();
                con.Open();
                String sql = "Select Item.Item_Name from Purchase_Item_reference inner join Item on Item.Item_No = Purchase_Item_reference.Item_No where Purchase_Item_reference.Purchase_OrderNo ='" + Purchase_OrderNo+"'";
                cmd = new SqlCommand(sql, con);
                DR = cmd.ExecuteReader();
            }
            catch(SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception e)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return DR;
        }

        internal void setReference(int po_no, int itemno, int itemqty, int itemtot)
        {
            int line = 0;
            try
            {
                Item_No = itemno;
                Purchase_OrderNo = po_no;
                Item_Qty = itemqty;
                Sub_Total = itemtot;
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Insert into Purchase_Item_reference(Item_No,Purchase_OrderNo,Sub_Total,Item_Qty) values ('" + Item_No + "','" +Purchase_OrderNo+ "','" + Sub_Total+ "', '" +Item_Qty + "')", con);
                line = cmd.ExecuteNonQuery();


            }

            catch (SqlException e)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}