using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Control_System
{
   public class OrdersDetail
    {
        public int Purchase_OrderNo { get; set; }
        public String Purchase_OrderDate { get; set; }
        public String Item_Name { get; set; }
        public int Item_Qty { get; set; }
        public int Sub_Total { get; set; }
        public String Supplier_Name { get; set; }
        public String Supplier_Address { get; set; }
        public int Supplier_Mobile { get; set; }
        public int Users_ID { get; set; }
    }
}
