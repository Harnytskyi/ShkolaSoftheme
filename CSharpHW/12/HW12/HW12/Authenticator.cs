using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class Authenticator : IAuthenticator
    {
        List<IUser> Users = new List<IUser>();
        public bool Authentic(IUser user)
        {
            foreach (User existingUser in Users)
            {
                if(existingUser.Name == user.Name && existingUser.Email == user.Email && existingUser.Password == user.Password)

                {
                    Console.WriteLine("Last time logged in: {0}", existingUser.GetLastLogin());
                    existingUser.SetLastLogin(DateTime.Now);
                    return true;
                }
            }
            return false;
        }
        public void AddUser(IUser user)
        {
            Users.Add(user);
            Console.WriteLine("New user created");
        }
        public void PrintUsers()
        {
            Console.WriteLine("Available users:");
            foreach (User user in Users)
            {
                Console.WriteLine(user.GetFullInfo());
            }
        }
    }
}
