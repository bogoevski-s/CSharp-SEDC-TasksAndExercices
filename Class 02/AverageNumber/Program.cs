using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Averge Number App \n");
            Console.WriteLine("You need to enter 4 numbers\n");
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            string thirdNum = Console.ReadLine();
            string fourthNum = Console.ReadLine();

            bool firstNumParse = float.TryParse(firstNum, out float firstNumberFloat);
            bool secondNumParse = float.TryParse(secondNum, out float secondNumberFloat);
            bool thirdNumParse = float.TryParse(thirdNum, out float thirdNumberFloat);
            bool fourthNumParse = float.TryParse(fourthNum, out float fourthNumumberFloat);
            if(firstNumParse && secondNumParse && thirdNumParse && fourthNumParse)
            {
                var avr = (firstNumberFloat + secondNumberFloat + thirdNumberFloat + fourthNumumberFloat) / 4;
                Console.WriteLine("\n");
                Console.WriteLine("Average = " + avr);
            }
            else
            {
                Console.WriteLine("\nInvalid number !! \nPlease enter valid numbers");
            }
        }
    }
}
