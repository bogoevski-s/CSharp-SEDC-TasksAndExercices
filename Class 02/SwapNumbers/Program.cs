using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap Numbers App \n");
            Console.WriteLine("Please enter 2 numbers\n");

            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            string firstNumberCopy = firstNumber;

            firstNumber = secondNumber;
            secondNumber = firstNumberCopy;

            Console.WriteLine("\nFirst number : " + firstNumber);
            Console.WriteLine("Second number : " + secondNumber);

        }
    }
}
