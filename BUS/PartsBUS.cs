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
    public class PartsBUS : FatherBUS
    {
        PartsDAO partsDAO = new PartsDAO();
        public DataTable ShowParts()
        {
            return partsDAO.ShowParts();
        }
        public int InsertParts(Partss pr)
        {
            return partsDAO.InsertParts(pr);
        }
        public int UpdateParts(Partss pr)
        { 
            return partsDAO.UpdateParts(pr); 
        }
        public int DeleteParts(Partss pr)
        { 
            return partsDAO.DeleteParts(pr);
        }
    }
}
