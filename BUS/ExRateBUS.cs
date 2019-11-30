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
    public class ExRateBUS
    {
        ExRateDAO exRateDAO = new ExRateDAO();
        public int InserCategory(ExRates er)
        {
            return exRateDAO.InsertExRate(er);
        }
        public int UpdateCategory(ExRates er)
        {
            return exRateDAO.UpdateExRate(er);
        }
        public int DeleteCategory(ExRates er)
        {
            return exRateDAO.DeleteExRate(er);
        }
        public DataTable ShowExRate()
        {
            return exRateDAO.ShowExRate();
        }
    }
}
