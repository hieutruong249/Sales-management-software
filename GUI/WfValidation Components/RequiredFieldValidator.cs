using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class RequiredFieldValidator: BaseValidator
    {
        public RequiredFieldValidator()
        {
            errorMessage = "need input!!!";
        }
        public override bool Validate()
        {
            return ControlToValidate.Text.Length > 0;
        }
    }
}
