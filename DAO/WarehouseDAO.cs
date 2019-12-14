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
    public class WarehouseDAO
    {
        public int InsertWarehoue(Warehouses wh)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO Warehouse VALUES(@ID, @Name, @Manager, @Contact, @Address, @Phone, @Email, @Decription)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value = wh.ID },
                        new SqlParameter { ParameterName = "@Name", Value = wh.Name },
                        new SqlParameter { ParameterName = "@Manager", Value = wh.Manager },
                        new SqlParameter { ParameterName = "@Contact", Value = wh.Contact },
                        new SqlParameter { ParameterName = "@Address", Value = wh.Address },
                        new SqlParameter { ParameterName = "@Phone", Value = wh.Phone },
                        new SqlParameter { ParameterName = "@Email", Value = wh.Email },
                        new SqlParameter { ParameterName = "@Decription", Value = wh.Decription }

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

        public int UpdateWarehoue(Warehouses wh)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "UPDATE Warehouse SET Name = @Name, Manager = @Manager, Contact = @Contact, Address = @Address, Phone = @Phone, Email = @Email, Decription = @Decription WHERE ID = @ID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value = wh.ID },
                        new SqlParameter { ParameterName = "@Name", Value = wh.Name },
                        new SqlParameter { ParameterName = "@Manager", Value = wh.Manager },
                        new SqlParameter { ParameterName = "@Contact", Value = wh.Contact },
                        new SqlParameter { ParameterName = "@Address", Value = wh.Address },
                        new SqlParameter { ParameterName = "@Phone", Value = wh.Phone },
                        new SqlParameter { ParameterName = "@Email", Value = wh.Email },
                        new SqlParameter { ParameterName = "@Decription", Value = wh.Decription }

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

        public int DeleteWarehoue(Warehouses wh)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "DELETE FROM Warehouse WHERE ID = @ID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ID", Value = wh.ID }

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

        public DataTable ShowWarehouses()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT* FROM Warehouse";
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
    }
}
