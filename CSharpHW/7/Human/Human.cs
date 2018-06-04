using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Human
    {
        
        string FirstName;
        string LastName;
        public int Age { get; }
        private int countAge(DateTime BirthDate)
        {
            var Age = DateTime.Today.Year - BirthDate.Year;
            return Age;
        }
        public Human(string firstname, string lastname)
        { }
        public Human(string firstname, string lastname, DateTime birthdate)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = countAge(birthdate);
        }

        public bool compareHuman (Human human2)
        {
            if ((FirstName == human2.FirstName) && (LastName == human2.LastName) && (Age == human2.Age))
                return true;
            else
                return false;
        }
        public string outputHuman()
        {
            return FirstName + " " + LastName + " " + Age;
        }
        public string outputflname()
        {
            return FirstName + " " + LastName;
        }
    }
}
