using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class MobileAccount
    {    
        private int _number;

        [Required]
        [StringLength(5, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        
        
        

        private Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
            public MobileAccount(int number, string firstName, string lastName, DateTime birthday, string email, MobileOperator mobileOperator)
            {
                _number = number;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Email = email;
            }

            public int Number => _number;

            public event Action<int, int> OnCall;
            public event Action<int, string, int> OnMessagePost;

            public void AddContact(int number, string firstName, string lastName)
            {
                _contacts.Add(number, new Contact(firstName, lastName));
            }
            public void SendMessage(int number, string message)
            {
                Console.WriteLine("Send message: {0} \nTo {1}", message, number);

                OnMessagePost?.Invoke(number, message, _number);
            }

            public void Call(int number)
            {
                Console.WriteLine("Call to {0}", number);

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

                Console.WriteLine($"Incoming call from {fromContact}");
            }

            private string GetContactStr(int number)
            {
                Contact contact;
                return _contacts.TryGetValue(number, out contact)
                    ? $"{contact.FirstName} {contact.LastName}"
                    : number.ToString();
            }
        
        
    }
}