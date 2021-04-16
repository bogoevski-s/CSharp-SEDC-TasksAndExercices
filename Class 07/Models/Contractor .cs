using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, double salary, double workHours, int payPerHour) : base(firstName, lastName, salary, RoleEnum.Contractor)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = null;
        }
        public override double GetSalary()
        {
            double contractorSalary = base.GetSalary() * PayPerHour;
            Salary = contractorSalary;
            return contractorSalary;
        }
        public string CurrentPosition()
        {
            return $"Department: {Responsible.Department}";
        }
        public Manager SetManager(Manager responsibleManager)
        {
            Responsible = responsibleManager;
            return responsibleManager;
        }
    }
}
