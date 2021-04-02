using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum Of Even Numbers\n\n");
            Console.WriteLine("You need to enter 5 numbers\n\n");

            int[] sumOfEven = new int [6];
            int counter = 0;
            int totalEven = 0;

            while (counter < 6)
            {
                Console.WriteLine("\nEnter your number " + counter);
                string userInput = Console.ReadLine();
                bool userInputParsed = int.TryParse(userInput, out int number);
                if (!userInputParsed)
                {
                    Console.WriteLine("Wrong Input!!!");
                }
                else
                {
                    sumOfEven[counter] = number;
                }
                counter++;
            }
            Console.WriteLine("\n\n");

            foreach(int num in sumOfEven)
            {
                if (num % 2 != 0) continue;
                totalEven += num;
            }
            Console.WriteLine(totalEven);
        }
    }
}
