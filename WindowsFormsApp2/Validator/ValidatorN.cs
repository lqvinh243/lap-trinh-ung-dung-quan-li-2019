using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Validatior
{
    public class ValidatorN : BaseValidator
    {
        public int i { get; set; }
        public ValidatorN()
        {
            this.ErrMess = "Dữ liệu không hợp lệ!";
        }
        public override bool Validate()
        {
            if (i == 1)
            {
                var K = new Regex(RegexString.Khoi);
                return K.IsMatch(this.Controltovalidate.Text);
            }
            var L = new Regex(RegexString.Lop);
            return L.IsMatch(this.Controltovalidate.Text);
        }
    }
}
