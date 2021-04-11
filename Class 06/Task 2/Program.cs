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

            int arrayCounter = users.Length;

            Console.WriteLine("1.Login\n2.Register");
            string userInput = Console.ReadLine();
            bool userInputParsed = int.TryParse(userInput, out int userInputNum);
            if (!userInputParsed || userInputNum < 1 || userInputNum > 2) 
            {   
                Console.WriteLine("Wrong Input!! Please select 1. Login or 2. Register");
            }
            else if(userInputNum == 1)
            {
                Console.WriteLine("\nPlease enter Username and Password to login");
                Console.Write("Usename : ");
                string userNameInput = Console.ReadLine();
                Console.Write("Password : ");
                string passwordInput = Console.ReadLine();
                Login(userNameInput, passwordInput, users);
            }
            else if(userInputNum == 2)
            {
                Register(arrayCounter, users);
            }
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

        static void Register(int counter, User[] users)
        {
            counter++;

            while (true)
            {
                Console.Write("Please enter ID: ");
                string registerId = Console.ReadLine();
                bool registerIdParsed = int.TryParse(registerId, out int newUserId);

                if (!registerIdParsed)
                {
                    Console.WriteLine("Id must be numeric value");
                    continue;
                }

                Console.Write("Please enter username: ");
                string registerUserName = Console.ReadLine();
                Console.Write("Please enter password: ");
                string registerPassword = Console.ReadLine();

                CheckInputs(users, newUserId, registerUserName);

                User newUser = new User(newUserId, registerUserName, registerPassword);

                Array.Resize(ref users, counter);
                users[counter - 1] = newUser;

                Console.WriteLine("User successfuly created");
                Console.WriteLine("Registration complete!");
                break;
            }
            
        }
        static void CheckInputs(User[] users, int id, string userName)
        {
            foreach (User user in users)
            {
                if(userName == user.UserName)
                {
                    Console.WriteLine($@"Sorry username ""{user.UserName}"" is already taken");
                }
                if (id == user.Id)
                {
                    Console.WriteLine($@"Sorry id ""{user.Id}"" is already taken");
                }
            }
        }
    }
}
