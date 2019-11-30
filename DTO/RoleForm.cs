using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleForm
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public int FormID { get; set; }
        public bool Access { get; set; }
        public bool f_Insert { get; set; }
        public bool f_Update { get; set; }
        public bool f_Delete { get; set; }
        public bool Export { get; set; }
        public bool Import { get; set; }

    }
}
