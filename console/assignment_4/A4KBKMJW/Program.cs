using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace A4Group_17P1
{
    class Program
    {
        // Kwangjin Baek <Kbaek7943@conestogac.on.ca> Keith Muema <Kmuema1971@conestogac.on.ca> Jacob Wall <Jwall8052@conestogac.on.ca>

        /* This application allows users to input brand (1 ~ 3) and size (1 ~ 4), and edit, delete */
        static void Main(string[] args)
        {
            // arrays: brand, size, menu
            string[] brandjin = new string[3], brandInput = new string[12];
            string[] size = new string[4] { "Small(1)", "Medium(2)", "Large(3)", "XLarge(4)" };
            string[] menu = {"A. Add new T-shirt details (Brand name & Size).",
                "B. Edit existing T-shirt details (Brand name & Size)",
                "C. Display all T-shirt information.", "D. Delete T-shirt information",
                "E. Exit the program"};
            // sentinels: main menu, sub menu
            string brandInputTemporary = "", brandSizeCombined = "", end = "";
            bool goOn = true, stayA = true, stayB = true, stayC = true, stayD = true;
            int sizeInput = 0, whileCheck = 0;
           
            for (int i = 0; i < brandjin.Length; i++)
            {
                Console.Write("Enter brand: ");
                brandjin[i] = Console.ReadLine();
            }

            // Main menu
            while (goOn)
            {
                try
                {
                    stayA = true;
                    stayB = true;
                    stayC = true;
                    stayD = true;

                    Console.WriteLine("\n************************ Menu ************************");
                    for (int i = 0; i < menu.Length; i++)
                    {
                        Console.WriteLine(menu[i]);
                    }
                    Console.Write("\nPlease choose an option: ");
                    string choice = Console.ReadLine();

                    // Option 'A': brand and size input
                    if (choice == "A" || choice == "a")
                    {
                        /* Option A part: Users can enter item information ('brand - size') */
                        while (stayA)
                        {
                            // asks brand name
                            Console.Write("Enter brand name ({0} {1} {2}): ", brandjin[0], brandjin[1], brandjin[2]);
                            brandInputTemporary = Console.ReadLine();
                            if (brandInputTemporary != brandjin[0] && brandInputTemporary != brandjin[1] && brandInputTemporary != brandjin[2])
                            {
                                throw new ArgumentException("We only have three brands. Enter again.");
                            }

                            // asks size (1 ~ 4)
                            Console.Write("Enter size (1 ~ 4): ");
                            sizeInput = int.Parse(Console.ReadLine());
                            if (sizeInput < 1 || sizeInput > 4)
                            {
                                throw new ArgumentException("Size out of range! Enter again.");
                            }
                            brandSizeCombined = brandInputTemporary + "-" + sizeInput.ToString();

                            // Checks if the item entered already exists in the box. Keeps going until item box is full or user enters 'done'
                            bool itemCheck = false;
                            if (whileCheck < 12)
                            {
                                for (int i = 0; i < brandInput.Length; i++)
                                {
                                    if (brandInput[i] == brandSizeCombined)
                                    {
                                        Console.WriteLine("Error T-Shirt record already exists");
                                        itemCheck = false;
                                        break;
                                    }

                                    else
                                    {
                                        itemCheck = true;
                                    }
                                }

                                if (itemCheck == true)
                                {
                                    brandInput[whileCheck] = brandSizeCombined;
                                    Console.WriteLine("Item has stored");
                                    whileCheck += 1;
                                }
                            }

                            else
                            {
                                Console.WriteLine("Item box is full");
                            }

                            Console.Write("Do you want to keep going? (Enter 'Done' to stop): ");
                            end = Console.ReadLine();
                            if (end == "DONE" || end == "done" || end == "Done")
                            {
                                stayA = false;
                            }
                        }
                    }

                    // Option 'B': edit the data
                    else if (choice == "B" || choice == "b")
                    {
                        while (stayB)
                        {
                            // Shows item entered in option 'A'
                            Console.WriteLine("\n*********************** Items ***********************");
                            for (int i = 0; i < brandInput.Length; i++)
                            {
                                Console.WriteLine(brandInput[i]);
                            }
                            Console.WriteLine("*****************************************************");

                            // Asks what item to change
                            Console.Write("Enter the \"brand-size\" you wish to edit: ");
                            brandInputTemporary = Console.ReadLine();

                            // Checks the index of the entered item
                            int indexCheckB = Array.IndexOf(brandInput, brandInputTemporary);

                            // Throws an error if the item doesn't exist
                            if (indexCheckB == -1)
                            {
                                throw new ArgumentException("Brand record not found for that entry.");
                            }

                            // Asks new information
                            else
                            {
                                Console.WriteLine("\nbrand information found\nPlease enter updated information");
                                Console.Write("Enter brand name ({0} {1} {2}): ", brandjin[0], brandjin[1], brandjin[2]);
                                brandInputTemporary = Console.ReadLine();
                                if (brandInputTemporary != brandjin[0] && brandInputTemporary != brandjin[1] && brandInputTemporary != brandjin[2])
                                {
                                    throw new ArgumentException("We only have three brands. Enter again.");
                                }

                                Console.Write("Enter size (1 ~ 4): ");
                                sizeInput = int.Parse(Console.ReadLine());
                                if (sizeInput < 1 || sizeInput > 4)
                                {
                                    throw new ArgumentException("Size out of range! Enter again.");
                                }
                                brandSizeCombined = brandInputTemporary + "-" + sizeInput.ToString();

                                brandInput[indexCheckB] = brandSizeCombined;
                                Console.WriteLine("The item updated");
                                Console.WriteLine(brandInput[indexCheckB]);
                            }

                            Console.Write("Do you want to go back to the main menu (Press 'Enter'): ");
                            string check = Console.ReadLine();
                            if (check == "")
                            {
                                stayB = false;
                            }
                        }
                    }

                    // Option 'C': shows the item list
                    else if (choice == "C" || choice == "c")
                    {
                        while (stayC)
                        {
                            Console.WriteLine("\n*********************** Items ***********************");
                            for (int i = 0; i < brandInput.Length; i++)
                            {
                                Console.WriteLine(brandInput[i]);
                            }
                            Console.WriteLine("*****************************************************");

                            Console.Write("Do you want to go back to the main menu (Press 'Enter'): ");
                            string check = Console.ReadLine();
                            if (check == "")
                            {
                                stayC = false;
                            }
                        }
                    }

                    // Option 'D': allows the user to delete items (chosen item -> None)
                    else if (choice == "D" || choice == "d")
                    {
                        while (stayD)
                        {
                            Console.WriteLine("\n*********************** Items ***********************");
                            for (int i = 0; i < brandInput.Length; i++)
                            {
                                Console.WriteLine(brandInput[i]);
                            }
                            Console.WriteLine("*****************************************************");

                            Console.Write("Enter the \"brand-size\" you wish to delete: ");
                            brandInputTemporary = Console.ReadLine();

                            int indexCheckD = Array.IndexOf(brandInput, brandInputTemporary);

                            if (indexCheckD == -1)
                            {
                                throw new ArgumentException("Brand record not found for that entry.");
                            }

                            else
                            {
                                Console.Write("brand information found\n!!Are you sure you want to delete Y/N: ");
                                string deleteConfirm = Console.ReadLine();

                                if (deleteConfirm == "y" || deleteConfirm == "Y")
                                {
                                    brandInput[indexCheckD] = "NONE";
                                    foreach (var i in brandInput)
                                    {
                                        Console.WriteLine(i);
                                        whileCheck = indexCheckD;
                                    }
                                }
                            }
                            stayD = false;
                        }
                    }

                    // Option 'E': ends the application
                    else if (choice == "E" || choice == "e")
                    {
                        goOn = false;
                        Console.WriteLine("\nHave a great day");
                    }

                    else
                    {
                        throw new ArgumentException("Out of option range (A ~ E)");
                    }
                }

                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e);
                }

                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e);
                }

                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }                
            }            
        }
    }
}
