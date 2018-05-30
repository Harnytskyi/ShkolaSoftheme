using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;



namespace Mobile
{
    [Serializable]
    [DataContract]

    public class MobileOperator
    {
        [DataMember]
        private List<MobileAccount> _accounts = new List<MobileAccount>();
        private Dictionary<int, MobileAccount> _number;
        public MobileOperator()
        {
            _number = new Dictionary<int, MobileAccount>();
            
        }

        public MobileAccount CreateAccount(int number)
        {
            var acc = new MobileAccount(number, this);

            
            acc.Number = number;
            _accounts.Add(acc);
            acc.OnMessagePost += RouteMessage;
            acc.OnCall += RouteCall;
            _number.Add(number, acc);
            return acc;
        }

        private void RouteMessage(int numberTo, string message, int numberFrom)
        {
            MobileAccount acc;
            if (_accounts.Exists(x => x.Number == numberTo))
            {
                acc = _accounts.Find(x => x.Number == numberTo);
                acc.ReceiveMessage(numberFrom, message);
            }
        }

        private void RouteCall(int numberTo, int numberFrom)
        {
            MobileAccount acc;
            if (_accounts.Exists(x => x.Number == numberTo))
            {
                acc = _accounts.Find(x => x.Number == numberTo);
                acc.ReceiveCall(numberFrom);
            }
        }


        private AnySerializer<MobileAccount> _serializer = new AnySerializer<MobileAccount>();
        
        public void JsonSerialize()
        {
            _serializer.JsonSerialize("JsonSerializedRepository.json", _accounts);

        }
        
    }
}
