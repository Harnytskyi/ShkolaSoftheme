using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class MobileAccount
    {
        
            private int _number;

            private Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
            public MobileAccount(int number, MobileOperator mobileOperator)
            {
                _number = number;
            }

            public int Number => _number;

            public event Action<int, int> OnCall;
            public event Action<int, string, int> OnMessagePost;
            private double _rateOfActivity = 0;
            public double RateOfActivity { get { return _rateOfActivity; } }

            public void AddContact(int number, string fName)
            {
                _contacts.Add(number, new Contact(fName));
            }
            public void SendMessage(int number, string message)
            {
                Console.WriteLine("Send message: {0} \nTo {1}", message, number);
                _rateOfActivity += 0.5;
                OnMessagePost?.Invoke(number, message, _number);
            }
            
            public void Call(int number)
            {
                Console.WriteLine("Call to {0}", number);
                _rateOfActivity += 1.0;
                OnCall?.Invoke(number, _number);
            }

            public void ReceiveMessage(int number, string message)
            {
                string fromContact = GetContactStr(number);
                Console.WriteLine("New message: {0} \nFrom:{1}", message, fromContact);
            }

            public void ReceiveCall(int number)
            {
                string fromContact = GetContactStr(number);

                Console.WriteLine("Incoming call from {0}" , fromContact);
            }

            private string GetContactStr(int number)
            {
                Contact contact;
                return _contacts.TryGetValue(number, out contact)
                    ? $"{contact.FName} "
                    : number.ToString();
            }
        
    }
}
