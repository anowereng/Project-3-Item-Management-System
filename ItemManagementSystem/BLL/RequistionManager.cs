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
    class RequistionManager
    {
        RequistionGateway aGateway=new RequistionGateway();
        public string SaveRequistion(RequistionModel aRequistion)
        {
            if (aGateway.SaveRequistion(aRequistion) > 0)
            {
                return "Save Success";
            }
            else
            {
                return "Save Failed";
            }
        }

        public List<RequistionView> GetRequistion()
        {
            return aGateway.GetRequistion();
        }

    }
}
