using System;

namespace Exerciese_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter\n\n");
            Console.WriteLine("Enter Celsius temp.");
            string temp = Console.ReadLine();
            bool tempPrased = int.TryParse(temp, out int celsius);

            if (!tempPrased)
            {
                Console.WriteLine("Please enter valid number!!");
                return;
            }
            else
            {
                Console.WriteLine("\nConvert Celsius to:\n");
                Console.WriteLine("1. Fahrenheit\n2. Kelvin\n");
                string coversion = Console.ReadLine();
                bool conversionPrased = int.TryParse(coversion, out int fahrOrKel);

                if (fahrOrKel == 1)
                {
                    Convert(celsius, true);
                }
                else if (fahrOrKel == 2)
                {
                    Convert(celsius, false);
                }
                else
                {
                    Console.WriteLine("\nPlease choose 1.Fahrenheit or 2.Kelvin\n");
                    return;
                }
            }
        }
        static void Convert(int cel, bool celToFah)
        {
            if (celToFah)
            {
                int fahr = cel * 18 / 10 + 32;
                Console.WriteLine("\n" + cel + " Celsius deg. = " + fahr + " Fahrenheit deg.");
            }
            else if (!celToFah)
            {
                int kel = cel + 273;
                Console.WriteLine("\n" + cel + " Celsius deg. = " + kel + " Kelvin deg.");
            }
        }
    }
}
