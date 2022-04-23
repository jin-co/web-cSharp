using System;

namespace Inclass5
{
    class Program
    {
        private static int FindSecretNumber;

        static void Main(string[] args)
        {
            //shrey vora <svora0056@conestogac.on.ca>, Drew Saunders <Dsaunders7770 @conestogac.on.ca>, Kwangjin Baek <Kbeak7943@conestogac.on.ca>, David Courtney <Dcourtney3017@conestogac.on.ca>

            /* part A: Reverses entered name */
            bool goOn = true;
            while (goOn)
            {
                try
                {
                    Console.WriteLine("*************** Part A ***************");
                    Console.Write("Enter your first and last name: ");
                    string name = Console.ReadLine();
                    char[] reverse = name.ToCharArray();
                    Array.Reverse(reverse);
                    Console.WriteLine(reverse);
                    Console.WriteLine("**************************************");
                }

                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e);
                }

                catch (OutOfMemoryException e)
                {
                    Console.WriteLine(e);
                }

                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                goOn = false;
            }


            /* part B: Finds the check digit */
            bool goOn_2 = true;
            while (goOn_2)
            {
                try
                {
                    int checkDigitKey = 0, checkDigit = 0;

                    Console.WriteLine("\n*************** Part B ***************");

                    // Asks the user to input their ID digit
                    Console.Write("Enter your creditcard number\n(16 digit):");
                    string inputDigit = Console.ReadLine();

                    // Splits the string into char and stores in an array
                    char[] split = inputDigit.ToCharArray();

                    // Converts char array into int array
                    int[] charToint = Array.ConvertAll(split, c => (int)Char.GetNumericValue(c));

                    // Looks for even numbers to multiply by 2
                    for (int i = 1; i < split.Length; i += 2)
                    {
                        // Splits the numbers that are more than 10
                        charToint[i] = charToint[i] * 2;
                        if (charToint[i] >= 10)
                        {
                            charToint[i] = (charToint[i] - 10) + 1;
                        }
                    }

                    //Adds all the numbers 
                    for (int i = 0; i < 16; i++)
                    {
                        checkDigitKey = checkDigitKey + charToint[i];
                    }

                    //Produces the chech digit
                    checkDigit = 10 - (checkDigitKey % 10);

                    Console.WriteLine("\nThe check Digit is: " + checkDigit);
                    Console.WriteLine("**************************************");
                    goOn_2 = false;
                }

                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e);
                }

                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e);
                }

                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e);
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e);
                }

                catch (OverflowException e)
                {
                    Console.WriteLine(e);
                }

                catch (InvalidOperationException e)
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
