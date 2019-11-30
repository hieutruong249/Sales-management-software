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
    public class AreasBUS: FatherBUS
    {
        AreaDAO areaDAO = new AreaDAO();
        public int InsertArea(Areas area)
        {
            return areaDAO.InsertArea(area);
        }
        public int UpdateArea(Areas area)
        {
            return areaDAO.UpdateArea(area);
        }
        public int DeleteArea(Areas area)
        {
            return areaDAO.DeleteArea(area);
        }
        public DataTable ShowArea()
        {
            return areaDAO.ShowArea();
        }

    }
}
