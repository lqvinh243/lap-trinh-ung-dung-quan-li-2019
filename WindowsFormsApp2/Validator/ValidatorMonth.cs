using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Validatior
{
    public class ValidatorMonth : BaseValidator
    {
        public ValidatorMonth()
        {
            this.ErrMess = "Tháng nhập vào không hợp lệ!";
        }
        public override bool Validate()
        {
            return Int32.Parse(this.Controltovalidate.Text) > 12 && Int32.Parse(this.Controltovalidate.Text) < 0;
        }
    }
}
