using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class SellProductDAO
    {
        public int InsertBillSellProduct(BuyProducts e)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO SellProduct VALUES(@BillID, @CustomerID, @WarehouseID, @StaffID, @Phone, @NumVAT, @Date, @ExDate, @Address, @Note, @Total)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@BillID", Value = e.BillID },
                        new SqlParameter { ParameterName = "@WarehouseID", Value = e.WarehouseID },
                        new SqlParameter { ParameterName = "@StaffID", Value = e.StaffID },
                        new SqlParameter { ParameterName = "@Phone", Value = e.Phone },
                        new SqlParameter { ParameterName = "@NumVAT", Value = e.NumVAT },
                        new SqlParameter { ParameterName = "@Date", Value = e.Date },
                        new SqlParameter { ParameterName = "@ExDate", Value = e.ExperiDate },
                        new SqlParameter { ParameterName = "@Address", Value = e.Address },
                        new SqlParameter { ParameterName = "@Note", Value = e.Note },
                        new SqlParameter { ParameterName = "@Total", Value = e.Total },
                        new SqlParameter { ParameterName = "@CustomerID", Value = e.SupplierID }

                    );
                if (nRow > 0)
                    return 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }

        public DataTable ShowCurrency(int currencyID)
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT Rate FROM ExRate WHERE ID = " + currencyID;
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
