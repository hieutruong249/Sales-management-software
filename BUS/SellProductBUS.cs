using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class SellProductBUS
    {
        SellProductDAO dao = new SellProductDAO();
        public int InsertBillSellProduct(BuyProducts e)
        {
            return dao.InsertBillSellProduct(e);
        }
        public DataTable ShowCurrency(int index)
        {
            return dao.ShowCurrency(index);
        }
    }
}
