using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largest number\n\n");
            Console.WriteLine("Enter 4 numbers\n");
            string numberOne = Console.ReadLine();
            string numberTwo = Console.ReadLine();
            string numberThree = Console.ReadLine();
            string numberFour = Console.ReadLine();

            bool firstNumParsed = int.TryParse(numberOne, out int numOne);
            bool secondNumParsed = int.TryParse(numberTwo, out int numTwo);
            bool thirdNumParsed = int.TryParse(numberThree, out int numThree);
            bool fourthNumParsed = int.TryParse(numberFour, out int numFour);

            if (firstNumParsed && secondNumParsed && thirdNumParsed && fourthNumParsed)
            {
                int[] numArr = new int[4];
                numArr[0] = numOne;
                numArr[1] = numTwo;
                numArr[2] = numThree;
                numArr[3] = numFour;
                Array.Sort(numArr);
                Console.WriteLine("\n\n");
                Console.WriteLine("Largest number is : " + numArr[3]);
            }
            else
            {
                Console.WriteLine("\nNot a valid number!!");
            }


            //Finding largest number with loop 

            //int[] numArr = new int[4];
            //numArr[0] = numOne;
            //numArr[1] = numTwo;
            //numArr[2] = numThree;
            //numArr[3] = numFour;

            //int max = Int32.MinValue;

            //for (int i = 0; i < numArr.Length; i++)
            //{
            //    if(numArr[i] > max)
            //    {
            //        max = numArr[i];
            //    }
            //}
            //Console.WriteLine("\n" + max);

        }
    }
}
