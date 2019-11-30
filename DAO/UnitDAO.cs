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
    public class UnitDAO
    {
        public int InsertUnit(Units u)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO Unit VALUES(@ID, @Name, @Note)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value = u.ID },
                        new SqlParameter { ParameterName = "@Name", Value = u.Name },
                        new SqlParameter { ParameterName = "@Note", Value = u.Note }

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

        public int UpdateUnit(Units u)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "UPDATE Unit SET NAME = @Name, NOTE = @Note WHERE ID = @ID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value = u.ID },
                        new SqlParameter { ParameterName = "@Name", Value = u.Name },
                        new SqlParameter { ParameterName = "@Note", Value = u.Note }

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

        public int DeleteUnit(Units u)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "DELETE FROM Unit WHERE ID = @ID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value = u.ID }

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

        public DataTable ShowUnit()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT* FROM Unit";
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
