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
    public class StaffDAO
    {
        public DataTable ShowStaffs()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT* FROM Staffs";
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

        public int InsertStaff(Staffs sf)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO Staffs VALUES(@ID, @Name, @Position, @Address, @Email, @Phone, @Parts, @Manager)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value = sf.ID },
                        new SqlParameter { ParameterName = "@Name", Value = sf.Name },
                        new SqlParameter { ParameterName = "@Position", Value = sf.Position },
                        new SqlParameter { ParameterName = "@Address", Value = sf.Address },
                        new SqlParameter { ParameterName = "@Email", Value = sf.Email },
                        new SqlParameter { ParameterName = "@Phone", Value = sf.Phone },
                        new SqlParameter { ParameterName = "@Parts", Value = sf.Parts },
                        new SqlParameter { ParameterName = "@Manager", Value = sf.Manager }

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
        public int UpdateStaff(Staffs sf)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "Update Staffs set Name = @Name, Position = @Position, Address = @Address, Email = @Email, Phone = @Phone, Parts = @Parts, Manager = @Manager where ID = @ID Staffs";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value = sf.ID },
                        new SqlParameter { ParameterName = "@Name", Value = sf.Name },
                        new SqlParameter { ParameterName = "@Position", Value = sf.Position },
                        new SqlParameter { ParameterName = "@Address", Value = sf.Address },
                        new SqlParameter { ParameterName = "@Email", Value = sf.Email },
                        new SqlParameter { ParameterName = "@Phone", Value = sf.Phone },
                        new SqlParameter { ParameterName = "@Parts", Value = sf.Parts },
                        new SqlParameter { ParameterName = "@Manager", Value = sf.Manager }

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

        public int DeleteStaff(Staffs sf)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "DELETE Staffs where ID = @ID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,
                        new SqlParameter { ParameterName = "@ID", Value = sf.ID }
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
