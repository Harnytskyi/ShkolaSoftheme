using System;
using System.Collections.Generic;
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
            var acc1 = kyivstar.CreateAccount(1241);
            var acc2 = kyivstar.CreateAccount(2652);
            var acc3 = kyivstar.CreateAccount(3123);
            var acc4 = kyivstar.CreateAccount(4244);
            var acc5 = kyivstar.CreateAccount(5655);
            var acc6 = kyivstar.CreateAccount(6126);

            acc2.AddContact(acc1.Number, "First");
            acc1.Call(acc3.Number);

            acc6.AddContact(acc3.Number, "Third");
            acc3.AddContact(acc6.Number, "Sixth");

            acc1.Call(acc2.Number);
            acc2.Call(acc6.Number);
            acc4.Call(acc5.Number);
            acc3.Call(acc4.Number);
            acc4.Call(acc6.Number);
            acc3.Call(acc4.Number);
            acc6.Call(acc3.Number);
            acc3.Call(acc5.Number);
            acc5.Call(acc6.Number);

            Console.WriteLine();


            acc3.SendMessage(acc1.Number, "Hello");

            var numc = kyivstar.Get5MostCallingNumbers();
            Console.WriteLine("\n5 Most Calling Accounts: ");
            foreach(var n in numc)
            {
                Console.WriteLine(n);
            }
            var numa = kyivstar.Get5MostActiveNumbers();
            Console.WriteLine("\n5 Most Active Accounts: ");
            foreach (var n in numa)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
