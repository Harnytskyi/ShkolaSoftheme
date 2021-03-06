﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW26
{
    public class FileChanger
    {
        private readonly string _path;
        private readonly string _textToChange;
        private readonly string _newText;

        private readonly FileStream _logStream;
        private StreamWriter _logWriter;

        public FileChanger(string path, string textToChange, string newText)
        {
            var dirLog = Directory.CreateDirectory(path + "\\" + "logFile");
            _path = path;
            _textToChange = textToChange;
            _newText = newText;

            var log = File.Create(dirLog.FullName + "\\" + "LogFile.txt");
            log.Close();
            _logStream = new FileStream(log.Name, FileMode.Append);
        }
        public void ChangeFiles()
        {
            string[] files = Directory.GetFiles(_path);
            Parallel.ForEach(files, ChangeOneFile);
        }

        private void ChangeOneFile(string file)
        {
            using (StreamReader sr = new StreamReader(file, Encoding.Default))
            {
                string text = sr.ReadToEnd();
                if (text.Contains(_textToChange))
                {
                    string tmp = text.Replace(_textToChange, _newText);
                    sr.Close();

                    using (StreamWriter sw = new StreamWriter(file, false, Encoding.Default))
                    {
                        sw.WriteLine(tmp);

                        lock (_logStream)
                        {
                            _logWriter = new StreamWriter(_logStream);
                            _logWriter.WriteLine("File: {0}, Change Text: {1}, On Text: {2}",
                                                file, _textToChange, _newText);
                            _logWriter.Flush();
                        }
                    }
                }
            }
        }
    }
}
