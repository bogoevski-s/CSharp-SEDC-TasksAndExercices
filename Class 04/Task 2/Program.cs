using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Slave";
            string surname = "Bogoevski";
            string fullname = $"Hello {name} {surname}";
            Console.WriteLine(fullname);

            string fristStatement = $"Check you c:\\ drive";
            Console.WriteLine(fristStatement);

            string secondStatement = $"We will have \"fair\" elections";
            Console.WriteLine(secondStatement);

            string thirsdStatement = $"The \\n sign means: new line";
            Console.WriteLine(thirsdStatement);


            string statement1 = @"Check your c:\ drive";
            Console.WriteLine(statement1);

            string statement2 = @"We will have ""fair"" elections";
            Console.WriteLine(statement2);

            string statement3 = @"The \\n sign means: new line";
            Console.WriteLine(statement3);


        }
    }
}
