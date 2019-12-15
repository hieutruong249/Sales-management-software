using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BuyProductDetail
    {
        public string BillID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string UnitID { get; set; }
        public int Amount { get; set; }
        public double Total { get; set; }
    }
}
