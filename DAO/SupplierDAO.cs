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
    public class SupplierDAO
    {
        Provider dc;
        public int InsertSupplier(Suppliers spl)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO Suppliers VALUES(@SupplierID, @SupplierName, @Address, @Phone, @Area, @AccountBank, @Email, @Bank, @Discount)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@SupplierID", Value = spl.SupplierID },
                        new SqlParameter { ParameterName = "@SupplierName", Value = spl.SupplierName },
                        new SqlParameter { ParameterName = "@Address", Value = spl.Address },
                        new SqlParameter { ParameterName = "@Phone", Value = spl.Phone },
                        new SqlParameter { ParameterName = "@Area", Value = spl.Area },
                        new SqlParameter { ParameterName = "@AccountBank", Value = spl.AccountBank },
                        new SqlParameter { ParameterName = "@Email", Value = spl.Email },
                        new SqlParameter { ParameterName = "@Bank", Value = spl.Bank },
                        new SqlParameter { ParameterName = "@Discount", Value = spl.Discount }

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
    

        public int UpdateSupplier(Suppliers spl)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "UPDATE Suppliers SET SupplierName = @SupplierName, Address = @Address, Phone = @Phone, Area = @Area, AccountBank = @AccountBank, Email = @Email, Bank = @Bank, Discount = @Discount WHERE SupplierID = @SupplierID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@SupplierID", Value = spl.SupplierID },
                        new SqlParameter { ParameterName = "@SupplierName", Value = spl.SupplierName },
                        new SqlParameter { ParameterName = "@Address", Value = spl.Address },
                        new SqlParameter { ParameterName = "@Phone", Value = spl.Phone },
                        new SqlParameter { ParameterName = "@Area", Value = spl.Area },
                        new SqlParameter { ParameterName = "@AccountBank", Value = spl.AccountBank },
                        new SqlParameter { ParameterName = "@Email", Value = spl.Email },
                        new SqlParameter { ParameterName = "@Bank", Value = spl.Bank },
                        new SqlParameter { ParameterName = "@Discount", Value = spl.Discount }

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

        public int DeleteSupplier(Suppliers spl)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "DELETE Suppliers WHERE  SupplierID = @SupplierID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,
                        new SqlParameter { ParameterName = "@SupplierID,", Value = spl.SupplierID }
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

        public DataTable ShowSupplier()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT* FROM Suppliers";
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



