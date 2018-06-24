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

        public void ShowMessage()
        {
            Console.WriteLine("message");
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
