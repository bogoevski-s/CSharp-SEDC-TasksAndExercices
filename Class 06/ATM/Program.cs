using System;
using System.Text.RegularExpressions;
namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer[] customers = new Customer[]
            {
                new Customer("Slave", "Bogoevski", 1234, 4111222233334444, 1500),
                new Customer("Renata", "Bogoevska", 5555, 1111222233334444, 500)
            };

            //newCustomer.SetPin(9999);
            //Console.WriteLine(customer2.CheckBalance());

            //Console.WriteLine("Enter amount to withdrawal:");

            //string cashWithdrawal = Console.ReadLine();
            //bool cashWithdrawlParsed = int.TryParse(cashWithdrawal, out int withdrawalNum);

            //customer2.Cashwithdrawal(withdrawalNum);

            //if (customer2.Cashwithdrawal(withdrawalNum) == -1)
            //{
            //    Console.WriteLine("Not enough money");
            //}
            //else
            //{
            //    Console.WriteLine("After cashwithdraw");
            //    Console.WriteLine($"{customer2.CheckBalance()}$");
            //}

            //Console.WriteLine("Enter amount to deposit:");

            //string deposit = Console.ReadLine();
            //bool depositParsed = int.TryParse(deposit, out int depositInt);
            //customer2.CashDeposit(depositInt);
            //Console.WriteLine("After deposit");
            //Console.WriteLine($"{customer2.CheckBalance()}$");

                Console.WriteLine($@"Enter you card number ""XXXX-XXXX-XXXX-XXXX"":");
                string cardNumber = Console.ReadLine();
                string cardNumberFinal = "";

                Console.WriteLine("Enter pin");
                string userPinInput = Console.ReadLine();
                bool pinParsed = int.TryParse(userPinInput, out int pinNumber);

                if (cardNumber.Contains("-"))
                {
                    cardNumberFinal = cardNumber.Replace("-", "").Trim();
                }
                else if (cardNumber.Contains(" "))
                {
                    cardNumberFinal = cardNumber.Replace(" ", "").Trim();
                }
                else
                {
                    cardNumberFinal = cardNumber;
                }

                bool credtCardParsed = long.TryParse(cardNumberFinal, out long creditCardInt);

                if (!credtCardParsed)
                {
                    Console.WriteLine("\nWrong input | Please use numbers\nEnter 16 digit number from your card\n");
             
                }
                
                if(CreditCardCheck(creditCardInt, pinNumber, customers))
                {
                    Console.WriteLine("1.Balance checking\n2.Cash withdrawal\n2.Cash deposition");
                }
                else
                {
                    Console.WriteLine("Please try again");
                }

                
                
            
            




            static bool CreditCardCheck(long cardNumber, int pin, Customer[] customers)
            {
                foreach(Customer customer in customers)
                {
                    if(cardNumber == customer.CardNumber)
                    {
                        if(PinCheck(pin, customer))
                        {
                            return true;
                        }
                    }
                    
                }
                Console.WriteLine("Wrong Credit Card Number!!");
                return false;
            }

            static bool PinCheck(int pin, Customer customer)
            {

                if (pin == customer.CheckPin())
                {

                    Console.WriteLine($"Correct pin \u221A");
                    Console.WriteLine(customer.WellcomeMessage());
                    return true;
                }

                Console.WriteLine("Wrong pin input!!");
                return false;
            }




            static bool CreditCardCreate(string cardNumber, Customer[] customers)
            {
                string pat = "^4[0-9]{12}(?:[0-9]{3})?$";
                string pat2 = @"\b\d{13,16}\b";

                Regex r = new Regex(pat2, RegexOptions.IgnoreCase);

                //string cardNumberFinal = "";

                //foreach(Customer customer in customers)
                //{
                //    if (cardNumber.Contains("-"))
                //    {
                //        cardNumberFinal = cardNumber.Replace("-", "");
                //        Console.WriteLine(r.IsMatch(cardNumberFinal));
                //        return r.IsMatch(cardNumberFinal);
                //    }
                //    else if (cardNumber.Contains(" "))
                //    {
                //        cardNumberFinal = cardNumber.Replace(" ", "").Trim();
                //        Console.WriteLine(r.IsMatch(cardNumberFinal));
                //        return r.IsMatch(cardNumberFinal);
                //    }
                //    else
                //    {
                //        Console.WriteLine(r.IsMatch(cardNumber));
                //        return r.IsMatch(cardNumberFinal);
                //    }
                //}
                Console.WriteLine(r.IsMatch(cardNumber));
                return r.IsMatch(cardNumber);

            }
        }
    }
}
