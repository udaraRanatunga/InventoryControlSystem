using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    public partial class DBGRN
    {
        SqlConnection con;
        SqlCommand cmd, cmdd;
        SqlDataReader DR = null;
        SqlDataAdapter da = null;
        int line;
        private String Date;
        private int GRN_No, Qty_Delivered, Total_Price, Users_ID, Purchase_OrderNo;
        public int setGRN( int qty, int totPrice,string date, int u_id,int pordrNo)
        {
            try
            {
                Date = date;
                Qty_Delivered = qty;
                Total_Price = totPrice;
                Users_ID = u_id;
                Purchase_OrderNo = pordrNo;
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Insert into GRN(Total_Price,Qty_Delivered,Date,Users_ID,Purchase_OrderNo) values ('" + Total_Price + "','" + Qty_Delivered+ "', '" + Date + "','" + Users_ID + "','" + Purchase_OrderNo + "')", con);
                line = cmd.ExecuteNonQuery();
                if (line==0)
                {
                    MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                  //  MessageBox.Show("Data entered successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                String Sql = "SELECT  TOP 1 GRN.GRN_No FROM GRN ORDER BY GRN_No DESC";
                cmdd = new SqlCommand(Sql, con);
                DR = cmdd.ExecuteReader();
                while (DR.Read())
                {
                    GRN_No = Convert.ToInt32(DR[0]);

                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return GRN_No;
        }


    }
}
