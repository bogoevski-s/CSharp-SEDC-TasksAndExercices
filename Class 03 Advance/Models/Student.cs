using System;
using System.Collections.Generic;
using System.Linq;
using Models.Interfaces;

namespace Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public Student(int id, string name, string userName, string password, List<int> grades) : base(id, name, userName, password)
        {
            Grades = grades;
        }

        public override void PrintUser()
        {
            foreach (int grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
