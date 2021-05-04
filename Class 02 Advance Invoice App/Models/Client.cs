using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Client : User
    {
        private int Balance { get; set; }
        public RoleEnum UserStatus { get; set; }
        public List<Invoice> InvoicesList { get; set; }
        //public Invoice Invoice { get; set; }
        public Client(string userName, string email, string password, int balance, RoleEnum userStatus) : base (userName, email, password)
        {
            Balance = balance;
            UserStatus = userStatus;
            InvoicesList = new List<Invoice>();
        }
        //public void AddInvoice(Invoice newInvoice)
        //{
        //    InvoicesList.Add(newInvoice);
            
        //}

        public int CheckBalance()
        {
            return Balance;
        }
        public int AddBalance(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                throw new Exception("Cant add negative numbers");
            }
            return Balance;
        }
        public int PayInvoice(int invoiceNum)
        {
            Invoice invoicePay = InvoicesList.FirstOrDefault(x => x.InvocieNumber == invoiceNum);
            if(Balance >= invoicePay.Amount)
            {
                Balance -= invoicePay.Amount;
                invoicePay.Payed = true;
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
            
            return Balance;
        }
        public void AllInvoices()
        {
            foreach (Invoice invoices in InvoicesList)
            {
                Console.WriteLine(invoices.InvoiceInfo());
            }
        }



    }
}
