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
    public class BuyProductBUS
    {
        BuyProductDAO dao = new BuyProductDAO();
        public int InsertBillBuyProduct(BuyProducts e)
        {
            return dao.InsertBillBuyProduct(e);
        }
        public int InsertBillBuyProductDetail(BuyProductDetail e)
        {
            return dao.InsertBillBuyProductDetail(e);
        }
        public DataTable ShowBill()
        {
            return dao.ShowBill();
        }
    }
}
