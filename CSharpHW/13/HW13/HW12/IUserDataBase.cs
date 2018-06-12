using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    interface IUserDataBase : IDisposable
    {
        void AddUser(IUser user);
        void GetList(bool clean);
        void SearchUserName(string name);
    }
}
