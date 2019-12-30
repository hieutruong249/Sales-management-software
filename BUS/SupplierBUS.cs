using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class SupplierBUS: FatherBUS
    {
        SupplierDAO supplierDAO = new SupplierDAO();
        public int InsertSupplier(Suppliers spl)
        {
            return supplierDAO.InsertSupplier(spl);
        }
        public int UpdateSupplier(Suppliers spl)
        {
            return supplierDAO.UpdateSupplier(spl);
        }
        public int DeleteSupplier(Suppliers spl)
        {
            return supplierDAO.DeleteSupplier(spl);
        }
        public DataTable ShowSupplier()
        {
            return supplierDAO.ShowSupplier();
        }
        public DataTable ShowSupplier(string supplierID)
        {
            return supplierDAO.ShowSupplier(supplierID);
        }
    }
}
