using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManagementSystem.DAL;
using ItemManagementSystem.Model;

namespace ItemManagementSystem.BLL
{
    class SupplierManager
    {
        SupplierGateway aGateway=new SupplierGateway();
        public string SupplierSave(SupplierModel aSupplierModel)
        {
            if (aGateway.SaveSupplier(aSupplierModel) > 0)
            {
                return "Supplier " + aSupplierModel.Name + " Save SuccessFully";
            }
            else
            {
                return "Save Failed!!";
            }
        }
    }
}
