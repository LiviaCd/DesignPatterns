using Proxy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.RemoteProxy
{
    public interface IUserRepositoryRemote
    {
        Task<UserData> GetUserDataById(int id);
        Task InsertUserData(UserData userData);
        Task RemoveUserData(int id);
    }
}
