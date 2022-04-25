using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// collection of validation methods for string, dates  and numerics
    /// Kwangjin 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static class Validation
    {
        /// <summary>
        /// verify if a string contains a number ( and can be parsed int one)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNumeric(string value)
        {
            double output;
            return double.TryParse(value, out output);
        }

        /// <summary>
        /// return true if the object contains just a number
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNumeric(object value)
        {
            return IsNumeric(value.ToString());
        }

        /// <summary>
        /// returns true if the string contains just an integer
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsInteger(string value)
        {
            return IsNumeric(value) && !value.Contains(".");

        }
    }
}
