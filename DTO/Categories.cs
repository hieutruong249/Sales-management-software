using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Categories
    {
        private string _categoryID;
        private string _categoryName;
        private string _note;

        public string CategoryID { get => _categoryID; set => _categoryID = value; }
        public string CategoryName { get => _categoryName; set => _categoryName = value; }
        public string Note { get => _note; set => _note = value; }
    }
}
