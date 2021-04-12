using System;
using System.Text.RegularExpressions;
namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer newCustomer = new Customer("Slave", "Bogoevski", 1234, 11112222);
            Customer customer2 = new Customer("Renata", "Bogoevska", 5555, 098765, 500);

            Console.WriteLine(newCustomer.WellcomeMessage());
            Console.WriteLine();
            newCustomer.SetPin(9999);
            Console.WriteLine(customer2.CheckBalance());
            customer2.SetBalance(300);
            Console.WriteLine(customer2.CheckBalance());

            if (5555 == customer2.CheckPin()){
                Console.WriteLine($"Customer pin: {customer2.CheckPin()}");
            }

            Console.WriteLine($@"Enter you card number ""XXXX-XXXX-XXXX-XXXX"":");
            string cardNumber = Console.ReadLine();
            //bool cardNumParsed = long.TryParse(cardNumber, out long cardNumLong);

            //long carNumber = 1111222233334444;

            //String.Format("{0:0000-0000-0000-0000}", cardNumber);

            //string newNum = String.Format("{0:0000-0000-0000-0000}", cardNumLong);
            //Console.WriteLine(newNum);

            //Console.WriteLine($@"Enter you card number ""XXXX-XXXX-XXXX-XXXX"":");
            //string cardNumberInput = Console.ReadLine().Replace(" ", "");

            Regex reg = new Regex("\b4[0-9]{12}(?:[0-9]{3})?\b");
            var isMatch = reg.IsMatch(cardNumber);
            Console.WriteLine(isMatch);


        }
    }
}
