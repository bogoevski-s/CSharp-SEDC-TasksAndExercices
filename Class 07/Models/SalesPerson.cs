using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName, double saleRevenue) : base(firstName,  lastName,  500, RoleEnum.Sales)
        {
            SuccessSaleRevenue = saleRevenue;
        }
        public SalesPerson()
        {

        }
        public void AddSuccessRevenue(double number)
        {
            SuccessSaleRevenue = number;
        }
        public override double GetSalary()
        {
            double bonus = 0;

            if((Salary * SuccessSaleRevenue) <= 200)
            {
                bonus = 500;
            }
            else if((Salary * SuccessSaleRevenue) > 2000 || (Salary * SuccessSaleRevenue) <= 2000)
            {
                bonus = 1000;
            }
            else if((Salary * SuccessSaleRevenue) > 5000)
            {
                bonus = 1500;
            }
            return Salary + bonus;
        }
    }

}
