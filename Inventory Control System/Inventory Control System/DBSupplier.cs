using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Inventory_Control_System;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    public partial class DBSupplier
    {
        SqlConnection con;
        SqlCommand cmd;
        int line,Supplier_Mobile,Users_ID;
        String Supplier_Name, Supplier_Address, Supplier_Status;
        
        public void setSupplier(String name, String add, int mob, String status, int u_id)
        {
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                cmd = new SqlCommand("Insert into Supplier (Supplier_Name,Supplier_Address,Supplier_Status,Supplier_Mobile,Users_ID) values ('" + name + "','" + add + "','" + status + "', '" + mob + "','" + u_id + "')", con);
                line = cmd.ExecuteNonQuery();
                if (line != 1)
                {
                   MessageBox.Show("Data Saving encountered a problem","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data entered successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

            catch (SqlException e)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        public SqlDataAdapter getSup()
        {
            SqlDataAdapter da = null;
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                cmd = new SqlCommand("Select Supplier_Name,Supplier_Address,Supplier_Status,Supplier_Mobile from Supplier ", con);
                da = new SqlDataAdapter(cmd);
            }
            catch (SqlException)
            {

                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return da;
        }

        public SqlDataReader getSupplier()
        {
                SqlDataReader DR;
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select Supplier_Name from Supplier";
                SqlCommand cmd = new SqlCommand(Sql, con);
               
                DR = cmd.ExecuteReader();
                return DR;
        }
        public String getName(int sup)
        {
            
            SqlDataReader DR; String name = "";
            DataBase db = new DataBase();
            con = db.getConnection();
            con.Open();
            string Sql = "select Supplier_Name from Supplier where Supplier_ID ='"+sup+"'";
            SqlCommand cmd = new SqlCommand(Sql, con);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                name = (string)DR[0];


            }

            return name;

        }
        public int getSupNo(String name)
        {
            SqlDataReader DR;
            int no = 0;
            DataBase db = new DataBase();
            con = db.getConnection();
            con.Open();
            string Sql = "select Supplier_ID  from Supplier where Supplier_Name ='" + name + "'";
            SqlCommand cmd = new SqlCommand(Sql, con);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                no = Convert.ToInt32(DR[0]);
            }

            return no;

        }
        public int updateSupplier(String name, String add, String status, int tele,int  u_id,int  no)
        {
            try
            {

                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
              
                cmd = new SqlCommand("Update Supplier set Supplier_Name='" + name + "',Supplier_Address='" + add + "',Supplier_Status='" + status + "',Supplier_Mobile='"+tele+"',Users_ID='" + u_id + "' where Supplier_ID='" + no + "'", con);
                line = cmd.ExecuteNonQuery();
                

            }

            catch (SqlException e)
            {
                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return line;
        }
    }
}
