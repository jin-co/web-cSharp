using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermKB
{
    public class Program
    {        
        static void Main(string[] args)
        {

            ShowMenu();            
        }

        private static void ShowMenu()
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("=========== Menu ===========\n" +
                "1. Enter three numbers which represent day, " +
                "month and year of a calendar date\n" +
                "2. Exit");

                if (ValidateValue() > 2)
                {
                    Console.WriteLine("Out of range. Please enter 1 or 2");
                }
                else
                {
                    if (ValidateValue() == 2)
                    {
                        Console.WriteLine("Goodbye... ");
                        flag = false;
                    }
                }
            }
        }

        private static int ValidateValue()
        {
            int input = 0;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid Value");
                }
                else
                {
                    return input;
                }
            }            
        }
    }
}
