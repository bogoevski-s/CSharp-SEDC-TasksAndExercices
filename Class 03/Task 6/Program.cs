using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesArray = new string[0];
            int counter = 0;

            while (true)
            {
                Console.WriteLine("Enter a name or N to exit");
                string userInput = Console.ReadLine();

                if (userInput == "n" || userInput == "N")
                {
                    foreach(string name in namesArray){
                        Console.Write(" " + name + " ");
                        //Console.Write(name);
                    }
                    break;
                }
                else
                {
                    counter++;
                    //Console.WriteLine("Enter name in the array:");
                    //string userInputName = Console.ReadLine();
                    Array.Resize(ref namesArray, counter);
                    namesArray[counter - 1] = userInput; 
                    //namesArray[counter] = userInputName;
                    

                }
            }
        }
    }
}
