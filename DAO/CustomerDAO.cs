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
    public class CustomerDAO
    {
        Provider dc;
        public int InsertCustomer(Customers ctm)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO Customer VALUES(@CustomerID, @CustomerName, @Address, @Phone, @Area, @AccountBank, @Email, @Bank, @Discount)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@CustomerID", Value = ctm.CustomerID },
                        new SqlParameter { ParameterName = "@CustomerName", Value = ctm.CustomerName },
                        new SqlParameter { ParameterName = "@Address", Value = ctm.Address },
                        new SqlParameter { ParameterName = "@Phone", Value = ctm.Phone },
                        new SqlParameter { ParameterName = "@Area", Value = ctm.Area },
                        new SqlParameter { ParameterName = "@AccountBank", Value = ctm.AccountBank },
                        new SqlParameter { ParameterName = "@Email", Value = ctm.Email },
                        new SqlParameter { ParameterName = "@Bank", Value = ctm.Bank },
                        new SqlParameter { ParameterName = "@Discount", Value = ctm.Discount }

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

        public int UpdateCustomer(Customers ctm)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "Update Customer set CustomerName = @CustomerName, Address = @Address, Phone = @Phone, Area = @Area, AccountBank = @AccountBank, Email = @Email, Bank = @Bank, Discount = @Discount WHERE CustomerID = @CustomerID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@CustomerID", Value = ctm.CustomerID },
                        new SqlParameter { ParameterName = "@CustomerName", Value = ctm.CustomerName },
                        new SqlParameter { ParameterName = "@Address", Value = ctm.Address },
                        new SqlParameter { ParameterName = "@Phone", Value = ctm.Phone },
                        new SqlParameter { ParameterName = "@Area", Value = ctm.Area },
                        new SqlParameter { ParameterName = "@AccountBank", Value = ctm.AccountBank },
                        new SqlParameter { ParameterName = "@Email", Value = ctm.Email },
                        new SqlParameter { ParameterName = "@Bank", Value = ctm.Bank },
                        new SqlParameter { ParameterName = "@Discount", Value = ctm.Discount }

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

        public int DeleteCustomer(string CustomerID)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "DELETE Customer where CustomerID = '" + CustomerID + "'";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,
                        new SqlParameter { ParameterName = "@CustomerID", Value = CustomerID }
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

        public DataTable ShowCustomer()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT* FROM Customer";
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

        public DataTable ShowCustomer(string customerID)
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT* FROM Customer WHERE CustomerID = '" + customerID + "'";
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
