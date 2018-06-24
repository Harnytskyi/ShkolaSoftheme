using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace Mobile
{
    class MobileOperator
    {
        List<int> _callToAccounts = new List<int>();
        List<int> _callFromAccounts = new List<int>();
        List<int> _smsToAccounts = new List<int>();
        List<int> _smsFromAccounts = new List<int>();

        private Dictionary<int, MobileAccount> _accounts = new Dictionary<int, MobileAccount>();
        


        public MobileAccount CreateAccount(int number)
        {
            var acc = new MobileAccount(number, this);
            
            var document = new XmlDocument();
            document.Load("journal.xml");

            var Number = document.CreateElement("number");
            Number.Value = acc.Number.ToString();
                        
            document.Save("journal.xml");
            _accounts.Add(number, acc);

            acc.OnMessagePost += RouteMessage;
            acc.OnCall += RouteCall;
            return acc;
        }

        public MobileOperator()
        {
            XmlTextWriter textWritter = new XmlTextWriter("journal.xml", Encoding.UTF8);
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("head");
            textWritter.WriteEndElement();
            textWritter.Close();
        }


        private void RouteMessage(int numberTo, string message, int numberFrom)
        {
            MobileAccount acc;
            if (_accounts.TryGetValue(numberTo, out acc))
            {
                acc.ReceiveMessage(numberFrom, message);
                _smsToAccounts.Add(numberTo);
                _smsFromAccounts.Add(numberFrom);
            }
        }

        private void RouteCall(int numberTo, int numberFrom)
        {
            MobileAccount acc;
            if (_accounts.TryGetValue(numberTo, out acc))
            {
                acc.ReceiveCall(numberFrom);
                _callToAccounts.Add(numberTo);
                _callFromAccounts.Add(numberFrom);
            }
            
        }
        
    }
}
