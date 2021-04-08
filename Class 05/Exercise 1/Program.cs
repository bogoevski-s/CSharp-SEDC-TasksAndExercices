using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();

            bool ageParsesd = int.TryParse(age, out int ageNum);
            if (!ageParsesd)
            {
                Console.WriteLine("Incorrect age!!!");
            }


            Human newHuman = new Human(firstName, lastName, ageNum);
            Console.WriteLine(newHuman.GetPersonStats());
        }
    }
}
