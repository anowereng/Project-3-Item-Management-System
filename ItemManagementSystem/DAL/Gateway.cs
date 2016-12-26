using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemManagementSystem.DAL
{
    class Gateway
    {
        private string connectionstring = @"Data Source=FIREBUG\SQLEXPRESS;Initial Catalog=Item_db;Integrated Security=True";
            public SqlConnection Connection { set; get; }
            public SqlDataReader Reader { get; set; }
            public SqlCommand Command { get; set; }
            public SqlDataAdapter Adapter { get; set; }
            public DataTable DataTable { get; set; }
            public string Query { set; get; }

            public Gateway()
            {
                Connection = new SqlConnection(connectionstring);
            }
        
    }
}
