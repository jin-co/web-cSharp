using System;
using System.Collections.Generic;
using System.Text;

namespace KwangjinBaek
{
    class Utility
    {
        // constructor
        Utility()
        {

        }

        public static string StringOperations(string input)
        {
            int found = input.IndexOf("#");
            int found2 = input.IndexOf("!");
            string result = input.Remove(found, found+1);
            string result2 = input.Remove(found2, found2+1);
            return result;
            return result2;
        }
    }
}
