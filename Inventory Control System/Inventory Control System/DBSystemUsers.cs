using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    public class DBSystemUsers
    {
        SqlDataReader DR;
        SqlConnection con;
        SqlCommand cmd;
        String User_Name, User_Address, User_Status, User_Password;
        int User_Mobile,Users_ID;
        public DBSystemUsers()
        {
            
        }

        public SqlDataAdapter getUser()
        {
            SqlDataAdapter da = null;
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                cmd = new SqlCommand("Select Users_ID,User_Mobile, User_Status,User_Address,User_Name,Password from System_Users ", con);
                da = new SqlDataAdapter(cmd);
            }
            catch (SqlException)
            {

                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return da;
        }

        public int setSystemUser(int id,String name, String add, String status, int tele,String pw)
        {
            int line=0;
            try
            {
                Users_ID = id;
                User_Name = name;
                User_Address = add;
                User_Status = status;
                User_Mobile = tele;
                User_Password = pw;
                DataBase dbcon = new DataBase();
                con = dbcon.getConnection();
                con.Open();
                cmd = new SqlCommand("Insert into System_Users(Users_ID,User_Mobile, User_Status, User_Address,User_Name, User_Password) values ('" + Users_ID + "','" + User_Mobile + "','" + User_Status + "', '" + User_Address + "','" + User_Name + "','"+User_Password+"')", con);
                line = cmd.ExecuteNonQuery();
                if (line != 1)
                {
                    MessageBox.Show("Data Saving encountered a problem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Data successfully added to the database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        
            catch(SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return line;
        }

        public int getSysNo(string name)
        {
            int u_id=0;
          try
            {
                DataBase dbcon = new DataBase();
                con = dbcon.getConnection();
                con.Open();
                cmd = new SqlCommand("Select Users_ID from System_Users where User_Name =='" + User_Name + "')", con);
                DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    Users_ID = Convert.ToInt32(DR[0]);

                }
                u_id = Users_ID;
            }
            catch(SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return u_id;
        }

        public int updateSysUser(string name, string add, string status, int tele, int no, string pw)
        {
            int line = 0;
            try
            {
                
                User_Name = name;
                User_Address = add;
                User_Status = status;
                User_Mobile = tele;
                User_Password = pw;
               
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Update System_Users set Users_ID='" + no + "',User_Mobile='" + User_Mobile + "',User_Status='" + User_Status + "',User_Address='" + User_Address + "',User_Name='" + User_Name + "'where Users_ID ='" + Users_ID + "'", con);
                line = cmd.ExecuteNonQuery();


            }
            catch(SqlException)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return line;
        }
    }
}