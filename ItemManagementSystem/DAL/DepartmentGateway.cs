using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManagementSystem.Model;

namespace ItemManagementSystem.DAL
{
    class DepartmentGateway:Gateway
    {
        public List<Department> GetDepartment()
        {
            List<Department>aListDepartment=new List<Department>();
            Query = "SELECT * FROM Department";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Reader=Command.ExecuteReader();
            while (Reader.Read())
            {
                Department aDepartment=new Department();
                aDepartment.Id = Convert.ToInt32(Reader["Id"]);
                aDepartment.Name = Reader["Name"].ToString();
                aListDepartment.Add(aDepartment);
            }
            Connection.Close();
            Reader.Close();
            return aListDepartment;
        }
        

    }
}
