using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Admin : User
    {
        public CompanyEnum Company { get; set; }

        public Admin(string userName, string email, string password, CompanyEnum company) : base(userName, email, password)
        {
            Company = company;
        }
    }
}
