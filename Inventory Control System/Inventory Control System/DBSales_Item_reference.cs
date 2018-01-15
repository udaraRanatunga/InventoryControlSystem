using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    internal class DBSales_Item_reference
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader DR = null;
        int Item_Qty, Sub_Total, Item_No, Sales_OrderNo;
            
        public DBSales_Item_reference()
        {
        }

        internal void setReference()
        {
            throw new NotImplementedException();
        }

        internal void setReference(int so_no, int itemno, int itemqty, int itemtot)
        {
            int line = 0;
            try
            {

                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Insert into Sales_Item_reference(Item_No,Sales_OrderNo,Sub_Total,Item_Qty) values ('" + itemno + "','" + so_no + "','" + itemtot + "', '" + itemqty + "')", con);
                line = cmd.ExecuteNonQuery();


            }

            catch (SqlException e)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

        }

        public SqlDataReader getItems(int so_no)
        {
            try
            {

                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Select Item_No from Sales_Item_reference where Sales_OrderNo='"+so_no+"'", con);
                DR = cmd.ExecuteReader();


            }

            catch (SqlException e)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return DR;
        }
        internal SqlDataReader getQty(int itemno)
        {
            try
            {
                Item_No = itemno;
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select Item_Qty from Sales_Item_reference where Item_No ='"+Item_No+"'";
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