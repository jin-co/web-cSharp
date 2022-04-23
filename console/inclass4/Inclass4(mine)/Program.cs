using System;

namespace Inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kwangjin Baek<Kbaek7943@conestogac.on.ca>, Furs Dmytrii, Lewin Alexander, Patel Roshankumar Kanubhai

            // description

            Console.WriteLine("******* Menu *******");
            Console.WriteLine("1. Spring Salad $65\n2. Chickpea Spread $75\n3. Rulet of Spinach $85\n4. Turnip Smoothie $35\n5. Garbanzo Milk $95 ");
            Console.Write("Please enter your budget: ");
            int budget = int.Parse(Console.ReadLine());

            Console.Write("Please select a menu by the number: ");
            int menuNumChoice = int.Parse(Console.ReadLine());

            string[] dishName = { "Spring Salad", "Chickpea Spread", "Rulet of Spinach", "Turnip Smoothie", "Garbanzo Milk" };
            int[] dishPrice = { 65, 75, 85, 35, 95 };

            for (int i = budget, j = dishPrice[menuNumChoice - 1]; i >= j; i -= j)
            {
                Console.WriteLine("You have ordered {0} ${1}", dishName[menuNumChoice-1], j);
                Console.WriteLine("${0}",i - j);
                Console.Write("Anything else? ");
                menuNumChoice = int.Parse(Console.ReadLine());
            }
        }
    }
}
