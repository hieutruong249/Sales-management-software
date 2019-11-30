using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public abstract class FatherBUS
    {
        FatherDAO fatherDAO = new FatherDAO();
        public DataTable ImportFormExcel(string sheetname, string path)
        {
            return fatherDAO.ImportFormExcel(sheetname,path);
        }
    }
}
