using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Mobile
{

    [Serializable]
    [DataContract]
    public class Contact
    {
        [XmlAttribute]
        [DataMember]
        public string FirstName { get; set; }
        [XmlAttribute]
        [DataMember]
        public string LastName { get; set; }

        [XmlAttribute]
        [DataMember]
        public int Number { get; set; }
        public Contact(string fName, string lName, int number)
        {
            FirstName = fName;
            LastName = lName;
            Number = number;
        }
    }
}
