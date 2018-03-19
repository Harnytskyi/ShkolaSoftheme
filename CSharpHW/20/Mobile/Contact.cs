using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Contact
    {
       public string FirstName { get; set; }
        public string LastName { get; set; }

        public Contact(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
            

        }
    }
}
