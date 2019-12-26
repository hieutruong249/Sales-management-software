using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DAO
{
    public class FatherDAO
    {
        public DataTable ImportFormExcel(string sheetname, string path)
        {
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;';";
            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + sheetname + "$]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            return data;
        }

        public int RecordHistory(string userName, string pc, string time, string business, string action, string obj)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO History VALUES(@userName, @pc, @time, @business, @action, @object)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@userName", Value = userName },
                        new SqlParameter { ParameterName = "@pc", Value = pc },
                        new SqlParameter { ParameterName = "@time", Value = time },
                        new SqlParameter { ParameterName = "@business", Value = business },
                        new SqlParameter { ParameterName = "@action", Value = action },
                        new SqlParameter { ParameterName = "@object", Value = obj }

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
