using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Ceo : Employee
    {
        public string[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharePrice { get; set; }

        public Ceo(string firstName, string lastName, double salary, string[] employees, int shares) : base(firstName, lastName, salary, RoleEnum.Ceo)
        {
            Employees = employees;
            Shares = shares;
         
        }
        public Ceo()
        {

        }
        public void AddSharesPrice(double number)
        {
            SharePrice = number;
        }
        public void PrintEmployees(string[] employees)
        {
           foreach (string worker in employees)
           {
                Console.WriteLine(worker);
           }
        }
        public override double GetSalary()
        {
            return base.GetSalary() + Shares * SharePrice;
        }
    }
}
