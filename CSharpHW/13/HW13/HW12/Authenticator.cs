using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class Authenticator : IAuthenticator
    {
        
        public bool Authentic(IUser user, UserDataBase allUsers)
        {
            foreach (User existingUser in allUsers.Users)
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
        /*
        public void PrintUsers(UserDataBase alluser)
        {
            Console.WriteLine("Available users:");
            foreach (User user in alluser)
            {
                Console.WriteLine(user.GetFullInfo());
            }
        }
        */
    }
}
