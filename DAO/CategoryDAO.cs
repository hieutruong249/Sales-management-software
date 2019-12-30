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
    public class CategoryDAO
    {
        Provider dc;
        public int InserCategory(Categories cg)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO Catergories VALUES(@CategoryID, @CategoryName, @Note)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@CategoryID", Value = cg.CategoryID },
                        new SqlParameter { ParameterName = "@CategoryName", Value = cg.CategoryName },
                        new SqlParameter { ParameterName = "@Note", Value = cg.Note }

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
        public int UpdateCategory(Categories cg)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "Update Catergories set CatName = @CategoryName, Note = @Note where CatID = @CategoryID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,
                        new SqlParameter { ParameterName = "@CategoryID", Value = cg.CategoryID },
                        new SqlParameter { ParameterName = "@CategoryName", Value = cg.CategoryName },
                        new SqlParameter { ParameterName = "@Note", Value = cg.Note }
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

        public int DeleteCategory(Categories cg)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "DELETE Catergories where CatID = @CategoryID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,
                        new SqlParameter { ParameterName = "@CategoryID", Value = cg.CategoryID }
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

        public DataTable ShowCatergories()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT* FROM Catergories";
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

        public DataTable ShowCatergories(string categoryID)
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT* FROM Catergories WHERE CatID = '" + categoryID + "'";
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
