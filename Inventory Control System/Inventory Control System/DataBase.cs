using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inventory_Control_System
{
    public partial class DataBase
    {
        SqlConnection con;

        public SqlConnection getConnection()
        {
            String db = "Data Source=.;Initial Catalog=Inventory;Integrated Security=True";
            con = new SqlConnection(db);
            return con;

        }
    }
}
