using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4JSDSJB
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Group Members:
             * Josslyne Shantz - Jshantz8979@conestogac.on.ca
             * Dalvir Singh Dalvir Singh - Dalvirsingh7574@conestogac.on.ca
             * Jessica Broatch - Jbroatch9019@conestogac.on.ca
             */

            int brandNumber;
            string brand, option;
            bool end;
            string[] brandJSDSJB = new string[3] { "", "", "" };
            string[] tShirts = new string[12] { "", "", "", "", "", "", "", "", "", "", "", "" };
            for (int i = 0; i < 3; i++)
            {
                brandNumber = i + 1;
                Console.WriteLine("Please enter brand " + brandNumber);
                brand = Console.ReadLine();
                brandJSDSJB[i] = brand;
            }
            do
            {
                Console.WriteLine("A: Add new T-Shirts");
                Console.WriteLine("B: Edit existing T-Shirts");
                Console.WriteLine("C: Display existing T-Shirts");
                Console.WriteLine("D: Delete exististing T-Shirt");
                Console.WriteLine("E: End program");
                Console.WriteLine("Enter the letter of the option you wish to do: ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "A":
                    case "a":
                        tShirts = AddTShirt(tShirts, brandJSDSJB);
                        end = false;
                        break;
                    case "B":
                    case "b":
                        tShirts = EditTShirt(tShirts, brandJSDSJB);
                        end = false;
                        break;
                    case "C":
                    case "c":
                        DisplayTShirt(tShirts);
                        end = false;
                        break;
                    case "D":
                    case "d":
                        tShirts = DeleteTshirt(tShirts);
                        end = false;
                        break;
                    default:
                        end = true;
                        break;
                }


            } while (end == false);
        }

        static string[] AddTShirt(string[] tShirtDetails, string[] brandJSDSJB)
        {
            try
            {
                string brand, size, tShirt, newTShirtString;
                bool end = false;
                int numberOfShirts = 0;
                foreach(string i in tShirtDetails)
                {
                    if(i != "NONE")
                    {
                        numberOfShirts++;
                    }
                }
                if (numberOfShirts != 12)
                {
                    do
                    {
                        bool sizeIsGood = false;
                        int index, tShirtIndex, informationIndex = 0;
                        do
                        {
                            if (informationIndex == -1)
                            {
                                Console.WriteLine("Please use one the brands you first entered.");
                            }
                            index = 0;
                            informationIndex = -1;
                            Console.Write("What brand is the T-Shirt you want to add? Enter 'DONE' if you wish to exit now. ");
                            brand = Console.ReadLine();
                            if(brand != "DONE")
                            { 
                                foreach (string i in brandJSDSJB)
                                {
                                    if (i == brand)
                                    {
                                        informationIndex = index;
                                    }
                                    index++;
                                }
                            }
                            else { end = true; }
                        } while (informationIndex == -1 && end == false);
                        if(end == false)
                        {
                            do
                            {
                                Console.WriteLine("The sizes you can choose from are: ");
                                Console.WriteLine("Small(1)\nMedium(2)\nLarge(3)\nExtra-Large(4)");
                                Console.Write("What size is the T-Shirt you want to add? ");
                                size = Console.ReadLine();
                                sizeIsGood = SizeAuthentication(size);
                            } while (sizeIsGood == false);
                            index = 0;
                            informationIndex = -1;
                            tShirtIndex = -1;
                            tShirt = brand + "-" + size;
                            foreach (string i in tShirtDetails)
                            {
                                if (i == "NONE")
                                {
                                    tShirtIndex = index;
                                }
                                else if(i == tShirt)
                                {
                                    informationIndex = index;
                                }
                                index++;
                            }
                            if (informationIndex != -1)
                            {
                                Console.WriteLine("Error T-Shirt record already exists.");
                            }
                            else
                            {
                                tShirtDetails[tShirtIndex] = tShirt;
                                numberOfShirts++;
                                Console.WriteLine("T-Shirt record has been saved.");
                            }
                            if (numberOfShirts == 12)
                            {
                                Console.WriteLine("You have 12 T-Shirts now.\nGoing back to the main menu.");
                                end = true;
                            }
                        }
                    } while (end == false);
                }
                else
                {
                    Console.WriteLine("You already have 12 T-Shirts recorded.");
                    Console.WriteLine("Going back to the main menu.");
                }
                return tShirtDetails;
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, something went wrong.");
                return tShirtDetails;
            }
        }

        static string[] EditTShirt(string[] tShirtDetails, string[] brandJSDSJB)
        {
            try 
            { 
                string tShirt, brand, size;
                int informationIndex = 1, tShirtIndex=-1, index = 0;
                bool sizeIsGood = false, end = false;
                Console.Write("What brand entry would you like to edit? Please enter in the format of 'Brand-Size': ");
                tShirt = Console.ReadLine();
                foreach(string i in tShirtDetails)
                {
                    if(i == tShirt)
                    {
                        tShirtIndex = index;
                    }
                    index ++;
                }

                if (tShirtIndex == -1)
                {
                    Console.WriteLine("Brand record not found for that entry.");
                    return tShirtDetails;
                }
                else
                {
                    Console.WriteLine("Brand information found.");
                    Console.WriteLine("Please enter updated information");
                    do {
                        if (informationIndex == 0)
                        {
                            Console.WriteLine("Please use one the brands you first entered.");
                        }
                        index = 0;
                        Console.Write("What is the brand? Enter 'DONE' if you whish to return to the menu now. ");
                        brand = Console.ReadLine();
                        if (brand != "DONE")
                        {
                            foreach (string i in brandJSDSJB)
                            {
                                if (i == brand)
                                {
                                    informationIndex = index;
                                }
                                index++;
                            }
                        }
                        else { end = true; }
                    } while (informationIndex == 0 && end == false);
                    if(end == false)
                    {
                        do
                        {
                            Console.WriteLine("The sizes you can choose from are: ");
                            Console.WriteLine("Small(1)\nMedium(2)\nLarge(3)\nExtra-Large(4)");
                            Console.Write("What size is the T-Shirt you want to add? ");
                            size = Console.ReadLine();
                            sizeIsGood = SizeAuthentication(size);
                        } while (sizeIsGood == false);
                        index = 0;
                        informationIndex = -1;
                        tShirt = brand + "-" + size;
                        foreach (string i in tShirtDetails)
                        {
                            if (i == tShirt)
                            {
                                informationIndex = index;
                            }
                            index++;
                        }
                        if (informationIndex != -1)
                        {
                            Console.WriteLine("Error T-Shirt record already exists.");
                        }
                        else
                        {
                            tShirtDetails[informationIndex] = tShirt;
                            Console.WriteLine("Record is updated.");
                        }
                    }
                    return tShirtDetails;
                }           
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry. Something went wrong.");
                return tShirtDetails;
            }
        }

        static string[] DeleteTshirt(string[] tShirtDetails)
        {
            Console.WriteLine("What Brand Entry Would You Like to Delete? ");
            Console.Write("Please Enter In Brand-Size Format, i.e. Brand-Size ");
            //array selection variable
            string arraySelect = Console.ReadLine();
            int tShirtIndex = -1, index = 0;
            foreach (string i in tShirtDetails)
            {
                if (i == arraySelect)
                {
                    tShirtIndex = index;
                }
                index++;
            }
            if (tShirtIndex == -1)
            {
                Console.WriteLine("\nBrand Record Not Found For That Entry.");
                Console.WriteLine("You Will Be Returned To Main Menu.");
                Console.ReadKey();
                return tShirtDetails;
            }
            else
            {
                Console.Write("\nBrand Information Found. Are You Sure You Want to Delete Y/N? ");
                char deleteEntry = Convert.ToChar(Console.ReadLine());
                if (deleteEntry is 'Y')
                {
                    tShirtDetails[tShirtIndex] = "NONE";
                    Console.WriteLine("The Brand Information Has Been Deleted.");
                    Console.WriteLine("You Will Be Returned To Main Menu.");
                    Console.ReadKey();
                }
                else if (deleteEntry is 'N')
                {
                    Console.WriteLine("You Will Be Returned to Main Menu.");
                    Console.ReadKey();
                }
                return tShirtDetails;
            }
        }

        static void DisplayTShirt (string[] brandJSDSJB)
        {
            try
            {
                foreach (string i in brandJSDSJB)
                {
                    if (i != "" && i != "NONE")
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Press enter to return to the main menu.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, something went wrong.");
            }
        }

        static bool SizeAuthentication(string sizeString)
        {
        try
        {
            int size;
            size = int.Parse(sizeString);
            if (1 > size || size > 4)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Please enter a size between 1 and 4.");
            return false;
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a number for the size.");
            return false;
        }
        return true;
        }
    }
}
