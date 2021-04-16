using System;
using Models;

namespace Task_1

{
    class Program
    {
        static void Main(string[] args)
        {

            Contractor contractor1 = new Contractor("Risto", "Pancevski", 2000, 415, 30);
            Contractor contractor2 = new Contractor("Bob", "Bobsky", 1500, 40, 20);
            Manager manager1 = new Manager("Bucky", "Roberts", 1000, "Construction");
            Manager manager2 = new Manager("Adis", "Drndar", 900, "Realestate");
            SalesPerson sallesPerson1 = new SalesPerson("Billy", "TheKid", 2.5);

            contractor1.SetManager(manager1);
            contractor2.SetManager(manager2);

            string[] allEmployes = 
            {
                "Bob Bobert",
                "Rick Rickert",
                "Mona Monalisa",
                "Igor Igorsky",
                "Lea Leova"
            };
            Ceo newCeo = new Ceo("Slave", "Bogoevski", 2000, allEmployes, 300);
            newCeo.AddSharesPrice(40);

            Console.WriteLine(newCeo.PrintInto());
            Console.WriteLine($"\nSalary of the CEO: {newCeo.GetSalary()}\n");
            newCeo.PrintEmployees(allEmployes);
        }
    }

}
