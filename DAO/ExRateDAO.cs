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
    public class ExRateDAO
    {
        public DataTable ShowExRate()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT* FROM ExRate";
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
        public int InsertExRate(ExRates er)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO ExRate VALUES(@Name, @Rate)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        //new SqlParameter { ParameterName = "@ID", Value = er.ID },
                        new SqlParameter { ParameterName = "@Name", Value = er.Name },
                        new SqlParameter { ParameterName = "@Rate", Value = er.Rate }

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

        public int UpdateExRate(ExRates er)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "Update ExRate set Name = @Name, Rate = @Rate where ID = @ID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value = er.ID },
                        new SqlParameter { ParameterName = "@Name", Value = er.Name },
                        new SqlParameter { ParameterName = "@Rate", Value = er.Rate }

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

        public int DeleteExRate(ExRates er)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "DELETE ExRate where ID = @ID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,
                        new SqlParameter { ParameterName = "@ID", Value = er.ID }
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
    }
}
