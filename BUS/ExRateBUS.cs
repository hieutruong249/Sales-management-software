using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ExRateBUS: FatherBUS
    {
        ExRateDAO exRateDAO = new ExRateDAO();
        public int InsertExRate(ExRates er)
        {
            return exRateDAO.InsertExRate(er);
        }
        public int UpdateExRate(ExRates er)
        {
            return exRateDAO.UpdateExRate(er);
        }
        public int DeleteExRate(ExRates er)
        {
            return exRateDAO.DeleteExRate(er);
        }
        public DataTable ShowExRate()
        {
            return exRateDAO.ShowExRate();
        }
    }
}
