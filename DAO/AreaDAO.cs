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
    public class AreaDAO: FatherDAO
    {
        
        public int InsertArea(Areas area)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO Areas VALUES(@ID, @Name, @Note)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value =  area.ID},
                        new SqlParameter { ParameterName = "@Name", Value = area.Name },
                        new SqlParameter { ParameterName = "@Note", Value = area.Note }

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

        public DataTable ShowArea()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT* FROM Areas";
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

        public int UpdateArea(Areas area)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "UPDATE Areas SET Name = @Name, Note = @Note WHERE ID = @ID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value = area.ID },
                        new SqlParameter { ParameterName = "@Name", Value = area.Name },
                        new SqlParameter { ParameterName = "@Note", Value = area.Note }

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
        public int DeleteArea(Areas area)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "DELETE FROM Areas WHERE ID = @ID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value = area.ID }
                        
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
