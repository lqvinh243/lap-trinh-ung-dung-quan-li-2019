using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Validatior
{
    public class PasswordValidator : BaseValidator
    {
        public string Pass;
        public PasswordValidator()
        {
            this.ErrMess = "Mật khẩu nhập lại không trùng nhau!";
        }
        public override bool Validate()
        {
            return this.Controltovalidate.Text == Pass;
        }
    }
}
