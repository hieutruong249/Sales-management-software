using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UserDAO
    {
       
        public int InsertUser(User us)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO Users VALUES(@Username, @Password, @Name, @Email, @DoB, @Pems)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@Username", Value = us.Username },
                        new SqlParameter { ParameterName = "@Password", Value = us.Password },
                        new SqlParameter { ParameterName = "@Name", Value = us.Name },
                        new SqlParameter { ParameterName = "@Email", Value = us.Email },
                        new SqlParameter { ParameterName = "@DoB", Value = us.DoB },
                        new SqlParameter { ParameterName = "@Pems", Value = 4 }
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
        public int IsLoginSuccess(User us)
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "sp_IsLoginSuccess";
                provider.Connect();
                SqlParameter p = new SqlParameter("@rs", SqlDbType.Int);
                p.Direction = ParameterDirection.ReturnValue;
                provider.ExeCuteNonQuery(CommandType.StoredProcedure, strSQL,
                        new SqlParameter { ParameterName = "@Username", Value = us.Username },
                        new SqlParameter { ParameterName = "@Password", Value = us.Password }, p

                    );
                return (int)p.Value;
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

        public UserInfo UsrRolFrm(User us)
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "select ID, f_Permission from Users  where f_username = @Username and f_password = @Password";
                provider.Connect();
                var dtbl = provider.Select(CommandType.Text,strSQL,
                        new SqlParameter { ParameterName = "@Username", Value = us.Username },
                        new SqlParameter { ParameterName = "@Password", Value = us.Password }
                    );

                if(dtbl!=null && dtbl.Rows.Count > 0)
                {
                    return new UserInfo() { ID = int.Parse(dtbl.Rows[0]["ID"].ToString()),
                                            RoleId = int.Parse(dtbl.Rows[0]["f_Permission"].ToString())
                    };
                }
                else
                {
                    return null;
                }
                    

            }
            catch(SqlException e)
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
