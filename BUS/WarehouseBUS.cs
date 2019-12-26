using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class WarehouseBUS : FatherBUS
    {
        WarehouseDAO warehouseDAO = new WarehouseDAO();
        public int InsertWarehouse(Warehouses wh)
        {
            return warehouseDAO.InsertWarehoue(wh);
        }
        public int UpdateWarehouse(Warehouses wh)
        {
            return warehouseDAO.UpdateWarehoue(wh);
        }
        public int DeleteWarehouse(Warehouses wh)
        {
            return warehouseDAO.DeleteWarehoue(wh);
        }
        public DataTable ShowWarehouses()
        {
            return warehouseDAO.ShowWarehouses();
        }
    }
}
