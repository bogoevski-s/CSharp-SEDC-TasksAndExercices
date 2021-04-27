using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces;

namespace Models
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }

        public Teacher(int id, string name, string userName, string password, string subject): base(id, name, userName, password)
        {
            Subject = subject;
        }
        public override void PrintUser()
        {
            Console.WriteLine($"{Subject}");
        }
    }
}
