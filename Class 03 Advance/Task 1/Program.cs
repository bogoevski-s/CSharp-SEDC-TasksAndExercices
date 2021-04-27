using System;
using Models;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student(23, "Slave", "BobBobsky", "slave123",new List<int> { 5,3,4,5,5});
            Student newStudent2 = new Student(1, "Bucky", "Bucky-Roberts-Junior", "BukyRoberts", new List<int> {1, 1, 2, 1, 1 });
            Teacher newTeacher = new Teacher(001, "Risto", "RistoSEDC", "risto123", "CSharp");
            Teacher newTeacher2 = new Teacher(002, "Bob", "Bobsky", "BoBo", "Advance JS");


            Console.WriteLine("Grades student 1");
            newStudent.PrintUser();
            Console.WriteLine("\n");
            Console.WriteLine("Grades student 2");
            newStudent2.PrintUser();
            Console.WriteLine("\n");
            newTeacher.PrintUser();
            newTeacher2.PrintUser();
            




        }
    }
}
