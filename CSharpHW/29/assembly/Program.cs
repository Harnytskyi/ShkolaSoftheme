using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembly
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Worker
    {
        public void Number(int a, int b)
        {
            Console.WriteLine("{0}, { 1}", a, b);
        }

        public void ShowMessege()
        {
            Console.WriteLine("messege");
        }

        public void ShowMessege(string messege)
        {
            Console.WriteLine(messege);
        }
    }
}
