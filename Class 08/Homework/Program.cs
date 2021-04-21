using System;
using System.Collections.Generic;
namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> intQueue = new Queue<int>();
            List<int> intList = new List<int>();
            Stack<int> intStack = new Stack<int>();

            while (true)
            {
                Console.WriteLine("\nPlease input number:");
                string userInput = Console.ReadLine();
                bool userInputParsed = int.TryParse(userInput, out int inputNumber);
                if (!userInputParsed)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou need to eneter numberic value\n");
                    Console.ResetColor();
                    continue;
                }
                else
                {
                    intQueue.Enqueue(inputNumber);
                    intList.Add(inputNumber);
                    intStack.Push(inputNumber);

                    while (true)
                    {
                        Console.WriteLine("\n1.Add another number\n2.Exit");
                        string userAddOrExit = Console.ReadLine();
                        bool parsedUserOption = int.TryParse(userAddOrExit, out int menuNum);

                        if (!parsedUserOption || menuNum < 1 || menuNum > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nWrong input!!\nPlease select 1 or 2");
                            Console.ResetColor();
                            continue;
                        }
                        else if (menuNum == 1)
                        {
                            break;
                        }
                        else if (menuNum == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("\nAll your numbers:\n");
                            Console.WriteLine("Queue");
                            foreach (int num in intQueue)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(num);
                                Console.ResetColor();
                            }
                            Console.WriteLine("\nList");

                            Console.ForegroundColor = ConsoleColor.Green;
                            intList.ForEach(x => Console.WriteLine(x));
                            Console.ResetColor();

                            Console.WriteLine("\nStack");

                            Stack<int> reverseStack = new Stack<int>();
                            int[] stackArray = intStack.ToArray();

                            Console.ForegroundColor = ConsoleColor.Green;

                            for (int i = stackArray.Length-1; i >= 0; i--)
                            {
                                Console.WriteLine(stackArray[i]);
                            }

                            Console.ResetColor();

                            return;
                        }

                    }

                }
            }



        }
    }
}
