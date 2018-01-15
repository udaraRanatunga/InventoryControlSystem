using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    class DBPurchaseReturn
    {
        SqlDataReader DR = null;
        SqlConnection con;
        SqlCommand cmd,cmdd;
        SqlDataAdapter da = null;
        String PurchaseReturns_Date;
        int PurchaseReturns_Price, PurchaseReturns_Qty, Users_ID, Supplier_ID, Purchase_OrderNo;
        public SqlDataAdapter getPurchaseReturns()
        {
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select * from PurchaseReturns ";
                cmd = new SqlCommand(Sql, con);
                da = new SqlDataAdapter(cmd);

            }
            catch (SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return da;

          
        }

        internal int setPurchaseReturn(int count_tot, int count_qty, string date, int u_id, int sup_no, int purchNo)
        {

            int pr_no = 0;
            int line = 0;

            try
            {
                PurchaseReturns_Price = count_tot;
                PurchaseReturns_Qty = count_qty;
                PurchaseReturns_Date = date;
                Supplier_ID = sup_no;
                Users_ID = u_id;
                Purchase_OrderNo = purchNo;

                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                cmd = new SqlCommand("Insert into PurchaseReturns(PurchaseReturns_Qty,PurchaseReturns_Price, PurchaseReturns_Date,Supplier_ID, Users_ID, Purchase_OrderNo) values ('" +PurchaseReturns_Qty + "','" + PurchaseReturns_Price+ "','" + PurchaseReturns_Date + "', '" + Supplier_ID + "','" + Users_ID + "','"+Purchase_OrderNo+"')", con);
                line = cmd.ExecuteNonQuery();
                if (line == 1)
                {
                    String Sql = "SELECT  TOP 1 PurchaseReturns.PurchaseReturns_No FROM PurchaseReturns ORDER BY PurchaseReturns_No DESC";
                    cmdd = new SqlCommand(Sql, con);
                    DR = cmdd.ExecuteReader();
                    while (DR.Read())
                    {
                        pr_no = Convert.ToInt32(DR[0]);

                    }
                   // MessageBox.Show("Data entered successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ew)
            {
                MessageBox.Show(ew.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return pr_no;
        }
    }
}
