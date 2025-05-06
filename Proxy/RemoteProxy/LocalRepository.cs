using Proxy.Core;
using Proxy.VirtualProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.RemoteProxy
{
    public class LocalRepository : IUserRepositoryRemote
    {
        private readonly RemoteProxyRepository _remoteRepository;
        private static Dictionary<int, UserData> _cacheUserData = new Dictionary<int, UserData>();
        public LocalRepository(RemoteProxyRepository remoteRepository)
        {
            _remoteRepository = remoteRepository;
        }
        public async Task<UserData> GetUserDataById(int id)
        {
            UserData user = null;
            if(!_cacheUserData.TryGetValue(id, out user))
            {
                await _remoteRepository.GetUserDataById(id);
                _cacheUserData.Add(id, user);
            }
            else
            {
                Console.WriteLine("Getting user by cache ...");
            }
            return user;
        }

        public async Task InsertUserData(UserData userData)
        {
           await _remoteRepository.InsertUserData(userData);
            _cacheUserData.Add(userData.Id, userData);
        }

        public async Task RemoveUserData(int id)
        {
            await _remoteRepository.RemoveUserData(id);
            _cacheUserData.Remove(id);
        }
    }
}
