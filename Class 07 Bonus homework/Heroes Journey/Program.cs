using System;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Heroes_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Users> allUsers = new List<Users>
            {
                new Users("SlaveBo", "slave.bogoevski@yahoo.com", "123"),
                new Users("RenataNate","nate123@gmail.com", "reni3103")
            };

            while (true)
            {
                Console.WriteLine("Enter you email and password");
                Console.Write("Email: ");
                string userEmail = Console.ReadLine();
                Console.Write("password: ");
                string userPass = Console.ReadLine();

                Login(allUsers, userEmail, userPass);
            }



        }
        static void Login(List<Users> users, string email, string pass)
        {
            if (email.Length == 0 || pass.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nFields must not be empty\n");
                Console.ResetColor();
                return;
            }
            else if (!email.Contains("@") || !email.Contains(".com"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($@"Wrong email input you're missing @ or "".com"" ");
                Console.ResetColor();
                return;
            }
 
            Users loginUser = users.FirstOrDefault(x => x.Email == email);

            if(loginUser != null)
            {
                if (loginUser.CheckPassword(pass))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nWelcome {loginUser.UserName}\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWrong password!!!\n");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nUser email not found\n");
                Console.ResetColor();
            }

        }
    }
}
