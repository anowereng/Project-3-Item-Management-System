using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManagementSystem.DAL;
using ItemManagementSystem.Model;

namespace ItemManagementSystem.BLL
{
    class DesignationManager
    {
        DesignationGateway aGateway = new DesignationGateway();
        public List<Designation> GetDesignation()
        {
            return aGateway.GetDesignation();
        }
    }
}
