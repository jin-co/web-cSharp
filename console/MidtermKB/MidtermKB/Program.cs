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
            int choice;
            while(flag)
            {
                Console.WriteLine("\n=========== Menu ===========\n" +
                "1. Enter three numbers which represent day, " +
                "month and year of a calendar date\n" +
                "2. Exit\n");
                choice = ValidateValue(1, 2);
                switch (choice)
                {
                    case 1:
                        RunApplication();
                        break;
                    case 2:
                        Console.WriteLine("Goodbye... ");
                        flag = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private static void RunApplication()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter Month(1 ~ 12): ");
                int month = ValidateValue(1, 12);
                if (month != 0)
                {
                    flag = false;
                }
            }
            while (!flag)
            {
                Console.WriteLine("Enter Day(1 ~ 31): ");
                int day = ValidateValue(1, 31);
                if (day != 0)
                {
                    flag = true;
                }
            }

            while (flag)
            {
                Console.WriteLine("Enter Year(1812 ~ 2022): ");
                int year = ValidateValue(1812, 2022);
                if (year != 0)
                {
                    flag = false;
                }
            }
        }

        private static int ValidateValue(int min, int max)
        {
            int input = 0;
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("\nInvalid Value");
                return input;
            }
            else
            {
                if (input > max || input < min)
                {
                    Console.WriteLine("\nInput Value Out of Range");
                    return 0;
                }
                else
                {
                    return input;
                }
            }
        }
    }
}
