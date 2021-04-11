using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; } = new string[3];

        public User()
        {
        }
        public User(int id, string userName, string password)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Messages = new[]
            {
                $"{UserName}: Text message one",
                $"{UserName}: Text message Two",
                $"{UserName}: Text message Three"
            };
        }
   
    }
}
