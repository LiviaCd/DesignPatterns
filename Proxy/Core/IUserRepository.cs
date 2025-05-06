using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Core
{
    public interface IUserRepository
    {
        UserData GetUserDataById(int id);
        void InsertUserData(UserData userData);
        void RemoveUserData(int id);
    }
}
