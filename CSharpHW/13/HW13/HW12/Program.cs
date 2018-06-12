using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class Program
    {
        static Authenticator authenticator = new Authenticator();
        public static UserDataBase userdatabase = new UserDataBase();
        static void Main(string[] args)
        {
            
            while (true)
            {
                Run();
                userdatabase.GetList(false);
                
            }
            
            
        }
        static void Run()
        {
            string nameOrEmail;
            string password = String.Empty; ;
            bool nameGiven = true;
            Console.WriteLine("Input Name or Email:");
            Console.ForegroundColor = ConsoleColor.White;
            string nameOrEmailInput = Console.ReadLine();
            Console.ResetColor();
            if (nameOrEmailInput == "exit")
                Environment.Exit(0);
            else if (nameOrEmailInput.Contains("@"))
            {
                nameGiven = false;
            }
            nameOrEmail = nameOrEmailInput;
            Console.WriteLine("Enter password");
            Console.ForegroundColor = ConsoleColor.White;
            string passwordInput = Console.ReadLine();
            Console.ResetColor();
            if (passwordInput == "exit")
                Environment.Exit(0);
            else
            {
                password = passwordInput;
            }
            var user = new User(nameOrEmail, password, nameGiven);
            if (authenticator.Authentic(user, userdatabase) == false)
                userdatabase.AddUser(user);
        }
    }
}
