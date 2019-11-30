using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Order
    {
        private string _orderDate;
        private int _orderID;
        private int _userID;
        private double _totalmoney;

        public string OrderDate { get => _orderDate; set => _orderDate = value; }
        public int OrderID { get => _orderID; set => _orderID = value; }
        public int UserID { get => _userID; set => _userID = value; }
        public double Totalmoney { get => _totalmoney; set => _totalmoney = value; }
    }
}
