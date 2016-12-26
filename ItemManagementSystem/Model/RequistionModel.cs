using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemManagementSystem.Model
{
    class RequistionModel
    {
        public int Id { get; set; }
        public int SlNo { get; set; }
        public string ReqBy { get; set; }
        public int DepartmentId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ReqDate { get; set; }
        public string CategoryModel { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public int SupplierId { get; set; }
    }
}
