using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WfValidation_Components
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
