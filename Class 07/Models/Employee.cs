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
            return $"First Name: {FirstName} |  Last Name: {LastName} |  Salary : {Salary}";
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
