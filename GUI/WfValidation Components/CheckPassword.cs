using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI
{
    class CheckPassword : BaseValidator
    {
        public CheckPassword()
        {
            errorMessage = "Password invalid!!!";
        }
        Regex re = new Regex("[a-z0-9]");
        public override bool Validate()
        {
            return (re.IsMatch(ControlToValidate.Text) && ControlToValidate.Text.Length >= 3);
        }
    }
}
