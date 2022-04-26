using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ValidationUtilities
    {
        public static bool EmailValidation(string email)
        {
            try
            {

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
