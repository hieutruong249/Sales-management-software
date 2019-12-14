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
    public class PermisionFormBUS
    {
        PermissionFormDAO dao = new PermissionFormDAO();
        public DataTable ShowUsers()
        {
            return dao.ShowUsers();
        }
        public DataTable ShowPermissionForm()
        {
            return dao.ShowPermissionForm();
        }
        public DataTable ShowPermissionForm(string username)
        {
            return dao.ShowPermissionForm(username);
        }
        public DataTable ShowRole(string name)
        {
            return dao.ShowRole(name);
        }
        public int UpdatePermission(string username, string formname, RoleForm rf)
        {
            return dao.UpdatePermission(username,formname,rf);
        }
    }
}
