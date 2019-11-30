using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetail
    {
        private int _orderID;
        private int _productID;
        private int _quantity;
        private float _price;
        private float _amount;

        public int OrderID { get => _orderID; set => _orderID = value; }
        public int ProductID { get => _productID; set => _productID = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public float Price { get => _price; set => _price = value; }
        public float Amount { get => _amount; set => _amount = Quantity * Price; }
    }
}
