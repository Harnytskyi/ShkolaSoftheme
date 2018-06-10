using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _11
{
    public class PhotoPrinter : Printer
    {
        public override void Print(string message)
        {
            Console.WriteLine("Photo printer " + message);
        }
        public void Print(string message, string image)
        {
            Console.WriteLine("Message - {0}, Image - {1}", message, image);
        }
    }
}
