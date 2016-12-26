using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManagementSystem.DAL;
using ItemManagementSystem.Model;

namespace ItemManagementSystem.BLL
{
    class DepartmentManager
    {
        DepartmentGateway aGateway=new DepartmentGateway();
        public List<Department> GetDepartment()
        {
            return aGateway.GetDepartment();
        }
    }
}
