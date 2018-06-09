using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = CarConstructor.Construct(new Engine("diesel"), new Color("blue"), new Transmission("manual"));
            Console.WriteLine( car1);
            car1 = CarConstructor.Reconstruct(car1, new Engine("1D12"));
            Console.WriteLine(car1);

            Console.ReadLine();
        }
    }
}
