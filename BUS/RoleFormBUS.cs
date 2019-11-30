using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class RoleFormBUS
    {
        RoleFormDAO roleFormDAO = new RoleFormDAO();
        public List<RoleForm> GetListRole(int RoleID)
        {
            return roleFormDAO.GetListRole(RoleID);
        }

    }
}
