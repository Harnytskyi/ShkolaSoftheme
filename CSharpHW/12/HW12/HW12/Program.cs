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
        static void Main(string[] args)
        {
            while(true)
            {
                Run();
                authenticator.PrintUsers();
            }
        }
        static void Run()
        {
            string nameOrEmail;
            string password = String.Empty; ;
            bool nameGiven = true;
            Console.WriteLine("Input Name or Email:");
            string nameOrEmailInput = Console.ReadLine();
            if (nameOrEmailInput == "exit")
                Environment.Exit(0);
            else if (nameOrEmailInput.Contains("@"))
            {
                nameGiven = false;
            }
            nameOrEmail = nameOrEmailInput;
            Console.WriteLine("Enter password");
            string passwordInput = Console.ReadLine();
            if (passwordInput == "exit")
                Environment.Exit(0);
            else
            {
                password = passwordInput;
            }
            var user = new User(nameOrEmail, password, nameGiven);
            if (authenticator.Authentic(user) == false)
                authenticator.AddUser(user);
        }
    }
}
