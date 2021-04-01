using System;

namespace Task_3
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
            int limit = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0 || i % 7 == 0) continue;
                else
                {
                    limit++;
                    if (limit >= 100) {
                        Console.WriteLine("\nThe limit is reached and stop counting\n");
                        return; 
                    }
                    Console.WriteLine(i);
                    
                }
            }
        }
    }
}
