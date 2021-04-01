using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            string number = Console.ReadLine();
            bool numberParsed = int.TryParse(number, out int num);

            if (!numberParsed) Console.WriteLine("Wrong input!!");
            Console.WriteLine("\n--------------\n");
            for (int i = 1; i < num; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nEnter another number:");
            string number2 = Console.ReadLine();
            bool number2Parsed = int.TryParse(number2, out int num2);

            if (!number2Parsed) Console.WriteLine("Wrong input!!");
            Console.WriteLine("\n--------------\n");
            for (int j = num2; j >= 1; j--)
            {
                Console.WriteLine(j);
            }
        }
    }
}
