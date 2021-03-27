using System;

namespace Days_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Days Converter\n\n");
            Console.WriteLine("Enter number of days to convert:");
            string daysInput = Console.ReadLine();
            bool dayParsed = int.TryParse(daysInput, out int days);

            if (dayParsed)
            {
                int year = days / 365;
                int week = (days % 365) / 7;
                days = days - ((year * 365) + (week * 7));

                if(year == week && year == days)
                {
                    Console.WriteLine("\nYou've entered a special number of days!");
                }
                Console.WriteLine("\n\n");
                Console.WriteLine("Years: " + year);
                Console.WriteLine("\nWeeks: " + week);
                Console.WriteLine("\nDays: " + days);
            }
            else
            {
                Console.WriteLine("Wrong input!!!");
            }
        }
    }
}
