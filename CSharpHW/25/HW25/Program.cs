using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace HW25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter directory path to zip files: ");
            string dirZipName = Console.ReadLine();
            Archivator.ZipFilesInDirectory(dirZipName);
            Archivator.handle.WaitOne();

            Console.WriteLine("Enter Path to unzip files: ");
            string dirUnzipName = Console.ReadLine();

            Archivator.GetFileFromAchive(dirUnzipName);
            Console.ReadLine();
        }
    }
}
