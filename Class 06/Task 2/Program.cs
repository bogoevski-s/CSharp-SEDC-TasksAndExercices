using System;
using System.Globalization;
using System.Text;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[3];

            users[0] = new User(001, "slave", "12345");
            users[1] = new User(045, "nate", "00123");
            users[2] = new User(156, "MaraGram", "353535");

            Console.WriteLine("Please enter Username and Password to login");
            Console.Write("Usename : ");
            string userNameInput = Console.ReadLine();
            Console.Write("Password : ");
            string passwordInput = Console.ReadLine();
            Login(userNameInput, passwordInput, users);

        }
        static void Login(string userName, string pass, User[] users)
        {
            foreach (User user in users)
            {
                if (userName.ToLower() == user.UserName.ToLower() && pass.ToLower() == user.Password.ToLower())
                {
                    Console.WriteLine($"\n\nWellcome {user.UserName.ToUpper()} here are you messages :\n");
                    foreach(string message in user.Messages)
                    {
                        Console.WriteLine(message);
                    }
                    return;
                }
            }
            Console.WriteLine($@"Sorry user ""{userName}"" not found!!");
                
        }
    }
}
