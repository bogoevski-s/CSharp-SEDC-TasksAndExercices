using System;
using System.Text;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Age Calculator");
            Console.WriteLine($@"Enter your age in this format ""dddd MMM yyyy"" seperated by coma ");

            string inputDate = Console.ReadLine();
            DateTime date = DateTime.Parse(inputDate);

            AgeCalculator(date);
        }
        static void AgeCalculator(DateTime date)
        {
            DateTime today = DateTime.Now;
            int todayYear = today.Year;
            int bornYear = date.Year;

            Console.WriteLine($"\nYou are -> {todayYear - bornYear} years old");
        }
    }
}
