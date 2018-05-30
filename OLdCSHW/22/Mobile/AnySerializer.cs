using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mobile
{
    [Serializable]
    public class AnySerializer<T>
    {
        public void BinarySerialize(string fileName, List<T> list)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }
        
        public void XmlSerialize(List<T> list, string fileName)
        {
            XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(fs, list);
            }
        }
        
        public void JsonSerialize(string fileName, List<T> list)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, list);
            }
        }

        
    }
}

