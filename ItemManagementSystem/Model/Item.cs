using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemManagementSystem.Model
{
    class Item
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string CategoryId { get; set; }
        public DateTime BuyDate { get; set; }
        public int WarrantyId { get; set; }
        public  int SupplierId { get; set; }
    }
}
