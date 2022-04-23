using System;

namespace m_question2_KwangjinBaek_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string firstName = "";
                string lastName = "";
                double firstN = 0;
                double secondN = 0;
                double result = 0;

                bool sentinel = true;
                while (sentinel)
                {
                    Console.Write("Enter you first name: ");
                    string first = Console.ReadLine();
                    string firstCapital = first.ToUpper();
                    Console.Write("Enter you last name: ");
                    string last = Console.ReadLine();
                    string lastCapital = first.ToUpper();

                    switch (first)
                    {
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                            Console.WriteLine("Name should be words");
                            break;

                        default:

                            break;
                    }

                    switch (last)
                    {
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                            Console.WriteLine("Name should be words");
                            break;

                        default:

                            break;
                    }

                    Console.Write("Enter first number between 500 ~ 1000: ");
                    double firstNum = double.Parse(Console.ReadLine());
                    Console.Write("Enter second number between 500 ~ 1000: ");
                    double secondNum = double.Parse(Console.ReadLine());
                    if (firstNum < 500 || firstNum > 1000 || secondNum < 500 || secondNum > 1000)
                    {
                        Console.WriteLine("Out of range Please enter again");
                    }
                    else
                    {
                        firstName = firstCapital;
                        lastName = lastCapital;
                        firstN = firstNum;
                        secondN = secondNum;
                        sentinel = false;
                    }


                }

                Console.Write("Please choose operation(+,-,/,*): ");
                string operation = Console.ReadLine();
                if (operation == "+")
                {
                    result = (firstN + secondN);
                }

                else if (operation == "-")
                {
                    result = (firstN - secondN);
                }

                else if (operation == "*")
                {
                    result = (firstN * secondN);
                }

                else if (operation == "/")
                {
                    result = (firstN / secondN);
                }

                if (result > 50)
                {
                    result = (result * 2) - 4;
                }

                else if (result <= 50 && result > 10)
                {
                    result = (result * 7) + 2;
                }

                Console.WriteLine("Hello {0} {1} your answer is {2}", firstName, lastName, result);
            }
            catch (FormatException fEx)
            {
                Console.WriteLine("You have entered long format" + fEx);
            }

            catch (OverflowException oEx)
            {
                Console.WriteLine("Invalid input" + oEx);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
