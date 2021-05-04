using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Invoice
    {

        public CompanyEnum Company { get; set; }
        public int InvocieNumber { get; set; }
        public Client ClientName { get; set; }
        public int Amount { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DueDate { get; set; }
        public bool Payed { get; set; }
        public Invoice(CompanyEnum company, Client clientName, int amount, DateTime issueDate, bool payed)
        {
            Company = company;
            InvocieNumber = new Random().Next(10, 100);
            ClientName = clientName;
            Amount = amount;
            DateOfIssue = issueDate;
            DueDate = DateOfIssue.AddDays(30);
            Payed = payed;
        }
        public string InvoiceInfo()
        {
            return $"\nFrom : {Company} \nTo : {ClientName.UserName} \nDate of issue :{DueDate.ToString("MMM", CultureInfo.InvariantCulture)} {DateOfIssue.ToString("yyyy")} \nDue Date : {DueDate.ToString("dd/MM/yyyy")}\nAmount : {Amount} \nInvoice no. {InvocieNumber}\nStatus payed : {Payed}";
        }
    }
}
