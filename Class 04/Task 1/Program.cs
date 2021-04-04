using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Choose operation - or +\n");
                Console.WriteLine("Press x to exit\n\n");
                string userInputOperation = Console.ReadLine();

                if (userInputOperation == "x" || userInputOperation == "X") break;

                else if (userInputOperation != "-" && userInputOperation != "+")
                {
                    Console.WriteLine("Wrong input!!\n");
                }

                else
                {
                    Console.WriteLine("Enter first number\n");
                    Console.WriteLine("Press x to exit\n\n");
                    string userFirstNumber = Console.ReadLine();

                    Console.WriteLine("\nEnter your second number\n");
                    Console.WriteLine("Press x to exit\n\n");
                    string userSecondNumber = Console.ReadLine();

                    bool firstNumberParsed = int.TryParse(userFirstNumber, out int num1);
                    bool secondNumberParsed = int.TryParse(userSecondNumber, out int num2);

                    if (firstNumberParsed || secondNumberParsed)
                    {
                        if (userInputOperation == "-") Substract(num1, num2);
                        else Sum(num1, num2);
                        Console.WriteLine("\nDo you want another calculation?\nType any key to continue of 'n' to exit\n");
                        string userInputAfterRes = Console.ReadLine();
                        if (userInputAfterRes == "n" || userInputAfterRes == "N") break;

                    }
                    else
                    {
                        Console.WriteLine("Please enter numeric values\n");
                    }
                }
            }


        }

        static int Sum(int num1, int num2)
        {
            Console.WriteLine("\nResult"); 
            Console.WriteLine(num1 + num2);
            return num1 + num2;
        }
        static int Substract(int num1, int num2)
        {
            Console.WriteLine("\nResult");
            Console.WriteLine(num1 - num2);
            return num1 - num2;
        }
    }
}
