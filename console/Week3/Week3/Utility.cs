using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Week3
{
    class Utility
    {
        public Boolean IsNumeric(string value)
        {
            if (string.IsNullOrEmpty(value)) return false;
            Regex pattern = new Regex(@"^-?\d+\.?\d*$");
            return pattern.IsMatch(value);
        }

        public Boolean IsInteger(string value)
        {
            return IsNumeric(value) && !value.Contains(".");
        }
        
        public Boolean IsInteger(double value)
        {
            return !value.ToString().Contains(".");
        }
    }
}
