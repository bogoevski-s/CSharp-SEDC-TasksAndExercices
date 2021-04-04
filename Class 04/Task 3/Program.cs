using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number:\nOr x to exit");
                string userInput = Console.ReadLine();
                bool userInputParsed = int.TryParse(userInput, out int number);

                if (userInput == "x" || userInput == "X") break;

                else if (!userInputParsed) Console.WriteLine("Wrong Input !!!");
                
                else if (number <= 0) Console.WriteLine("You need to enter number greater than 0");

                else
                {
                    Substrings(number);
                    break;
                }
            }
            
        }
        static void Substrings(int n)
        {
            string statement = "Hello from SEDC Codeacademy 2021";
            string changedStatement = statement.Substring(0, n);
            Console.WriteLine(changedStatement);
        }
    }
}
