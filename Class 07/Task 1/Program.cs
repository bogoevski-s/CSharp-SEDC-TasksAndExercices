using System;
using Models;

namespace Task_1

{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee("Slave", "Bogoevski", 25000, RoleEnum.Other);

            SalesPerson newSalesPerson = new SalesPerson("Renata", "Bogoevska", 1.5);

            Manager newManager = new Manager("Ivana", "Bogoevska", 700);
            newManager.AddBonus(300);
            Console.WriteLine(newManager.GetSalary());

            newSalesPerson.AddSuccessRevenue(5.5);
            Console.WriteLine(newSalesPerson.GetSalary());
            Console.WriteLine(newSalesPerson.PrintInto());
            Console.WriteLine(newSalesPerson.GetSalary());
            //Console.WriteLine("Enter success ravenue:");

            //string succesRavenuAdd = Console.ReadLine();

            //double succesInt = double.Parse(succesRavenuAdd);
            //newSalesPerson.AddSuccessRevenue(succesInt);

            Console.WriteLine("");


            Console.WriteLine(newEmployee.GetSalary());
            Console.WriteLine(newEmployee.PrintInto());
        }
    }
}
