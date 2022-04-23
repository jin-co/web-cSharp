using System;

namespace KwangjinBaek
{
    class Program
    {
        //Kwangjin Baek #8707943
        static void Main(string[] args)
        {
            string inputString, anotherInput, output;
            bool goOn = true;

            do
            {
                try
                {
                    // user input
                    Console.Write("Please enter the string: ");
                    inputString = Console.ReadLine();

                    // checks if it is empty. If it is not shows the result and ends
                    if (inputString != "")
                    {
                        goOn = false;
                        output = Utility.StringOperations(inputString);
                        Console.WriteLine(output);

                        // splits the result by delimiter ','
                        string[] tokens = output.Split(',');
                        foreach (var i in tokens)
                        {
                            Console.Write(i);
                        }

                        // shows the result after spliting
                        for (int i = 0; i < inputString.Length; i++)
                        {
                            if (char.IsDigit(inputString[i]))
                            {
                                Console.WriteLine(inputString[i]);
                            }
                        }
                    }

                    // asks if they want to keep going
                    Console.Write("Would you like to stop? (enter 'yes' to stop): ");
                    anotherInput = Console.ReadLine();
                    if (anotherInput == "yes" || anotherInput == "YES" || anotherInput == "y" || anotherInput == "Y")
                    {
                        goOn = false;
                    }

                    // throws an error if it is empty
                    else
                    {
                        throw new ArgumentException("Error Message");
                    }
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e);
                }

                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e);
                }

                catch (OverflowException e)
                {
                    Console.WriteLine(e);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (goOn);
        }
    }
}
