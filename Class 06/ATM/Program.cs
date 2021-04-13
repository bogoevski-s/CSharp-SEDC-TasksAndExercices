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
                new Customer("Risto", "Pancevski", 1234, 4111222233334444, 1500),
                new Customer("Adis", "Drindar", 5555, 1111222233334444, 500)
            };
            int newCustomerCount = customers.Length;
            while (true)
            {
                Console.WriteLine("\nATM\n");
                Console.WriteLine("\n1.Login\n2.Create new account\n3.Exit");

                string menuInput = Console.ReadLine();
                bool menuINputParsed = int.TryParse(menuInput, out int menuInputNum);

                if (!menuINputParsed || menuInputNum > 3 || menuInputNum < 1)
                {
                    Console.WriteLine("Wrong input!! Please choose 1 - 3");
                }
                else if (menuInputNum == 2)
                {
                    Console.WriteLine("Please enter your first name:");
                    string fistName = Console.ReadLine();
                    Console.WriteLine("Please enter your last name:");
                    string lastName = Console.ReadLine();
                    int newPinNumber;
                    while (true)
                    {
                        Console.WriteLine("Enter your new pin :");
                        string pinCreate = Console.ReadLine();
                        bool pinCreateParsed = int.TryParse(pinCreate, out int pinCreateInt);
                        if (!pinCreateParsed || pinCreate.Length > 4 || pinCreate.Length < 4)
                        {
                            Console.WriteLine("Wrong input!!! Pin must be 4 digits");
                            continue;
                        }
                        else
                        {
                            newPinNumber = pinCreateInt;
                            break;
                        }
                    }

                    newCustomerCount++;

                    long longInt = 4111411141114111;
                    longInt += 19;

                    Customer newCustomer = new Customer(fistName, lastName, newPinNumber, longInt, 0);

                    Array.Resize(ref customers, newCustomerCount);
                    customers[newCustomerCount - 1] = newCustomer;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nNew user created \u221A");
                    Console.ResetColor();

                    Console.WriteLine($"\nWelcome {fistName} to ATM app\n");
                    Console.WriteLine($@"Your credit card number is ""{longInt}""");

                    continue;
                }

                else if (menuInputNum == 1)
                {
                    Console.WriteLine($@"Enter you card number ""XXXX-XXXX-XXXX-XXXX"":");
                    string cardNumber = Console.ReadLine();

                    Console.WriteLine("\nEnter pin");
                    string userPinInput = Console.ReadLine();
                    bool pinParsed = int.TryParse(userPinInput, out int pinNumber);

                    long creditCardLong = CardConvert(cardNumber);

                    if (CreditCardCheck(creditCardLong, pinNumber, customers)) ;
                    else
                    {
                        Console.WriteLine("\nPlease try again");
                        continue;
                    }

                }
                else
                {
                    break;
                }
            }

            static long CardConvert(string cardNumber)
            {
                string cardNumberFinal = "";
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
                return creditCardInt;
            }

            static void Menu(Customer customer)
            {
                while (true)
                {
                    Console.WriteLine("\n1.Balance checking\n2.Cash withdrawal\n3.Cash deposition\n");
                    string customerInput = Console.ReadLine();
                    bool customerInputParsed = int.TryParse(customerInput, out int customerInputInt);
                    if (!customerInputParsed || customerInputInt > 3 || customerInputInt < 0)
                    {
                        Console.WriteLine("\nWrong input\nPlease choose numric value from 1 - 3 ");
                        continue;
                    }
                    if (customerInputInt == 1)
                    {
                        Console.WriteLine($"\nYou have {customer.CheckBalance()}$ on your account");
                        Console.WriteLine("Do you want another transaction? Y / N");
                        string anotherTransaction = Console.ReadLine();

                        if (anotherTransaction == "y" || anotherTransaction == "Y")
                        {
                            continue;
                        }
                        else if (anotherTransaction == "N" || anotherTransaction == "n")
                        {
                            Console.WriteLine("\nThank you for using the ATM app");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong input!!!");
                            break;
                        }
                    }
                    else if (customerInputInt == 2)
                    {
                        Console.WriteLine("\nEnter amount to withdrawal:");

                        string cashWithdrawal = Console.ReadLine();
                        bool cashWithdrawlParsed = int.TryParse(cashWithdrawal, out int withdrawalNum);

                        if (customer.Cashwithdrawal(withdrawalNum) == -1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNot enough money\n");
                            Console.ResetColor();
                            break;
                        }
                        customer.Cashwithdrawal(withdrawalNum);

                        Console.WriteLine($"\nYou withdrew {withdrawalNum}$.You have {customer.CheckBalance()}$ left on your account");
                        Console.WriteLine("\nThank you for using the ATM app");
                    }
                    else if (customerInputInt == 3)
                    {
                        Console.WriteLine("\nEnter amount to deposit:");
                        string deposit = Console.ReadLine();
                        bool depositParsed = int.TryParse(deposit, out int depositInt);

                        customer.CashDeposit(depositInt);

                        Console.WriteLine($"\nYou deposit {depositInt}$.You have {customer.CheckBalance()}$ left on your account");
                        Console.WriteLine("\nThank you for using the ATM app");

                    }
                }
            }

            static bool CreditCardCheck(long cardNumber, int pin, Customer[] customers)
            {
                foreach (Customer customer in customers)
                {
                    if (cardNumber == customer.CardNumber)
                    {
                        if (PinCheck(pin, customer))
                        {
                            Menu(customer);
                            return true;
                        }
                    }

                }
                Console.WriteLine("\nWrong Credit Card Number!!");
                return false;
            }

            static bool PinCheck(int pin, Customer customer)
            {

                if (pin == customer.CheckPin())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nCorrect pin \u221A");
                    Console.ResetColor();
                    Console.WriteLine($"\n{customer.WellcomeMessage()}");
                    return true;
                }

                Console.WriteLine("\nWrong pin input!!");
                return false;
            }

            static bool CreditCardCreate(string cardNumber, Customer[] customers)
            {
                //string pat = "^4[0-9]{12}(?:[0-9]{3})?$";
                string pat2 = @"\b\d{13,16}\b";

                Regex r = new Regex(pat2, RegexOptions.IgnoreCase);

                Console.WriteLine(r.IsMatch(cardNumber));
                return r.IsMatch(cardNumber);
            }
        }
    }
}
