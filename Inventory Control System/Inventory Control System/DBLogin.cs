using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    class DBLogin
    {
        
        public int login(String pw , String uname)
        {
            SqlConnection con;
            SqlDataAdapter da;
            int count = 0;
            int id = 0;

            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                da = new SqlDataAdapter("Select Users_ID, User_Name , Password ,User_Status from System_Users where User_Name ='" + uname + "' and Password='" + pw + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                 count = ds.Tables[0].Rows.Count;
                id = Convert.ToInt32(ds.Tables[0].Rows[0]["Users_ID"]);
                String user = ds.Tables[0].Rows[0]["User_Name"].ToString();
                String pass = ds.Tables[0].Rows[0]["Password"].ToString();
                String u_status = ds.Tables[0].Rows[0]["User_Status"].ToString();
                if (count == 1)
                {
                    // success
                    if (u_status == "Manager")
                    {
                        id = 1;
                    }
                    else if (u_status == "User")
                    {
                        id = 2;
                    }

                }
                else
                {
                    MessageBox.Show("Enter Valid Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }


            }
            catch (SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }
    }
}
