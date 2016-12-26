using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemManagementSystem.DAL;
using ItemManagementSystem.Model;

namespace ItemManagementSystem.BLL
{
    class CategoryManager
    {
        CategoryGateway aGateway=new CategoryGateway();

        public string SaveCategory(CategoryModel aCategory)
        {
            if(aGateway.ExistCategory(aCategory)==false)
            {
                if (aGateway.SaveCategory(aCategory) > 0)
                {
                    return "Save Success";
                }
                else
                {
                    return "Save Failed";
                }
            }
            else
            {
                return "Category Already added";
            }
            
        }

        public List<CategoryModel> GetCategoryModel()
        {
           return  aGateway.GetCategory();
        }
    }
}
