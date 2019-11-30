using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class StaffBUS: FatherBUS
    {
        StaffDAO staffDAO = new StaffDAO();
        public DataTable ShowStaffs()
        {
            return staffDAO.ShowStaffs();
        }
        public int InsertStaff(Staffs sf)
        {
            return staffDAO.InsertStaff(sf);
        }
        public int UpdateStaff(Staffs sf)
        {
            return staffDAO.UpdateStaff(sf);
        }
        public int DeleteStaff(Staffs sf)
        {
            return staffDAO.DeleteStaff(sf);
        }
    }
}
