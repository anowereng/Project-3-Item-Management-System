using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManagementSystem.Model;

namespace ItemManagementSystem.DAL
{
    class SupplierGateway:Gateway
    {
        public int SaveSupplier(SupplierModel aSupplier)
        {
            Query = "Insert Into Supplier(Name,Company,Email,Contact,Address) Values('" + aSupplier.Name + "','" + aSupplier.Comapany + "','" + aSupplier.Email + "','" + aSupplier.Contact + "','" + aSupplier.Address + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
