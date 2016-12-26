using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ItemManagementSystem.Model;
using ItemManagementSystem.Model.View;

namespace ItemManagementSystem.DAL
{
    class RequistionGateway:Gateway
    {
        public int SaveRequistion(RequistionModel aRequistion)
        {
            Query = "Insert Into Requistion(ReqSl,ReqBy,DepartmentId,EmployeeId,ReqDate,CategoryId,Quantity,SupplierId) Values(" + aRequistion.SlNo + ",'" + aRequistion.ReqBy + "'," + aRequistion.DepartmentId + "," + aRequistion.EmployeeId + ",'" + aRequistion.ReqDate + "','" + aRequistion.CategoryModel + "'," + aRequistion.CategoryId + ",'" + aRequistion.Quantity + "'," + aRequistion.SupplierId + ")";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<RequistionView> GetRequistion()
        {
            List<RequistionView> aRequistionView = new List<RequistionView>();
             Query = "Select * from RequistionView";
             //Adapter=new SqlDataAdapter(Query,Connection);
             //DataTable=new DataTable();
             //Adapter.Fill(DataTable);

             Command = new SqlCommand(Query, Connection);
             Connection.Open();
             Reader = Command.ExecuteReader();
             while (Reader.Read())
             {
                 RequistionView aModel = new RequistionView();

                 aModel.ReqSl = Convert.ToInt32(Reader["ReqSl"]);              
                 aModel.ReqBy = Reader["ReqBy"].ToString();
                 aModel.Department = Reader["Department"].ToString();
                 aModel.Employee = Reader["Employee"].ToString();
                 aModel.Date = Convert.ToDateTime(Reader["ReqDate"]);
                 aModel.Category = Reader["Category"].ToString();
                 aModel.Quantity = Convert.ToInt32(Reader["Quantity"]);
                 aModel.Supplier = Reader["Supplier"].ToString();
                 aRequistionView.Add(aModel);
             }
             Connection.Close();
             Reader.Close();
            return aRequistionView;
        }
    }
}
