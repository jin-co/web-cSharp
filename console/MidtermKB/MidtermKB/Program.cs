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
                choice = ValidateValue(1, 2, "Menu");
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
            int month = 0, day = 0, year = 0;
            while (flag)
            {
                Console.WriteLine("\nEnter Month(1 ~ 12): ");
                month = ValidateValue(1, 12, "Month");
                if (month != 0)
                {
                    flag = false;
                }
            }
            while (!flag)
            {
                Console.WriteLine("Enter Day(1 ~ 31): ");
                day = ValidateValue(1, 31, "Day");
                if (day != 0)
                {
                    flag = true;
                }
            }

            while (flag)
            {
                Console.WriteLine("Enter Year(1812 ~ 2022): ");
                year = ValidateValue(1812, 2022, "Year");
                if (year != 0)
                {
                    flag = false;
                }
            }

            // If the numbers do form a valid date, the program returns the string
            Console.WriteLine("\nSystem date is updated");
            Console.WriteLine(DateSolver.Analyze(month, day, year));
        }

        private static int ValidateValue(int min, int max, string target)
        {
            int input = 0;
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("\nInvalid Value\n");
                return input;
            }
            else
            {
                if (input > max || input < min)
                {
                    Console.WriteLine("\n" + target + ": value out of range\n");
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
