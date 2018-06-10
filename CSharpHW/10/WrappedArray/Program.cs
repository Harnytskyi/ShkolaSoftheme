using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrappedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new WrappedArray(4, 8, 6);
            Console.WriteLine(first);
            first.Add(7, 8, 9);
            Console.WriteLine(first);
            Console.WriteLine("Contains 7: {0}", first.Contains(7));
            Console.WriteLine("Get by index 1: {0}", first.GetByIndex(1));
            var second = new WrappedArray(7, 5, 3, 8, 6, 1);
            Console.WriteLine(second);
            Console.WriteLine("Contains 9: {0}", second.Contains(9));
            Console.WriteLine("Get by index 4: {0}", second.GetByIndex(4));
            Console.ReadLine();
        }
    }
}
