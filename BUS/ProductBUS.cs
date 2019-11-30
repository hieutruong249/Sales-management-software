using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class ProductBUS: FatherBUS
    {
        ProductDAO productDAO = new ProductDAO();
        public DataTable ShowProducts()
        {
            return productDAO.ShowProducts();
        }
        public int InsertProduct(Product u)
        {
            return productDAO.InsertProduct(u);
        }
        public int UpdateProduct(Product u)
        {
            return productDAO.UpdateProduct(u);
        }
        public int DeleteProduct(Product u)
        {
            return productDAO.DeleteProduct(u);
        }

    }
}
