using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            printer.Print("text1");
            var cprinter = new ColourPrinter();
            cprinter.Print("text2");
            cprinter.Print("text2", ConsoleColor.DarkMagenta);
            var pprinter = new PhotoPrinter();
            pprinter.Print("tex3");
            pprinter.Print("text3", "photo");
            Console.ReadKey();
        }
    }
}
