
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValRefClone
{
    class User
    {
        public string Name;
        public int Age;
        public string Country;


        public User(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }
    }
}
