using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class PermissionFormDAO
    {
        public DataTable ShowPermissionForm()
        {
            Provider provider = new Provider();
            string username = GlobalVar._username;
            try
            {
                string strSQL = "SELECT f.Description, rf.Access, rf.f_Insert, rf.f_Update, rf.f_Delete, rf.Import, rf.Export " +
                    "FROM Role_Form rf join Form f ON rf.FormID=f.ID join Users u ON rf.RoleID=u.f_Permission " +
                    "WHERE u.f_username = @username";
                provider.Connect();
                DataTable dtbl = new DataTable();
                dtbl = provider.Select(CommandType.Text, strSQL,
                    new SqlParameter { ParameterName = "@username", Value = username }
                    );
                return dtbl;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }

        }
        public DataTable ShowPermissionForm(string username)
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT f.Description, rf.Access, rf.f_Insert, rf.f_Update, rf.f_Delete, rf.Import, rf.Export " +
                    "FROM Role_Form rf join Form f ON rf.FormID=f.ID join Users u ON rf.RoleID=u.f_Permission " +
                    "WHERE u.f_username = @username";
                provider.Connect();
                DataTable dtbl = new DataTable();
                dtbl = provider.Select(CommandType.Text, strSQL,
                    new SqlParameter { ParameterName = "@username", Value = username }
                    );
                return dtbl;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }

        }
        public DataTable ShowUsers()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT f_username FROM Users";
                provider.Connect();
                DataTable dtbl = new DataTable();
                dtbl = provider.Select(CommandType.Text, strSQL);
                    
                return dtbl;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }

        }

        public DataTable ShowRole(string name)
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT r.Name FROM Role r JOIN Users U ON u.f_Permission=r.ID WHERE u.f_username = @name";
                provider.Connect();
                DataTable dtbl = new DataTable();
                dtbl = provider.Select(CommandType.Text, strSQL,
                    new SqlParameter { ParameterName = "@name", Value = name }
                    );

                return dtbl;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }

        }
        public int UpdatePermission(string username, string formname, RoleForm rf)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "UPDATE Role_Form SET Access = @access, f_Insert = @insert, f_Update = @update, f_Delete = @delete, Import = @import, Export = @export " +
                    "WHERE exists (SELECT RoleID FROM Users u  WHERE u.f_username = @username and u.f_Permission = RoleID) " +
                    "and exists (SELECT FormID FROM Form f WHERE f.Description = @formname AND f.ID = FormID)";

                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@username", Value = username },
                        new SqlParameter { ParameterName = "@formname", Value = formname },
                        new SqlParameter { ParameterName = "@access", Value = rf.Access },
                        new SqlParameter { ParameterName = "@insert", Value = rf.f_Insert },
                        new SqlParameter { ParameterName = "@update", Value = rf.f_Update },
                        new SqlParameter { ParameterName = "@delete", Value = rf.f_Delete },
                        new SqlParameter { ParameterName = "@import", Value = rf.Import },
                        new SqlParameter { ParameterName = "@export", Value = rf.Export }
                    );
                if (nRow > 0)
                    return 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return nRow;
        }
    }
}
