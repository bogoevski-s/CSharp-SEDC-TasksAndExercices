using System;
using System.Collections.Generic;
namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> intQueue = new Queue<int>();

            Console.WriteLine("Please input number:");
            string userInput = Console.ReadLine();
            bool userInputParsed = int.TryParse(userInput, out int inputNumber);
            if (!userInputParsed)
            {
                Console.WriteLine("You need to eneter numberic value");
            }
            else
            {
                intQueue.Enqueue(inputNumber);
            }


        }
    }
}
