using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDescriptor
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure1 = new ShapeDescriptor(new Point(), new Point(3, 4)) ;
            var figure2 = new ShapeDescriptor(new Point(), new Point(-2, 1), new Point(7, 9));
            var figure3 = new ShapeDescriptor(new Point(), new Point(-20, 4), new Point(4, 20), new Point(5, 10));

            Console.WriteLine(figure1.GetShapeType());
            Console.WriteLine(figure2.GetShapeType());
            Console.WriteLine(figure3.GetShapeType());

            Console.ReadLine();
        }
    }
}
