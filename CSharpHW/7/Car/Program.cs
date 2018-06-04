using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
          var car = new Car() { Model = "Totota", Color = "Green", Year = "1986"};
            Console.WriteLine("Model: " +car.Model + " " + "Color: " + car.Color + " " + "Year: " + car.Year);
            TuningAtelier.repaint(car);
            Console.WriteLine("Model: " + car.Model + " " + "Color: " + car.Color + " " + "Year: " + car.Year);
            Console.ReadKey();
        }
    }
}
