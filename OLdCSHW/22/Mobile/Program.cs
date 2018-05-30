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
             
            var kyivstar = DeSerializer.ReadObjectJson<MobileOperator>("JsonSerializedRepository.json");
            

            Console.ReadLine();
        }
    }
}
