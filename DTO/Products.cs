using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Products
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string CatergoryID { get; set; }
        public string WarehouseID { get; set; }
        public string UnitID { get; set; }
        public string Origin { get; set; }
        public int MinInventory { get; set; }
        public int CurrInventory { get; set; }
        public string Supplier { get; set; }
        public double Purchase { get; set; }
        public double Retail { get; set; }
        public double Wholesale { get; set; }
        public string Image { get; set; }

    }
}
