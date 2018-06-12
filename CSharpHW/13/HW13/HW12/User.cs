using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class User : IUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        
        public DateTime LastLogin;

        public User(string login, string password, bool nameGiven)
        {
            if (nameGiven == true)
            {
                Name = login;
            }
            else
            {
                Email = login;
            }
            Password = password;
            LastLogin = DateTime.Now;
        }
        public string GetFullInfo()
        {
            return "Name: " + Name + " Email: " + Email + " PassWord" + Password + ", LastLogin: " + LastLogin;
        }
        public void SetLastLogin(DateTime loginTime)
        {
            LastLogin = loginTime;
        }
        public string GetLastLogin()
        {
            return LastLogin.ToString();
        }
    }
}
