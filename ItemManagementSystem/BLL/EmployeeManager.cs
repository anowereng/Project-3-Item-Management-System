using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManagementSystem.DAL;
using ItemManagementSystem.Model;
using ItemManagementSystem.Model.View;

namespace ItemManagementSystem.BLL
{
    class EmployeeManager
    {
        EmployeeGateway aEmployeeGateway=new EmployeeGateway();

        public string SaveEmployee(EmployeeModel aModel)
        {
            if (aEmployeeGateway.SaveEmployee(aModel) > 0)
            {
                return "Employee Saved";
            }
            else
            {
                return "Save Failed!!";
            }
        }

        public List<EmployeeView> GetEmployee()
        {
            return aEmployeeGateway.GetEmployee();
        }

        public string UpdateEmployee(EmployeeModel aEmployeeModel)
        {
            if (aEmployeeGateway.UpdateEmployee(aEmployeeModel) > 0)
            {
                return "Employee Updated";
            }
            else
            {
                return "Update Failed!!";
            }
        }

        public string DeleteEmployee(EmployeeModel aEmployeeModel)
        {
            if (aEmployeeGateway.DeleteEmployee(aEmployeeModel) > 0)
            {
                return "Employee "+aEmployeeModel.Name+" Delete SuccessFully";
            }
            else
            {
                return "Delete Failed!!";
            }
        }

        public List<EmployeeModel> GetEmployeeById(int id)
        {
            return aEmployeeGateway.GetEmployeeById(id);
        }
    }
}
