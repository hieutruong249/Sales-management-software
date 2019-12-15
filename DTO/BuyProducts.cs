using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BuyProducts
    {
        public string BillID { get; set; }
        public string WarehouseID { get; set; }
        public string SupplierID { get; set; }
        public string StaffID { get; set; }
        public string Phone { get; set; }
        public string NumVAT { get; set; }
        public string ExperiDate { get; set; }
        public string Date {get;set;}
        public string Address { get; set; }
        public string Note { get; set; }
        public double Total { get; set; }
        
    }
}
