using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;
using System.Runtime.Serialization.Json;

namespace Mobile
{
    class DeSerializer
    {
        public static T ReadObjectJson<T>(string nameOfFile)
        {
            if (new FileInfo(nameOfFile).Exists)
            {
                var ser = new DataContractJsonSerializer(typeof(T));

                using (FileStream fs = new FileStream(nameOfFile, FileMode.Open))
                {
                    if (fs.CanRead)
                    {
                        var reader = JsonReaderWriterFactory.CreateJsonReader(fs, new XmlDictionaryReaderQuotas());
                        var readItem = ser.ReadObject(reader);

                        if (readItem is T)
                        {
                            return (T)readItem;
                        }
                    }
                }
            }
            return default(T);
        }
    }
}
