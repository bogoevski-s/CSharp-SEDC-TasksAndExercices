using System;
using System.Globalization;
using System.Text;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[]
            {
             new User(001, "slave", "12345"),
             new User(045, "bojan", "00123"),
             new User(156, "bob", "353535")
        };

            

            int arrayCounter = users.Length;
            while (true)
            {
                Console.WriteLine("\n1.Login\n2.Register\n3.Exit");
                string userInput = Console.ReadLine();
                bool userInputParsed = int.TryParse(userInput, out int userInputNum);
                if (!userInputParsed || userInputNum < 1 || userInputNum > 3)
                {
                    Console.WriteLine("\nWrong Input!! Please select 1. Login or 2. Register");
                    continue;
                }
                else if (userInputNum == 1)
                {
                    Console.WriteLine("\nPlease enter Username and Password to login\n");
                    Console.Write("Usename : ");
                    string userNameInput = Console.ReadLine();
                    Console.Write("Password : ");
                    string passwordInput = Console.ReadLine();
                    Login(userNameInput, passwordInput, users);

                    while (true)
                    {
                        Console.WriteLine("\n1.Return to main menu\n2.Exit");
                        string afterLogin = Console.ReadLine();
                        bool afterLoginParsed = int.TryParse(afterLogin, out int afterLoginNum);
                        if (!afterLoginParsed || afterLoginNum < 1 || afterLoginNum > 2)
                        {
                            Console.WriteLine("\nWrong input!! Please choose 1 or 2");
                            continue;
                        }
                        if (afterLoginNum == 1) break;
                        else if (afterLoginNum == 2) return;
                    }
                }
                else if (userInputNum == 2)
                {
                    Register(arrayCounter, users);
                    Console.WriteLine("\n1.Return to main menu\n2.View all users\n3.Exit");
                    string afterRegister = Console.ReadLine();
                    bool afterRegisterParsed = int.TryParse(afterRegister, out int afterRegisterNum);
                    if (!afterRegisterParsed)
                    {

                    }

                    if (afterRegisterNum == 1) continue;
                    else if (afterRegisterNum == 2)
                    {
                        ViewAll(users);
                        continue;
                    }
                    else if (afterRegisterNum == 3) break;
                }
                else if(userInputNum == 3) return;
            }
            
        }

        static void Login(string userName, string pass, User[] users)
        {
            foreach (User user in users)
            {
                if (userName.ToLower() == user.UserName.ToLower() && pass.ToLower() == user.Password.ToLower())
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n\nWellcome {user.UserName.ToUpper()} here are you messages :\n");
                    foreach(string message in user.Messages)
                    {
                        Console.WriteLine(message);
                    }
                    Console.ResetColor();
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($@"Sorry user ""{userName}"" not found!!");
                    Console.ResetColor();
                    return;
                }
            }
            
        }

        static void Register(int counter, User[] users)
        {
            counter++;

            while (true)
            {
                Console.Write("\nPlease enter ID: ");
                string registerId = Console.ReadLine();
                bool registerIdParsed = int.TryParse(registerId, out int newUserId);

                if (!registerIdParsed)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nId must be numeric value\n");
                    Console.ResetColor();
                    continue;
                }

                Console.Write("\nPlease enter username: ");
                string registerUserName = Console.ReadLine();
                Console.Write("\nPlease enter password: ");
                string registerPassword = Console.ReadLine();

                if(!CheckInputs(users, newUserId, registerUserName))
                {
                    continue;
                }
                CheckInputs(users, newUserId, registerUserName);

                User newUser = new User(newUserId, registerUserName, registerPassword);

                Array.Resize(ref users, counter);
                users[counter - 1] = newUser;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nUser successfuly created");
                Console.WriteLine("Registration complete!");
                Console.ResetColor();
                break;
            }
          
        }
        static bool CheckInputs(User[] users, int id, string userName)
        {
            foreach (User user in users)
            {
                if (userName == user.UserName)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($@"Sorry username ""{user.UserName}"" is already taken");
                    Console.ResetColor();
                    return false;
                }
                else if(id == user.Id)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($@"Sorry id ""{user.Id}"" is already taken");
                    Console.ResetColor();
                    return false;
                }
            }
            return true;
        }
        static void ViewAll(User[] users)
        {
            foreach (User user in users)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nID: {user.Id}\nUsername: {user.UserName}");

                foreach (string message in user.Messages)
                {
                    Console.WriteLine(message);
                }
                Console.ResetColor();
            }
        }
    }
}
