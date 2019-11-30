using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class UnitBUS
    {
        UnitDAO unitDAO = new UnitDAO();
        public int InsertUnit(Units u)
        {
            return unitDAO.InsertUnit(u);
        }
        public int UpdateUnit(Units u)
        {
            return unitDAO.UpdateUnit(u);
        }
        public int DeleteUnit(Units u)
        {
            return unitDAO.DeleteUnit(u);
        }
        public DataTable ShowUnit()
        {
            return unitDAO.ShowUnit();
        }
    }
}
