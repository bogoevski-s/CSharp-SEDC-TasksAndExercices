using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new[]
            {
                new Student("Slave", "Academy for programming", "G1"),
                new Student("Viktor", "Academy for design", "G7"),
                new Student("Igor", "AcAademy for programming", "G9"),
                new Student("Dejan", "Academy for Data Science", "G5"),
            };
            while (true)
            {
                Console.WriteLine("Enter your name:");
                string userInput = Console.ReadLine();

                foreach (Student student in students)
                {
                    if (userInput.ToLower() == student.Name.ToLower())
                    {
                        Console.WriteLine(student.UserInfo());
                        return;
                    }
                }
                Console.WriteLine("\nStudent not found\n");
            }
        }
    }
}
