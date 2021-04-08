using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dog name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter breed:");
            string breed = Console.ReadLine();
            Console.WriteLine("Enter color:");
            string color = Console.ReadLine();

            Dog firstDog = new Dog(name, breed, color);

            while (true)
            {
                Console.WriteLine("Choose action\n1.Eat\n2.Play\n3.Chase Tail");
                string action = Console.ReadLine();
                bool actionParesd = int.TryParse(action, out int actionNum);
                if (!actionParesd || actionNum > 3 || actionNum < 1)
                {
                    Console.WriteLine("Choose number from  1-3 !!!");
                }

                if (actionNum == 1)
                {
                    Console.WriteLine(firstDog.Eat());
                    break;
                }
                else if (actionNum == 2)
                {
                    Console.WriteLine(firstDog.Play());
                    break;
                }
                else if (actionNum == 3)
                {
                    Console.WriteLine(firstDog.ChaseTail());
                    break;
                }
            }
        }
    }
}
