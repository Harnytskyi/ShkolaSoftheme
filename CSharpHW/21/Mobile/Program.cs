using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MobileOperator kyivstar = new MobileOperator();
            var acc1 = kyivstar.CreateAccount(0930575259);
            var acc2 = kyivstar.CreateAccount(1234565656);
            var acc3 = kyivstar.CreateAccount(0930575258);
            var acc4 = kyivstar.CreateAccount(23423423);
            var acc5 = kyivstar.CreateAccount(234234234);
            var acc6 = kyivstar.CreateAccount(234423432);
            var acc7 = kyivstar.CreateAccount(234234);
            var acc8 = kyivstar.CreateAccount(12312332);
            var acc9 = kyivstar.CreateAccount(123123243);
            var acc10 = kyivstar.CreateAccount(324234324);


            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            for (int i = 0; i < 10; i++)
            {
                kyivstar.BinarySerialize();
            }
            stopWatch.Stop();
            Console.WriteLine("Serialization type binary {0} ms", stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();
            
            stopWatch.Start();
            for (int i = 0; i < 10; i++)
            {
                kyivstar.JsonSerialize();
            }
            stopWatch.Stop();
            Console.WriteLine("Serialization type JSON {0} ms", stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();
            
            stopWatch.Start();
            for (int i = 0; i < 10; i++)
            {
                kyivstar.XmlSerialize();
            }
            stopWatch.Stop();
            Console.WriteLine("Serialization type XML {0} ms", stopWatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
