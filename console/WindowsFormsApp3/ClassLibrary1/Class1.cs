using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Class1
    {
        public int MyProperty { get; set; }
        private int v;

        Class1() 
        {
            
        }

        public static bool IsNumeric(string a)
        {
            Regex pattern = new Regex(@"^-?\d+\.\d*?$");
            return pattern.IsMatch(a);
        }
    }
}
