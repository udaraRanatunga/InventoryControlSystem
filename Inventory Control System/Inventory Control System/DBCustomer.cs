using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    class DBCustomer
    {
        SqlConnection con;
        SqlCommand cmd;
        int line;
        private int Customer_No,Customer_Mobile,Users_ID;
        private String Customer_Name, Customer_Address, Customer_NIC;

        public int setCustomer(String name, String add, int tele, String nic, int u_id)
        {

            try
            {
                Customer_Name = name;
                Customer_Address = add;
                Customer_Mobile = tele;
                Customer_NIC = nic;
                Users_ID = u_id;

                DataBase dbcon = new DataBase();
                con = dbcon.getConnection();
                con.Open();
                cmd = new SqlCommand("Insert into Customer(Customer_Name,Customer_Address,Customer_NIC,Customer_Mobile,Users_ID) values ('" + Customer_Name + "','" + Customer_Address + "','" + Customer_NIC + "', '" + Customer_Mobile+ "','" + Users_ID + "')", con);
                line = cmd.ExecuteNonQuery();
                if (line != 1)
                {
                   MessageBox.Show("Data Saving encountered a problem", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Data successfully added to the database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch (SqlException )
            {
                MessageBox.Show("Please enter the data and try again","Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            return line;

        }
        public SqlDataReader getNic()
        {
            SqlDataReader DR=null;
           
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select Customer_NIC from Customer";
                SqlCommand cmd = new SqlCommand(Sql, con);
                DR = cmd.ExecuteReader();
          
            }
            catch(SqlException)
            {
               MessageBox.Show("Please enterthe data and try again","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }

            return DR;

        }
        public int getCus_No(String name)
        {
            Customer_Name = name;
            SqlDataReader DR;
            try
            {
               
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select Customer_No from Customer where Customer_Name ='" +Customer_Name + "'";
                SqlCommand cmd = new SqlCommand(Sql, con);
                DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    Customer_No = Convert.ToInt32(DR[0]);

                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Please enter the data and try again","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            return Customer_No;
        }

        public int getCusNo(String nic)
        {
            Customer_NIC = nic;
            SqlDataReader DR;
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                String Sql = "Select Customer_No from Customer where Customer_NIC ='" + Customer_NIC+ "'";
                SqlCommand cmd = new SqlCommand(Sql, con);
                DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    Customer_No= Convert.ToInt32(DR[0]);

                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Please enter the data and try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
            

            return Customer_No;
        }
        public SqlDataAdapter getCustomer()
        {
            SqlDataAdapter da = null;
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                cmd = new SqlCommand("Select Customer_Name,Customer_Address,Customer_NIC,Customer_Mobile from Customer ", con);
                da = new SqlDataAdapter(cmd);
            }
            catch (SqlException)
            {

                MessageBox.Show("Please enter the data and try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return da;
        }

        public int updateCustomer(String name, String add, String nic, int tele, int u_id,int no)
        {
            try
            {
                Customer_Name = name;
                Customer_Address = add;
                Customer_NIC = nic;
                Customer_Mobile = tele;
                Users_ID = u_id;
                Customer_No = no;
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Update Customer set Customer_Name='" +Customer_Name+ "',Customer_Address='" + Customer_Address + "',Customer_NIC='" + Customer_NIC+ "',Customer_Mobile='" + Customer_Mobile + "',Users_ID='" +Users_ID + "'where Customer_No ='" + Customer_No + "'", con);
                line = cmd.ExecuteNonQuery();


            }

            catch (SqlException e)
            {
                MessageBox.Show("Please enter the data and try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            return line;
        }

    }
}
