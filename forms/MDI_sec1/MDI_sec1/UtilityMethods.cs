using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MDI_sec1
{
    public class UtilityMethods
    {
        public static Boolean IsNumeric(string value)
        {
            Regex pattern = new Regex(@"^-?\d+\.\d*?$");
            return pattern.IsMatch(value);
        }

        public static Boolean IsInteger(string value)
        {
            return IsNumeric(value) && !value.Contains(".");
        }

    }
}
