using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI
{
    public class CheckEmail : BaseValidator
    {
        public CheckEmail()
        {
            errorMessage = "Email invalid!!!";
        }
        Regex re = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public override bool Validate()
        {
            return re.IsMatch(ControlToValidate.Text);
        }
    }
}