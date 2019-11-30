using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class CustomerBUS: FatherBUS
    {
        CustomerDAO customerDAO = new CustomerDAO();
        public int InsertCustomer(Customers ctm)
        {
            return customerDAO.InsertCustomer(ctm);
        }
        public int UpdateCustomer(Customers ctm)
        {
            return customerDAO.UpdateCustomer(ctm);
        }
        public int DeleteCustomer(Customers ctm)
        {
            return customerDAO.DeleteCustomer(ctm);
        }
        public DataTable ShowCustomer()
        {
            return customerDAO.ShowCustomer();
        }
    }
}
