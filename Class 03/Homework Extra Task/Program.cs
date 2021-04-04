using System;

namespace Homework_Extra_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numberArray = new int[0];
            int counter = 0;

            while (true)
            {
                Console.WriteLine("\nEnter as many numbers as you like and press C to find the second smalesst number\nOr N to exit\n");

                string userInput = Console.ReadLine();
                bool userINputParsed = int.TryParse(userInput, out int inputNum);

                if (userInput == "n" || userInput == "N")
                {
                    break;
                }
                else if (userInput == "c" || userInput == "C")
                {
                    Array.Sort(numberArray);
                    Console.WriteLine("Second smallest number is " + numberArray[1]);
                }
                else if (!userINputParsed)
                {
                    Console.WriteLine("\nWrong input!!\n");
                }
                else
                {
                    counter++;
                    Array.Resize(ref numberArray, counter);
                    numberArray[counter - 1] = inputNum;
                }
            }
        }
    }
}
