using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Threading;

namespace HW25
{
    public class Archivator
    {
        private const string ZipExtension = ".zip";
        public static EventWaitHandle handle = new AutoResetEvent(false);


        public static void ZipFilesInDirectory(object path)
        {
            string directory = Convert.ToString(path);
            if (Directory.Exists(directory))
            {
                string[] dirs = Directory.GetDirectories(directory);
                foreach (string s in dirs)
                {
                    Thread myThread = new Thread(ZipFilesInDirectory);
                    myThread.Start(s);
                }

                string[] files = Directory.GetFiles(directory);
                foreach (string s in files)
                {
                    var tmpDir = s.Replace(Path.GetExtension(s), " ");
                    Directory.CreateDirectory(tmpDir);

                    File.Move(s, tmpDir + "\\" + Path.GetFileName(s));
                    ZipFile.CreateFromDirectory(tmpDir, tmpDir + ZipExtension);
                    
                    Directory.Delete(tmpDir, true);
                    Console.WriteLine("success {0}", s);
                }
            }
            else
            {
                Console.WriteLine("Can't find this folder");
            }
            handle.Set();
        }

        public static void GetFileFromAchive(object path)
        {
            string directory = Convert.ToString(path);
            if (Directory.Exists(directory))
            {
                string[] dirs = Directory.GetDirectories(directory);
                foreach (string s in dirs)
                {
                    Thread myThread = new Thread(GetFileFromAchive);
                    myThread.Start(s);
                 
                }

                string[] files = Directory.GetFiles(directory);

                foreach (var s in files)
                {
                    FileInfo fi = new FileInfo(s);
                    if (fi.Extension == ".zip")
                    {
                        string zipPath = s;
                        ZipFile.ExtractToDirectory(zipPath, directory);
                        File.Delete(s);
                        Console.WriteLine("dearchive file: {0}", s);
                    }
                }
            }
        }
    }
}
