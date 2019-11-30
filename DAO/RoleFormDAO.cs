using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class RoleFormDAO
    {
        Provider provider = new Provider();
        public List<RoleForm> GetListRole(int RoleID)
        {
            var rs = new List<RoleForm>();
            try
            {
                string strSQL = "select* from Role_Form where RoleID = @RoleID";
                provider.Connect();
                var dtbl = provider.Select(CommandType.Text, strSQL,
                        new SqlParameter { ParameterName = "@RoleID", Value = RoleID }
                    );
                foreach(DataRow row in dtbl.Rows)
                {
                    var roleForm = new RoleForm()
                    {
                        ID = int.Parse(row["ID"].ToString()),
                        RoleID = int.Parse(row["RoleID"].ToString()),
                        FormID = int.Parse(row["FormID"].ToString()),
                        Access = bool.Parse(row["Access"].ToString()),
                        f_Insert = bool.Parse(row["f_Insert"].ToString()),
                        f_Update = bool.Parse(row["f_Update"].ToString()),
                        f_Delete = bool.Parse(row["f_Delete"].ToString()),
                        Export = bool.Parse(row["Export"].ToString()),
                        Import = bool.Parse(row["Import"].ToString())

                    };
                    rs.Add(roleForm);
                }
                return rs;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                provider.DisConnect();
            }
        }
    }
}
