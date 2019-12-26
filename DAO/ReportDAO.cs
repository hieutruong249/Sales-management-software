using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ReportDAO
    {
        public DataTable ShowReport()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT ProductID, ProductName, UnitID, CurrInventory, Purchase, CatergoryID, WarehouseID " +
                    "FROM Products";
                provider.Connect();
                DataTable dtbl = new DataTable();
                dtbl = provider.Select(CommandType.Text, strSQL);
                return dtbl;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }

        }

        public DataTable ShowReport(string warehouseID)
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT ProductID, ProductName, UnitID, CurrInventory, Purchase, CatergoryID, WarehouseID " +
                    "FROM Products WHERE WarehouseID = '" + warehouseID +"'";
                provider.Connect();
                DataTable dtbl = new DataTable();
                dtbl = provider.Select(CommandType.Text, strSQL);
                return dtbl;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }

        }
    }
}
