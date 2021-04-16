using System;
using Models;

namespace Task_1

{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee newEmployee = new Employee("Slave", "Bogoevski", 25000, RoleEnum.Other);

            //Console.WriteLine(newEmployee.GetSalary());
            //Console.WriteLine(newEmployee.PrintInto());


            //Console.WriteLine("\n\n");
            //SalesPerson newSalesPerson = new SalesPerson("Renata", "Bogoevska", 1.5);

            //newSalesPerson.AddSuccessRevenue(5.5);
            //Console.WriteLine(newSalesPerson.GetSalary());
            //Console.WriteLine(newSalesPerson.PrintInto());
            //Console.WriteLine(newSalesPerson.GetSalary());

            //Console.WriteLine("\n\n");
            //Manager newManager = new Manager("Ivana", "Bogoevska", 700, "Realestate");

            //newManager.AddBonus(300);
            //Console.WriteLine(newManager.GetSalary());
            //Console.WriteLine(newManager.PrintInto());
            //Console.WriteLine(newManager.GetSalary());

            //Console.WriteLine("\n\n");
            //Contractor newContractor = new Contractor("Marija", "Mestrovic", 700, 40.5, 20, newManager);

            //Console.WriteLine(newContractor.GetSalary());
            //Console.WriteLine(newContractor.PrintInto());
            //Console.WriteLine(newContractor.Responsible.FirstName);
            //Console.WriteLine(newContractor.CurrentPosition());

            //Console.WriteLine("Enter success ravenue:");

            //string succesRavenuAdd = Console.ReadLine();

            //double succesInt = double.Parse(succesRavenuAdd);
            //newSalesPerson.AddSuccessRevenue(succesInt);

            //Console.WriteLine("\n\n");

            //object[] company = new object[]
            //{
            //    new Contractor("Risto", "Pancevski", 2000, 415, 30),
            //    new Contractor("Bob", "Bobsky", 1500, 40, 20),
            //    new Manager("Bucky", "Roberts", 1000, "Construction"),
            //    new Manager("Adis", "Drndar", 900, "Realestate"),
            //    new SalesPerson("Billy", "TheKid", 2.5),
            //};

            //foreach(object firm in company)
            //{
            //    Console.WriteLine();
            //}
            //Console.WriteLine();


            Contractor contractor1 = new Contractor("Risto", "Pancevski", 2000, 415, 30);
            Contractor contractor2 = new Contractor("Bob", "Bobsky", 1500, 40, 20);
            Manager manager1 = new Manager("Bucky", "Roberts", 1000, "Construction");
            Manager manager2 = new Manager("Adis", "Drndar", 900, "Realestate");
            SalesPerson sallesPerson1 = new SalesPerson("Billy", "TheKid", 2.5);

            contractor1.SetManager(manager1);
            contractor2.SetManager(manager2);

        }
    }

}
