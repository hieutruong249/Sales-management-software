using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

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
    }
}
