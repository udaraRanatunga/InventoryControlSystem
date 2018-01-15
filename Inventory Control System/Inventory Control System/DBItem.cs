using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    public partial class DBItem
    {
        SqlConnection con;
        SqlCommand cmd,cmdd;
        SqlDataReader DR=null;
        SqlDataAdapter da = null;
        int line;
        private int Item_No, Item_Qty, Item_Price, Users_ID, Supplier_ID;
        private String Item_Name, Item_Status, Item_Description;
        private String Date_Modified = System.DateTime.Now.ToShortDateString();

        internal SqlDataAdapter getItemDetails()
        {
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                cmd = new SqlCommand("Select Item.Item_No,Item.Item_Name, Item.Item_Description, Item.Item_Status, Item.Item_Price, Item.Item_Qty , Supplier.Supplier_Name from Item inner join Supplier on Item.Supplier_ID= Supplier.Supplier_ID ", con);
                da = new SqlDataAdapter(cmd);
            }
            catch (SqlException)
            {

                MessageBox.Show("Please enter the data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return da;
        }

        public int setItem(String name , int price, int qty, String status,  String des, int u_id, int sup)
        {
            try
          {
            Item_Name = name;
            Item_Price = price;
            Item_Qty = qty;
            Item_Status = status;
            Item_Description = des;
            Users_ID = u_id;
            Supplier_ID = sup;
            DataBase db = new DataBase();
            con = db.getConnection();
            con.Open();
            
            cmd = new SqlCommand("Insert into Item(Item_Name,Item_Description,Item_Status,Item_Price,Item_Qty,Users_ID,Supplier_ID,Date_Modified) values ('" + Item_Name + "','" + Item_Description+ "','" + Item_Status + "', '" + Item_Price + "','" +Item_Qty+ "','"+Users_ID+"','"+Supplier_ID+"','"+Date_Modified+"')", con);
            line = cmd.ExecuteNonQuery();
            
           
          }

            catch (SqlException)
            {
                MessageBox.Show("Please enter the details again ","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
                    
            }
           return line;
         }
        public SqlDataAdapter getItem()
        {
          
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                cmd = new SqlCommand("Select Item_No,Item_Name, Item_Description, Item_Status, Item_Price, Item_Qty , Supplier_ID from Item ", con);
                da = new SqlDataAdapter(cmd);
            }
            catch(SqlException )
            {

               MessageBox.Show("Please enter the details and try again", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
          
            return da;
        }

        
        public SqlDataReader getName()
        {
            
            try
            {
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select Item_Name from Item";
                cmd = new SqlCommand(Sql, con);
                DR = cmd.ExecuteReader();
            }
            catch(SqlException)
            {
                MessageBox.Show("Please enter the details and try again","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
            return DR;

        }
        public int updateItem(int no,String name, int price, int qty, String status, String des, int u_id, int sup ,String date)
        {
            try
            {
                Item_No = no;
                Item_Name = name;
                Item_Price = price;
                Item_Qty = qty;
                Item_Status = status;
                Item_Description = des;
                Date_Modified = date;
                Users_ID = u_id;
                Supplier_ID = sup;
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();

                cmd = new SqlCommand("Update Item set Item_Name='"+Item_Name+"',Item_Description='"+Item_Description+"',Item_Status='"+Item_Status+"',Item_Price='"+Item_Price+"',Item_Qty='"+Item_Qty+"',Users_ID='"+Users_ID+"',Supplier_ID='"+Supplier_ID+"', Date_Modified ='"+Date_Modified+"' where Item_No ='"+Item_No+"'", con);
                line = cmd.ExecuteNonQuery();


            }

            catch (SqlException )
            {
                MessageBox.Show("Please enter the details and try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            return line;
        }

        public SqlDataReader getName(int no)
        {

         
            try
            {
                Item_No = no;
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select Item_Name from Item where Item_No ='" + Item_No + "'";
                cmd = new SqlCommand(Sql, con);
                DR = cmd.ExecuteReader();
               
            }
            catch (SqlException)
            {
                MessageBox.Show("Please enter the details and try again", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
            return DR;

        }

       
        public int getItemNo(String name)
        {

          
            try
            {
                Item_Name = name;
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select Item_No from Item where Item_Name ='" +Item_Name+ "'";
                cmd = new SqlCommand(Sql, con);
                DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    Item_No = Convert.ToInt32(DR[0]);


                }
            }
           catch(SqlException)
            {
                MessageBox.Show("Please enter the details and try again", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            return Item_No;

        }

        internal SqlDataReader getItemNames(String supName)
        {
            try
            {
               
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select Item.Item_Name from Item inner join Supplier on Supplier.Supplier_ID= Item.Supplier_ID where Supplier.Supplier_Name ='" + supName+ "'";
                cmd = new SqlCommand(Sql, con); 
                DR = cmd.ExecuteReader();
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Please enter the details and try again","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            return DR;

        }

        public int getItemPrice(String name)
        {

        
            try
            {
                Item_Name = name;
                DataBase db = new DataBase();
                con = db.getConnection();
                con.Open();
                string Sql = "select Item_Price from Item where Item_Name ='" + Item_Name + "'";
                 cmd = new SqlCommand(Sql, con);
                DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    Item_No = Convert.ToInt32(DR[0]);


                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Please enter the details and try again","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return Item_No;

        }
    

        public void updateQty(int itemno, int itemQty ,string date,int flag)
        {
            String ItemName ="";
            Item_No = itemno;
            Item_Qty = itemQty;
            Date_Modified = date;
            DataBase db = new DataBase();
            con = db.getConnection();
            con.Open();
            int qty=0,Qty=0;
            String sql = "SELECT Item_Qty from Item where Item_No='" + Item_No + "'";
            cmd = new SqlCommand(sql, con);
            DR = cmd.ExecuteReader();
            while(DR.Read())
            {
                qty = Convert.ToInt32(DR[0]);
            }
            if (flag == 1)
            {
                if (qty > 10)
                {
                    Qty = qty - Item_Qty;
                }
                 else
                {
                    DR = getName(Item_No);
                    while (DR.Read())
                    {
                        ItemName = DR[0].ToString();
                    }
                    String text = $"Not enough stock of {ItemName}, Please Re-stock! ";
                    MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Qty = qty + Item_Qty;
            }
            if (Qty<=10)
            {
                DR= getName(Item_No);
                while (DR.Read())
                {
                     ItemName = DR[0].ToString();
                }
                String text = $"Not enough stock of {ItemName}, Please Re-stock! ";
                smsgateway  s = new smsgateway();
               // String sqll = "Select User_Mobile from System_Users where Users_ID= 2";

                s.sendmsg("thisarani", "i43Android", "+94764181619",text);
            }
            
            updQty2(Qty,Date_Modified,Item_No);
           

        }
        public void updQty2(int itemQty,String date ,int itemno)
        {
            Item_Qty = itemQty;
            Date_Modified = date;
            Item_No = itemno;
            DataBase db = new DataBase();
            con = db.getConnection();
            con.Open();
            String sql2 = "Update Item set Item_Qty='" + Item_Qty + "', Date_Modified ='" + Date_Modified + "'where Item_No ='" + Item_No+ "'";
            cmdd = new SqlCommand(sql2, con);
            line = cmdd.ExecuteNonQuery();

        }
      

    }

}

