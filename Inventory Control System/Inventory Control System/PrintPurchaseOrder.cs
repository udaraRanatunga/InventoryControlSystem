using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.VisualBasic;
using Dapper;
using System.Data.SqlClient;

namespace Inventory_Control_System
{
    public partial class PrintPurchaseOrder : MetroFramework.Forms.MetroForm
    {
        SqlConnection con;
        public PrintPurchaseOrder()
        {
            InitializeComponent();
        }
        int u_id;
        public void setid(int a)
        {
            u_id = a;
        }
        private void PrintPurchaseOrder_Load(object sender, EventArgs e)
        {
            String sql="";
            DataBase db = new DataBase();
            con = db.getConnection();
            using (con)
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        sql = "select Purchase_Order.Purchase_OrderNo, Purchase_Order.Purchase_OrderDate,Item.Item_Name,Purchase_Item_reference.Item_Qty, Purchase_Item_reference.Sub_Total , Supplier.Supplier_Name,Supplier.Supplier_Address,Supplier.Supplier_Mobile,Purchase_Order.Users_ID "
                           + "from Purchase_Order inner join Purchase_Item_reference on Purchase_Order.Purchase_OrderNo = Purchase_Item_reference.Purchase_OrderNo inner join Item on Item.Item_No = Purchase_Item_reference.Item_No inner join Supplier on Purchase_Order.Suppplier_ID = Supplier.Supplier_ID";
                           
                    }
                    ordersBindingSource.DataSource = con.Query<Orders>(sql, commandType: CommandType.Text);
                }
                catch(SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Purchase_Order p = new Purchase_Order();
            this.Hide();
            p.Show();
            p.setid(u_id);
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            String sql = "";
            DataBase db = new DataBase();
            con = db.getConnection();
            using (con)
            {
                try
                {
                    Orders obj = ordersBindingSource.Current as Orders;
                    
                    if (obj != null)
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                            sql = "select Purchase_Order.Purchase_OrderNo, Purchase_Order.Purchase_OrderDate,Item.Item_Name,Purchase_Item_reference.Item_Qty, Purchase_Item_reference.Sub_Total , Supplier.Supplier_Name,Supplier.Supplier_Address, Supplier.Supplier_Mobile,Purchase_Order.Users_ID "
                               + "from Purchase_Order inner join Purchase_Item_reference on Purchase_Order.Purchase_OrderNo = Purchase_Item_reference.Purchase_OrderNo inner join Item on Item.Item_No = Purchase_Item_reference.Item_No inner join Supplier on Purchase_Order.Suppplier_ID = Supplier.Supplier_ID"
                               + $" where Purchase_Order.Purchase_OrderNo = '{obj.Purchase_OrderNo}'";
                            List <OrdersDetail> list = con.Query<OrdersDetail>(sql, commandType: CommandType.Text).ToList();
                            using (PrintForm pf = new PrintForm(obj, list))
                            {
                               // this.Hide();
                                pf.ShowDialog();
                            }
                        }
                       
                    }
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }
    }
}
