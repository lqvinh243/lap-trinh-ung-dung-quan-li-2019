using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Validatior
{
    public class RequiredInputValidator : BaseValidator
    {
        public RequiredInputValidator()
        {
            this.ErrMess = "Các ô không được để trống!";
        }
        public override bool Validate()
        {
            return this.Controltovalidate.Text.Length > 0;
        }
    }
}
