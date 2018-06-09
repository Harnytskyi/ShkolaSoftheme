using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = CarConstructor.Construct(Engine.S52, Color.Pink, Transmission.Auto);
            Console.WriteLine(car1);
            car1 = CarConstructor.Reconstruct(car1, Engine.Q78);
            Console.WriteLine(car1);

            Console.ReadLine();
        }
    }
}
