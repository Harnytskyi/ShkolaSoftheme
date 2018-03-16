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

            acc2.AddContact(acc1.Number, "First", "Contact");
            acc1.Call(acc2.Number);
            Console.WriteLine("start my try");
            acc3.Call(1234565656);
            Console.WriteLine("finish my try");
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
            foreach(var n in nums)
            {
                Console.WriteLine(n);
            }
            kyivstar.Get5MostActiveNumbers();
            Console.ReadLine();
        }
    }
}
