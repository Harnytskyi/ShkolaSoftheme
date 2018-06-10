using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11;

namespace ExtentedPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            printer.Multiprint(new string[] { "text1", "text2" });

            var cprinter = new ColourPrinter();
            cprinter.Multiprint(new string[] { "colortext1", "colortext2" }, ConsoleColor.DarkYellow);

            var pprinter = new PhotoPrinter();
            pprinter.Multiprint(new string[] { "photo printer text 1", "photo printer text 2" }, "PHOTO");

            Console.ReadLine();
        }
    }
}
