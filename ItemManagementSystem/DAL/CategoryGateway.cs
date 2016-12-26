using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManagementSystem.Model;

namespace ItemManagementSystem.DAL
{
    class CategoryGateway:Gateway
    {
        public int SaveCategory(CategoryModel aCategory)
        {
            Query = "Insert Into Category(Name,Status) Values('"+aCategory.Name+"','"+aCategory.Status+"')";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            int rowAffected=Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<CategoryModel> GetCategory()
        {
            List<CategoryModel>aListDepartment=new List<CategoryModel>();
            Query = "SELECT * FROM Category";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Reader=Command.ExecuteReader();
            while (Reader.Read())
            {
                CategoryModel aDepartment=new CategoryModel();
                aDepartment.Id = Convert.ToInt32(Reader["Id"]);
                aDepartment.Name = Reader["Name"].ToString();
                aListDepartment.Add(aDepartment);
            }
            Connection.Close();
            Reader.Close();
            return aListDepartment;
        }
        
        public bool ExistCategory(CategoryModel aCategory)
        {
            Query = "SELECT * FROM Category WHERE Name=('" + aCategory.Name + "')";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool hasRows;
            if (Reader.Read())
            {
                Reader.Close();
                Connection.Close();
                return hasRows=true;
            }
            else
            {
                Reader.Close();
                Connection.Close();
                return hasRows = false;
            }
        }
    }
}
