using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManagementSystem.Model;
using ItemManagementSystem.Model.View;

namespace ItemManagementSystem.DAL
{
    class EmployeeGateway:Gateway
    {
        public int SaveEmployee(EmployeeModel aEmployee)
        {
            Query = "Insert Into Employee(Name,DepartmentId,DesignationId,Email,Password) Values('" + aEmployee.Name + "'," + aEmployee.DepartmentId + "," + aEmployee.DesignationId + ",'" + aEmployee.Email + "','" + aEmployee.Password + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
        public List<EmployeeView> GetEmployee()
        {
            List<EmployeeView> aEmployeeList = new List<EmployeeView>();
            Query = "Select * from EmployeeView";
            //Adapter=new SqlDataAdapter(Query,Connection);
            //DataTable=new DataTable();
            //Adapter.Fill(DataTable);

            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                EmployeeView aModel = new EmployeeView();

                //aModel.Id = Convert.ToInt32(Reader["Id"]);
                aModel.Name = Reader["EmployeeName"].ToString();
                aModel.Department = Reader["Department"].ToString();
                aModel.Designation = Reader["Designation"].ToString();
                aModel.Email = Reader["Email"].ToString();
                aModel.Password = Reader["Password"].ToString();
                aEmployeeList.Add(aModel);
            }
            Connection.Close();
            Reader.Close();
            return aEmployeeList;
        }

        public int UpdateEmployee(EmployeeModel aEmployee)
        {
            Query = "Update Employee SET Name='"+aEmployee.Name+"',DepartmentId="+aEmployee.DepartmentId+",DesignationId="+aEmployee.DesignationId+",Email='"+aEmployee.Email+"',Password='"+aEmployee.Password+"' WHERE Id="+aEmployee.Id+" ";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public int DeleteEmployee(EmployeeModel aEmployeeModel)
        {
            Query = "Delete Employee WHERE Id=" + aEmployeeModel.Id + " ";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<EmployeeModel> GetEmployeeById(int id)
        {
            Query = "Select * from Requistion where DepartmentId=" + id;
             List<EmployeeModel> aEmployeeModel = new List<EmployeeModel>();
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                EmployeeModel aEmployee = new EmployeeModel();

                aEmployee.Id = Convert.ToInt32(Reader["Id"]);
                aEmployee.Name = Reader["Name"].ToString();
                aEmployeeModel.Add(aEmployee);
            }
            Connection.Close();
            return aEmployeeModel;
        
        }
    }
}
