using System;

namespace Task_2
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
            for (int i = 2; i <= num; i++)
            {
                if (i % 2 != 0) continue;
                Console.WriteLine(i);
            }

            Console.WriteLine("\nEnter another number:");
            string number2 = Console.ReadLine();
            bool number2Parsed = int.TryParse(number2, out int num2);

            if (!number2Parsed) Console.WriteLine("Wrong input!!");
            Console.WriteLine("\n--------------\n");
            for (int j = 1; j <= num2; j++)
            {
                if (j % 2 != 1) continue;
                Console.WriteLine(j);
            }
        }
    }
}
