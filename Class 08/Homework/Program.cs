using System;
using System.Collections.Generic;
namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> intQueue = new Queue<int>();

            while (true)
            {
                Console.WriteLine("Please input number:\n");
                string userInput = Console.ReadLine();
                bool userInputParsed = int.TryParse(userInput, out int inputNumber);
                if (!userInputParsed)
                {
                    Console.WriteLine("\nYou need to eneter numberic value\n");

                    continue;
                }
                else
                {
                    intQueue.Enqueue(inputNumber);

                    while (true)
                    {
                        Console.WriteLine("\n1.Add another number\n2.Exit\n");
                        string userAddOrExit = Console.ReadLine();
                        bool parsedUserOption = int.TryParse(userAddOrExit, out int menuNum);
                        if (!parsedUserOption || menuNum < 1 || menuNum > 2)
                        {
                            Console.WriteLine("\nWrong input!!\nPlease select 1 or 2");
                            continue;
                        }
                        else if(menuNum == 1)
                        {
                            break;
                        }
                        else if(menuNum == 2)
                        {
                            Console.WriteLine("\nAll your numbers:\n");
                            foreach(int num in intQueue)
                            {
                                Console.WriteLine(num);
                            }
                            return;
                        }
                    }
                    
                }
            }
            


        }
    }
}
