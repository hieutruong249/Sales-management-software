using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI
{
    class CheckUserName : BaseValidator
    {

        public CheckUserName()
        {
            errorMessage = "UserName invalid!!!";
        }
        Regex re = new Regex("^[a-z][a-z0-9_-]");
        public override bool Validate()
        {
            return re.IsMatch(ControlToValidate.Text);
        }
    }
}
