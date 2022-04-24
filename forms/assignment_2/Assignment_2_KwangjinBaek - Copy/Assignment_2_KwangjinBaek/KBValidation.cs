using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_2_KwangjinBaek
{
    class KBValidation
    {
        // returns a capitalized word given the input is a letter
        public static string KBCapitalize(string input)
        {

            if (String.IsNullOrEmpty(input))
            {
                return "";
            }
            
            string[] words = input.ToLower().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
              
            foreach (var word in words)
            {
                result += word.Substring(0, 1).ToUpper();
                result += word.Substring(1) + " ";
            }
            return result;
        }

        /* If the incoming string is null or an empty string, pass it (so method can be */

        // check the number of numbers and letters
        // return true if the string is 9 characters long (5 numbers, 4 upper-case letters)
        public static bool KBMemberCodeValidation (string input)
        {
            char[] characters = input.ToCharArray();
            int countNumber = 0, countLetter = 0;
            foreach (var character in characters)
            {
                if (Char.IsDigit(character))
                {
                    countNumber++;
                }
                if (Char.IsUpper(character))
                {
                    countLetter++;
                }
            }
            if (countNumber == 5 && countLetter == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /* this takes a string and returns a Boolean.  If the incoming string is null or empty, 
         * pass it.  */

        // check number pattern
        // return true if the input is in the right format (“123 123 1234” or “123.123.1234”)
        public static bool KBPhoneNumberValidation(string input)
        {
            Regex phonePattern1 = new Regex(@"^\d{3} \d{3} \d{4}$");
            Regex phonePattern2 = new Regex(@"^\d{3}\.\d{3}\.\d{4}$");
            if (phonePattern1.IsMatch(input) || phonePattern2.IsMatch(input))
            {
                return true;
            }
            return false;
        }

        public static bool KBUKPostalValidation(ref string input)
        {
            Regex UKPostalPattern = new Regex(@"[a-zA-Z][a-zA-Z]?\d[a-zA-Z0-9]? ?\d[a-zA-Z][a-zA-Z]");
            char[] characters = input.ToCharArray();
            string result = "";
            if (UKPostalPattern.IsMatch(input))
            {
                foreach (var character in characters)
                {
                    if (!Char.IsWhiteSpace(character))
                    {
                        result += character.ToString().ToUpper();
                    }
                }
                input = result.Insert(result.Length - 3, " ");

                return true;
            }
            return false;
        }
    }
}
