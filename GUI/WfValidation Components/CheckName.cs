using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI
{
     public class CheckName : BaseValidator
    {
        public CheckName()
        {
            errorMessage = "Name invalid!!!";
        }
        Regex re = new Regex("^[a-zA-Z]");
        public override bool Validate()
        {
            return re.IsMatch(ControlToValidate.Text);
        }
    }
}
