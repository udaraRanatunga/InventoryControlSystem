using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    class DBPurchases
    {
        SqlDataReader DR = null, DRR= null;
        SqlDataAdapter da = null;
        SqlConnection con;
        SqlCommand cmd,cmdd;
        String Purchase_OrderDate, Purchase_Status, Item_Name;
        int Purchase_Qty, Purchase_Price, Users_ID, Supplier_ID;
        public SqlDataReader getPurchases()
        {
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select Purchase_OrderNo from Purchase_Order";
                cmd = new SqlCommand(Sql, con);
                DR = cmd.ExecuteReader();

            }
            catch (SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return DR;
        }
       /* public String getData()
        {
            int po_no;
            DataBase db = new DataBase();
            con = db.getConnection();
            con.Open();
            String Sql = "SELECT  TOP 1 Purchase_Order.Purchase_OrderNo FROM Purchase_Order ORDER BY Purchase_OrderNo DESC";
            cmd = new SqlCommand(Sql, con);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                po_no = Convert.ToInt32(DR[0]);

            }
            String Sqll = "Select Purchase_Order.Purchase_OrderNo, Purchase_Order.Puchase_OrderDate , Purchase_Order.Price ,Purchase_Order.Qty , Purhase_Order.Status,Supplier_ID ";
            MessageBox.Show("Data entered successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmdd = new SqlCommand(Sqll, con);
            DRR = cmdd.ExecuteReader();
            while(DRR.Read())
            {

            }
            return; 
        }
        */
        public SqlDataAdapter getPurchasesOrders()
        {
           
         
            try
            {
              

                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                String Sql = "Select * from Purchase_Order";
                cmd = new SqlCommand(Sql, con);

                da = new SqlDataAdapter(cmd);
            }
            catch (SqlException)
            {

                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return da;
        }

        public SqlDataReader selectOrder(int sup_id)
        {
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                String Sql = "Select Purchase_OrderNo from Purchase_Order where Suppplier_ID ='" + sup_id + "'";
                cmd = new SqlCommand(Sql, con);
                DR = cmd.ExecuteReader();
            }
            
            catch(SqlException ex)
            {

                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return DR;
        }
        public SqlDataReader select(int sup_id)
        {
            try
            {

            }
            catch(SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return DR;
        }

        internal int setPurchaseOrder(string date, string status, int count_tot, int count_qty, int u_id, int sup_no)
        {
            int po_no = 0;
            int line = 0;

            try
            {

                DataBase db = new DataBase();

                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Insert into Purchase_Order(Purchase_OrderDate, Purchase_Price, Purchase_Qty, Purchase_Status, Suppplier_ID, Users_ID) values ('" + date + "','" + count_tot + "','" + count_qty+ "', '" + status + "','" + sup_no + "','" + u_id + "')", con);
                line = cmd.ExecuteNonQuery();
                if (line==1)
                {
                    String Sql = "SELECT  TOP 1 Purchase_Order.Purchase_OrderNo FROM Purchase_Order ORDER BY Purchase_OrderNo DESC";
                    cmdd = new SqlCommand(Sql, con);
                    DR = cmdd.ExecuteReader();
                    while (DR.Read())
                    {
                        po_no = Convert.ToInt32(DR[0]);

                    }
                    MessageBox.Show("Data entered successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               


            }

            catch (SqlException e)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ew)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return po_no;
        }
     

    }
}
