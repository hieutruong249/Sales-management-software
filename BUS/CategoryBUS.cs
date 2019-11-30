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
    public class CategoryBUS: FatherBUS
    {
        CategoryDAO cgD = new CategoryDAO();
        public int InserCategory(Categories cg)
        {
            return cgD.InserCategory(cg);
        }
        public int UpdateCategory(Categories cg)
        {
            return cgD.UpdateCategory(cg);
        }
        public int DeleteCategory(Categories cg)
        {
            return cgD.DeleteCategory(cg);
        }
        public DataTable ShowCatergories()
        {
            return cgD.ShowCatergories();
        }
    }
}
