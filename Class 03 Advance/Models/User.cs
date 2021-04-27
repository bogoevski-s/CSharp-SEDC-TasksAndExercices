using System;
using Models.Interfaces;
namespace Models
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(int id, string name, string userName, string password)
        {
            Id = id;
            Name = name;
            UserName = userName;
            Password = password;
        }

        virtual public void PrintUser()
        {
            Console.WriteLine($"ID: {Id}    Name: {Name}   Username: {UserName}");
        }

        //abstract public void PrintUser();


    }
}
