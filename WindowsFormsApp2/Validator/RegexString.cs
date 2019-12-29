using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Validatior
{
    public class RegexString
    {
        public static string Khoi = @"^([1-9]|1[012])$";
        public static string Lop = @"^[1-9]$";
        public static string Number = @"^[0-9]+$";
        public static string Tinh = @"^[0-1]$";
        public static string Dokho = @"^[1-4]$";
        public static string CMND = @"^[0-9]{9}$";
    }
}
