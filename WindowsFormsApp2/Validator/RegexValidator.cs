using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Validatior
{
    class RegexValidator : BaseValidator
    {
        public int FlagRegex { get; set; }
        public override bool Validate()
        {
            if(FlagRegex == 1) {
                var rg = new Regex(RegexString.CMND);
                this.ErrMess = "CMND sai định dạng!";
                return rg.IsMatch(this.Controltovalidate.Text);
            }
            return false;
        }
    }
}
