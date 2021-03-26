using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Real-Calculator\n");
            Console.WriteLine("Enter first number");

            string firstNumberInput = Console.ReadLine();
            Console.WriteLine("\nEnter second number\n");
            string secondNumberInput = Console.ReadLine();

            bool firstNumberParse = int.TryParse(firstNumberInput, out int firstNumber);
            bool secondNumberParse = int.TryParse(secondNumberInput, out int secondNumber);

            if (firstNumberParse && secondNumberParse)
            {
                Console.WriteLine("\nPlease choose operation:");
                Console.WriteLine("\n 1 -> + \n 2 -> - \n 3 -> * \n 4 -> / \n");
                string operation = Console.ReadLine();
                bool operationParse = int.TryParse(operation, out int intOperation);
                Console.WriteLine("\n");
                if(intOperation > 4 || intOperation < 1)
                {
                    Console.WriteLine("Please choose from 1 to 4 !!!");

                }
                switch (intOperation)
                {
                    case 1:
                        int result1 = firstNumber + secondNumber;
                        Console.WriteLine(firstNumber + " + " + secondNumber + " = " + result1);
                        break;
                    case 2:
                        int result2 = firstNumber - secondNumber;
                        Console.WriteLine(firstNumber + " - " + secondNumber + " = " + result2);
                        break;
                    case 3:
                        int result3 = firstNumber * secondNumber;
                        Console.WriteLine(firstNumber + " * " + secondNumber + " = " + result3);
                        break;
                    case 4:
                        int result4 = firstNumber / secondNumber;
                        Console.WriteLine(firstNumber + " / " + secondNumber + " = " + result4);
                        break;
                }
            }
            else {
                Console.WriteLine("Please enter valid numbers!!!");
            };

        }
    }
}
