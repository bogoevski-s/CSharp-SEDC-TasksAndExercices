using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Invoice_App
{
    class Program
    {
        static void Main(string[] args)
        {
           //datetime how to show year and month only
            DateTime date2 = new DateTime(2021, 05, 02);
            string  monthName = date2.ToString("MMM", CultureInfo.InvariantCulture);

            Console.WriteLine($"{date2.Year} {monthName}");

            Client newUser = new Client("SlaveB", "slave@gmail.com", "123", 2000, RoleEnum.Client);
            Client newClient = new Client("Renata", "reni@gmail.com", "444", 8800, RoleEnum.Client);

            Admin newAdmin = new Admin("Risto", "Pancevski", "123", CompanyEnum.Telekom);

            //Invoice newInvoice = new Invoice(CompanyEnum.Evn, 012, newUser, 5500, new DateTime(2021, 05, 30), false);

            List<Invoice> invoiceList = new List<Invoice>
            {
                new Invoice(CompanyEnum.Telekom,  newUser, 990, new DateTime(2021,05,30), false),
                new Invoice(CompanyEnum.Evn, newClient, 5500, new DateTime(2021,05,30), false),
                new Invoice(CompanyEnum.Vodovod, newUser, 350, new DateTime(2021,05,30), false)
            };
            Console.WriteLine("Balance");
            Console.WriteLine(newUser.CheckBalance());

            Invoice newInvoice = new Invoice(CompanyEnum.Beg, newUser, 3800, new DateTime(2021, 05, 30), false);

            invoiceList.Add(newInvoice);

            //how to add invoices into client's list of invoices
            foreach (Invoice invoices in invoiceList)
            {
                if(invoices.ClientName.UserName == newUser.UserName)
                {
                    newUser.InvoicesList.Add(invoices);
                    Console.WriteLine(invoices.InvoiceInfo()); 
                }
            }
            Console.WriteLine("Enter invoice number to pay the invoice bill");
            string invoiceNumInput = Console.ReadLine();
            bool successParse = int.TryParse(invoiceNumInput, out int invoiceNumPay);
            if (!successParse)
            {
                Console.WriteLine("wrong input");
            }

            newUser.PayInvoice(invoiceNumPay);

            newUser.AllInvoices();

            Console.WriteLine("\nBalance");
            Console.WriteLine(newUser.CheckBalance());

            newUser.AddBalance(2000);
            Console.WriteLine("\nBalance after deposit");
            Console.WriteLine(newUser.CheckBalance());
        }
    }
}
