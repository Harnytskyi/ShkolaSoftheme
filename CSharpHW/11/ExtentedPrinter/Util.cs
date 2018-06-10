using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11;

namespace ExtentedPrinter
{
    public static class Util
    {
        public static void Multiprint(this Printer printer, string[] messages)
        {
            foreach(string message in messages)
            {
                printer.Print(message);
            }
        }
        public static void Multiprint(this ColourPrinter cprinter, string[] messages, ConsoleColor color)
        {
            foreach (string message in messages)
            {
                cprinter.Print(message, color);
            }
        }
        public static void Multiprint(this PhotoPrinter pprinter, string[] messages, string image)
        {
            foreach (string message in messages)
            {
                pprinter.Print(message, image);
            }
        }
    }
}
