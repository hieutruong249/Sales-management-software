using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class HistoryBUS
    {
        public static HistoryDAO dao = new HistoryDAO();
        public DataTable ShowHistory()
        {
            return dao.ShowHistory();
        }
    }
}
