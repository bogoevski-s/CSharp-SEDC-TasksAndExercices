using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int Pin { get; set; }
        public long CardNumber { get; set; }
        private int Balance { get; set; }

        public Customer()
        {

        }
        public Customer(string firstName, string lastName, int pin, long cardNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Pin = pin;
            CardNumber = cardNumber;
        }

        public Customer(string firstName, string lastName, int pin, long cardNumber, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            Pin = pin;
            CardNumber = cardNumber;
            Balance = balance;
        }
        public string WellcomeMessage()
        {
           return $"Welcome {FirstName} {LastName}";
        }
        public void SetPin(int pin)
        {
            Pin = pin;
        }
        public int CheckPin()
        {
            return Pin;
        }

        public void SetBalance(int balance)
        {
            Balance = balance;
        }
        public int CheckBalance()
        {
            return Balance;
        }
        public int Cashwithdrawal(int cash)
        {
            if (Balance >= cash)
            {
                Balance -= cash;
                return Balance;
            }
            else
            {
                return -1;
            }
        }
        public void CashDeposit(int amount)
        {
            Balance += amount;
        }
    }
}
