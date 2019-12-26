using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class ReportBUS
    {
        public static ReportDAO dao = new ReportDAO();
        public DataTable ShowReport()
        {
            return dao.ShowReport();
        }
        public DataTable ShowReport(string warehouseID)
        {
            return dao.ShowReport(warehouseID);
        }
    }
}
