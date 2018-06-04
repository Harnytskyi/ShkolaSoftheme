using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Lana", "Tewis", new DateTime(1912, 5, 19) );
            Human human2 = new Human("Devid", "Garix", new DateTime(1972, 6, 4));
            Human human3 = new Human("Roni", "Epam", new DateTime(1952, 6, 30));

            Console.WriteLine(human1.outputHuman());
            Console.WriteLine("Equal to " + human1.outputflname() + "?" + " " + human1.compareHuman(human1));

            Console.WriteLine(human2.outputHuman());
            Console.WriteLine("Equal to " + human1.outputflname() + "?" + " " + human2.compareHuman(human1));

            Console.WriteLine(human3.outputHuman());
            Console.WriteLine("Equal to " + human2.outputflname() + "?" + " " + human3.compareHuman(human2));


            Console.ReadKey();
        }

    }
}
