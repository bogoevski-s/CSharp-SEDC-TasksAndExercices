using System;

namespace Exercisse_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Reverse(name);
            
        }
        static void Reverse(string name)
        {
            char[] charArr = name.ToCharArray();
            Array.Reverse(charArr);
            Console.Write("\nYour name in reverse = ");
            Console.WriteLine(charArr); 
        }
    }
}
