using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please enter number:\n");
                string stringNumber = Console.ReadLine();
                bool numberParsed = double.TryParse(stringNumber, out double inputNumber);

                if (!numberParsed)
                {
                    Console.WriteLine("\nPlease enter numberic value!!\n");
                    continue;
                }

                else
                {
                    NumberStats(inputNumber);
                    Console.WriteLine("\nPress Y to enter new number or X  to exit\n");
                    string userInput = Console.ReadLine();

                    if (userInput == "Y" || userInput == "y") continue;
                    else if (userInput == "X" || userInput == "x") break;
                    else
                    {
                        Console.WriteLine("Wrong input!! Please choose Y or X");
                        continue;
                    }
                }

            }
        }

        static void NumberStats(double num)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            if (num < 0) Console.WriteLine("\nNegative number");
            else Console.WriteLine("\nPositive number");

            string strNum = num.ToString();
            string dot = ".";
            bool containsDot = strNum.Contains(dot);

            if (containsDot)
            {
                Console.WriteLine("\nDecimal number!");
                EvenOdd(num);
            }
            else
            {
                Console.WriteLine("\nIntiger");
                EvenOdd(num);
            }

            Console.ResetColor();
        }
        static void EvenOdd(double num)
        {
            string strNum = num.ToString();

            var lastStringNumber = strNum.Substring(strNum.Length - 1);

            int lastNumber = int.Parse(lastStringNumber);

            if (lastNumber % 2 == 0) Console.WriteLine("\nEven Number");
            else Console.WriteLine("\nOdd Number");

        }
    }
}
