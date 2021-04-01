using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbersArray = new int[5];

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number in the array:");

                string userInput = Console.ReadLine();
                bool inputParsed = int.TryParse(userInput, out int number);

                if (!inputParsed) return;

                numbersArray[i] = number;
            }
            ArraySum(numbersArray);

        }
        static void ArraySum(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            Console.Write("\n" + sum + "\n");
        }
    }
}
