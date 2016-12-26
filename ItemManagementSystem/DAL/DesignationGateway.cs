using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManagementSystem.Model;

namespace ItemManagementSystem.DAL
{
    class DesignationGateway:Gateway
    {
        public List<Designation> GetDesignation()
        {
            List<Designation> aListDesignation = new List<Designation>();
            Query = "SELECT * FROM Designation";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Designation aDesignation = new Designation();
                aDesignation.Id = Convert.ToInt32(Reader["Id"]);
                aDesignation.Name = Reader["Name"].ToString();
                aListDesignation.Add(aDesignation);
            }
            Connection.Close();
            Reader.Close();
            return aListDesignation;
        }
    }
}
