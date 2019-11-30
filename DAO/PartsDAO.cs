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
    public class PartsDAO
    {
        public DataTable ShowParts()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT* FROM Parts";
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
        public int InsertParts(Partss pr)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO Parts VALUES(@ID, @Name, @Note)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value = pr.ID },
                        new SqlParameter { ParameterName = "@Name", Value = pr.Name },
                        new SqlParameter { ParameterName = "@Note", Value = pr.Note }

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

        public int UpdateParts(Partss pr)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "Update Parts set Name = @Name, Note = @Note where ID = @ID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value = pr.ID },
                        new SqlParameter { ParameterName = "@Name", Value = pr.Name },
                        new SqlParameter { ParameterName = "@Note", Value = pr.Note }

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

        public int DeleteParts(Partss pr)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "DELETE Parts where ID = @ID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,
                        new SqlParameter { ParameterName = "@ID", Value = pr.ID }
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
