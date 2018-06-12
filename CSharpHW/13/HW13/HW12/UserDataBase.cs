using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class UserDataBase : IUserDataBase
    {
        public List<IUser> Users = new List<IUser>();

        public void AddUser(IUser user)
        {
            Users.Add(user);
            Console.WriteLine("New user created");
        }
        public void SearchUserName(string name)
        {
            foreach (var i in Users)
            {
                if (name == i.Name)
                    i.GetFullInfo();
            }
        }
        public void GetList(bool clean)
        {
            
                foreach(var i in Users)
                {
                    Console.WriteLine(i.GetFullInfo());
                }
        }
        void IDisposable.Dispose()
        {
            GetList(true);
            GC.SuppressFinalize(this);
        }

        ~UserDataBase()
        {
            GetList(false);
        }
    }
}
