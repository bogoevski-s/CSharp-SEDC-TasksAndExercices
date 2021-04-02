using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Group\n\n");
            string[] studentsG1 = new string[] { "Slave", "Aleksandar", "Goran", "Vlatko", "Bob" };
            string[] studentsG2 = new string[] { "Bucky", "Justin", "Robert", "David", "Chris" };

            while (true)
            {
                Console.WriteLine("Please choose 1 for students from G1 or 2 for students from G2\nOr press x to exit");
                string userInput = Console.ReadLine();
                bool userInputParsedNum = int.TryParse(userInput, out int num);

                if (userInput == "x" || userInput == "X") break;

                else if (!userInputParsedNum)
                {
                    Console.WriteLine("Wrong input!!");
                    continue;
                }
                else
                {
                    if (num == 1) PrintStudents(studentsG1);
                    else PrintStudents(studentsG2);
                }
            }
        }
        static void PrintStudents(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
