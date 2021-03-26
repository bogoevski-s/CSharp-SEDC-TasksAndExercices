using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 6 \n");
            Console.WriteLine("Please enter 2 numbers\n");

            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            bool firstNumParse = float.TryParse(firstNumber, out float firstNumberFloat);
            bool secondNumParse = float.TryParse(secondNumber, out float secondNumberFloat);

            if(firstNumParse && secondNumParse)
            {
                if (firstNumberFloat > secondNumberFloat)
                {
                    Console.WriteLine("\nNumber " + firstNumberFloat + " is bigger number than " + secondNumberFloat);
                    Console.WriteLine("\n");
                    Console.WriteLine(firstNumberFloat % 2 == 0 ? "Number " + firstNumberFloat + " is even!" : "Number " + firstNumberFloat + " is odd");
                }
                else if(secondNumberFloat > firstNumberFloat)
                {
                    Console.WriteLine("\nnumber " + secondNumberFloat + " is bigger number than " + firstNumberFloat);
                    Console.WriteLine("\n");
                    Console.WriteLine(secondNumberFloat % 2 == 0 ? "Number " + secondNumberFloat + " is even!" : "Number " + secondNumberFloat + " is odd");
                }
                else
                {
                    Console.WriteLine(secondNumberFloat + " and " + firstNumberFloat + " are equal");
                    Console.WriteLine("\n");
                    Console.WriteLine(secondNumberFloat % 2 == 0 ? "Number " + secondNumberFloat + " is even!" : "Number " + secondNumberFloat + " is odd");
                }
            }
            else
            {
                Console.WriteLine("\nFor god sake, please use NUMBERS !!!!");
            }
        }
    }
}
