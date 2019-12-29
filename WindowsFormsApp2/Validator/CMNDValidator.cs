using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WindowsFormsApp2.Validatior;

namespace WindowsFormsApp2.Validator
{
    class CMNDValidator : BaseValidator
    {
        public CMNDValidator()
        {
            this.ErrMess = "CMND không đúng định dạng(đủ 9 kí tự và chỉ số)!";
        }
        public override bool Validate()
        {
            var rg = new Regex(RegexString.CMND);
            return rg.IsMatch(this.Controltovalidate.Text);
        }
    }
}
