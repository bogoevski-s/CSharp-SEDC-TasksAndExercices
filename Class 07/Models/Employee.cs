using System;

namespace Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }

        public Enum Role { get; set; }

        public Employee()
        {

        }
        public Employee(string firstName, string lastName, double salary, Enum role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = role;
        }
        public string PrintInto()
        {
            return $"{FirstName} {LastName} - {GetSalary()}";
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
