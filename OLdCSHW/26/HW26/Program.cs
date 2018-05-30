using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW26
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Users\";

            string oldText = "old";

            string newText = "new";


            FileChanger fc = new FileChanger(path, oldText, newText);
            fc.ChangeFiles();


            Console.WriteLine("All files are changed. See log file in your directory!");
            Console.ReadLine();

        }
    }
}
