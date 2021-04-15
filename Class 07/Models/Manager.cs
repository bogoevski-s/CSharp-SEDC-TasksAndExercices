using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public Manager()
        {

        }
        public Manager(string firstName, string lastName, double salary) : base (firstName, lastName, salary, RoleEnum.Manager)
        {

        }
        public void AddBonus(double bonusNumber)
        {
            Bonus += bonusNumber;
        }
        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }
    }
}
