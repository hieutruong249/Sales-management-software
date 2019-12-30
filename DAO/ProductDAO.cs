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
    public class ProductDAO
    {
        public int InsertProduct(Products u)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "INSERT INTO Products VALUES(@ProductID, @ProductName, @CatergoryID, @WarehouseID, @UnitID, @Origin, @MinInventory, @CurrInventory, @Supplier, @Purchase, @Retail, @Wholesale, @Image)";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ProductID", Value = u.ProductID },
                        new SqlParameter { ParameterName = "@ProductName", Value = u.ProductName },
                        new SqlParameter { ParameterName = "@CatergoryID", Value = u.CatergoryID },
                        new SqlParameter { ParameterName = "@WarehouseID", Value = u.WarehouseID },
                        new SqlParameter { ParameterName = "@UnitID", Value = u.UnitID },
                        new SqlParameter { ParameterName = "@Origin", Value = u.Origin },
                        new SqlParameter { ParameterName = "@MinInventory", Value = u.MinInventory },
                        new SqlParameter { ParameterName = "@CurrInventory", Value = u.CurrInventory },
                        new SqlParameter { ParameterName = "@Supplier", Value = u.Supplier },
                        new SqlParameter { ParameterName = "@Purchase", Value = u.Purchase },
                        new SqlParameter { ParameterName = "@Retail", Value = u.Retail },
                        new SqlParameter { ParameterName = "@Wholesale", Value = u.Wholesale },
                        new SqlParameter { ParameterName = "@Image", Value = u.Image }

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

        public int UpdateProduct(Products u)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "UPDATE Products SET ProductName = @ProductName, " +
                    "CatergoryID = @CatergoryID, WarehouseID = @WarehouseID, " +
                    "UnitID = @UnitID, Origin = @Origin, " +
                    "MinInventory = @MinInventory, CurrInventory = @CurrInventory, " +
                    "Supplier = @Supplier, Purchase = @Purchase, Retail = @Retail, " +
                    "Wholesale = @Wholesale, Image = @Image WHERE ProductID = @ProductID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ProductID", Value = u.ProductID },
                        new SqlParameter { ParameterName = "@ProductName", Value = u.ProductName },
                        new SqlParameter { ParameterName = "@CatergoryID", Value = u.CatergoryID },
                        new SqlParameter { ParameterName = "@WarehouseID", Value = u.WarehouseID },
                        new SqlParameter { ParameterName = "@UnitID", Value = u.UnitID },
                        new SqlParameter { ParameterName = "@Origin", Value = u.Origin },
                        new SqlParameter { ParameterName = "@MinInventory", Value = u.MinInventory },
                        new SqlParameter { ParameterName = "@CurrInventory", Value = u.CurrInventory },
                        new SqlParameter { ParameterName = "@Supplier", Value = u.Supplier },
                        new SqlParameter { ParameterName = "@Purchase", Value = u.Purchase },
                        new SqlParameter { ParameterName = "@Retail", Value = u.Retail },
                        new SqlParameter { ParameterName = "@Wholesale", Value = u.Wholesale },
                        new SqlParameter { ParameterName = "@Image", Value = u.Image }

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

        public int DeleteProduct(Products u)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "DELETE FROM Products WHERE ProductID = @ProductID";
                provider.Connect();
                nRow = provider.ExeCuteNonQuery(CommandType.Text, strSQL,

                        new SqlParameter { ParameterName = "@ProductID", Value = u.ProductID }

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

        public DataTable ShowProducts()
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT* FROM Products";
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

        public DataTable ShowProducts(string productID)
        {
            Provider provider = new Provider();
            try
            {
                string strSQL = "SELECT* FROM Products WHERE ProductID = '" + productID + "'";
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
