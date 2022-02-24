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
            int month = 0, day = 0, year = 0;
                        
            month = ValidateValue("\nEnter Month(1 ~ 12): ");                                        
            day = ValidateValue("Enter Day(1 ~ 31): ");                                      
            year = ValidateValue("Enter Year(1812 ~ 2022): ");                
                       
            Console.WriteLine(DateSolver.Analyze(month, day, year));
        }

        private static int ValidateValue(int min, int max, string target)
        {
            int input = 0;
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("\nPlease enter number\n");
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

        private static int ValidateValue(string message)
        {
            int input;
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("\nPlease enter number\n");
                Console.WriteLine(message);
            }
            return input;
        }
    }
}
