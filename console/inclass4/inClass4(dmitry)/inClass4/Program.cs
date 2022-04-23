using System;

namespace inClass4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = new string[5];
            string userContinueChoice = "";
            int selectedDish = 0, selectedOptionWhenUserIsAboveTheBudget = 0;
            double budgetOfCustomer = 0, priceOfSelectedDish = 0, enlargeBudget =0;
            bool stopOrder = true, firstOrder = true;
            menu = MakeMenu(menu.Length, menu);
            Console.WriteLine();
            Console.WriteLine();
            
            for (int i =0; i < menu.Length; i++)
            {
                Console.WriteLine((i+1) + ". " + menu[i]);
            }
            Console.WriteLine();
            
            while (stopOrder)
            {
                try
                {
                    Console.WriteLine("Enter the menu number of your order:");
                    selectedDish = int.Parse(Console.ReadLine());
                    if(selectedDish < 1 && selectedDish > menu.Length)
                        throw new ArgumentOutOfRangeException("Error. Invalid input of number of your order...");
                    
                    if (firstOrder == true)
                    {
                        Console.WriteLine("Enter your budget:");
                        budgetOfCustomer = double.Parse(Console.ReadLine());
                    }
                    priceOfSelectedDish = double.Parse(System.Text.RegularExpressions.Regex.Match(menu[selectedDish - 1], @"\d+").Value);
                    
                    Console.WriteLine("The name of the dish you selected: " + menu[selectedDish].TrimEnd(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '$'}));
                    firstOrder = false;                    
                    if (priceOfSelectedDish <= budgetOfCustomer)
                    {
                        Console.WriteLine("The price of the dish you selected: " + priceOfSelectedDish + " $");
                        budgetOfCustomer = budgetOfCustomer - priceOfSelectedDish;
                        Console.WriteLine("Rest of your budget is: " + budgetOfCustomer);
                        Console.WriteLine("Do you want to continue? Type \"YES\" if you do and anything else to stop...");
                        userContinueChoice = Console.ReadLine();
                        
                        if (userContinueChoice != "YES" || userContinueChoice != "yes")
                        {
                            Console.WriteLine("Thank you for using our services. Have a good day!");
                            stopOrder = false; 
                        }
                    }

                    else 
                    {
                        while (true)
                        {
                            Console.WriteLine("You are out of the budget!");
                            Console.WriteLine("What do you want? (Press \"1\" to enter another dish; Press \"2\" to enlarge the budget; Press \"3\" to end;)...");
                            selectedOptionWhenUserIsAboveTheBudget = int.Parse(Console.ReadLine());
                            
                            if (selectedOptionWhenUserIsAboveTheBudget < 1 && selectedOptionWhenUserIsAboveTheBudget > 3)
                                throw new ArgumentOutOfRangeException("Error. Invalid input of option...");
                            
                            if (selectedOptionWhenUserIsAboveTheBudget == 2)
                            {
                                Console.WriteLine("Enter amount of money you want to add to your budget:");
                                enlargeBudget = double.Parse(Console.ReadLine());
                                budgetOfCustomer += enlargeBudget;
                                if (priceOfSelectedDish <= budgetOfCustomer)
                                {
                                    Console.WriteLine("The price of the dish you selected: " + priceOfSelectedDish + " $");
                                    budgetOfCustomer = budgetOfCustomer - priceOfSelectedDish;
                                    Console.WriteLine("Rest of your budget is: " + budgetOfCustomer);
                                    Console.WriteLine("Do you want to continue? Type \"YES\" if you do and anything else to stop...");
                                    userContinueChoice = Console.ReadLine();
                                    if (userContinueChoice != "YES" || userContinueChoice != "yes")
                                    {
                                        Console.WriteLine("Thank you for using our services. Have a good day!");
                                        stopOrder = false;
                                    }
                                }
                                break;
                            }

                            else if(selectedOptionWhenUserIsAboveTheBudget == 3)
                            {
                                Console.WriteLine("Thank you for using our services. Have a good day!");
                                stopOrder = false;
                                break;
                            }

                            else
                            {
                                break;
                            }
                        }
                    }

                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        static string[] MakeMenu(int amountOfDishes, string[] menu)
        {
            for (int i = 0; i < amountOfDishes; i++)
            {
                Console.WriteLine("Enter the dish number " + (i + 1) + ": ");
                menu[i] = Console.ReadLine();
            }
            return menu;
        }
    }
}
