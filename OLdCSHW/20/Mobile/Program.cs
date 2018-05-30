using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Andrii");
            Console.ResetColor();

            MobileOperator kyivstar = new MobileOperator();
            var acc1 = kyivstar.CreateAccount(1241, "Adam", "Levin", new DateTime(1998, 6, 23), "adam@marron.com");
            Validate(acc1);
            var acc2 = kyivstar.CreateAccount(2652, "Paul", "Graph", new DateTime(1985, 4, 7), "paul@mail.com");
            Validate(acc2);
            var acc3 = kyivstar.CreateAccount(3123, "Carl", "Monic", new DateTime(1988, 6, 27), "armron.com");
            Validate(acc3);
            var acc4 = kyivstar.CreateAccount(4244, "Jam", "Seric", new DateTime(1969, 8, 7), "qwam@nord.uk");
            Validate(acc4);
            var acc5 = kyivstar.CreateAccount(5655, "Resida", "Wist", new DateTime(1978, 10, 7), "aqw@mn.com");
            Validate(acc5);
            var acc6 = kyivstar.CreateAccount(6126, "Wenda", "Room", new DateTime(1987, 1, 17), "adam@marron.com");
            Validate(acc6);
            Console.WriteLine();
            acc2.AddContact(acc1.Number, "First", "Contact");
            acc1.Call(acc2.Number);
            Console.WriteLine();

            acc1.Call(acc2.Number);
            acc2.Call(acc6.Number);
            acc3.Call(acc4.Number);
            acc4.Call(acc5.Number);
            acc5.Call(acc1.Number);
            acc4.Call(acc6.Number);

            acc3.Call(acc4.Number);
            acc4.Call(acc6.Number);
            acc3.Call(acc4.Number);
            acc6.Call(acc2.Number);
            acc5.Call(acc1.Number);
            acc5.Call(acc6.Number);


            acc1.AddContact(acc3.Number, "Third", "Contact");
            acc3.SendMessage(acc1.Number, "Hello");

            var nums = kyivstar.Get5MostCallingNumbers();
            Console.WriteLine("\n5 Most Calling Accounts: ");
            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }
            kyivstar.Get5MostCallingNumbers();

            var dums = kyivstar.Get5MostActiveNumbers();
            Console.WriteLine("\n5 Most Active Accounts: ");
            foreach (var n in dums)
            {
                Console.WriteLine(n);
            }
            kyivstar.Get5MostActiveNumbers();
            Console.ReadLine();
            
        }
        private static void Validate(MobileAccount mobileAccount)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(mobileAccount);
            if (!Validator.TryValidateObject(mobileAccount, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Account '{0}' is Valid", mobileAccount.FirstName, mobileAccount.LastName);
            }
        }

    }
}
