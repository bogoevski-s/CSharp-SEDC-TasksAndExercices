using System;

namespace Models
{
    public abstract class User
    {

        public string UserName { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }

        public User()
        {

        }
        public User(string userName, string email, string password)
        {
            UserName = userName;
            Email = email;
            Password = password;
        }
        public bool CheckPassword(string pass)
        {
            if (Password == pass)
            {
                return true;
            }
            return false;
        }
    }
}
