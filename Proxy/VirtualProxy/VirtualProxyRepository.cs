using Proxy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.VirtualProxy
{
    public class VirtualProxyRepository : IUserRepository
    {
        private readonly UserRepository _userRepository;
        public VirtualProxyRepository(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        private static Dictionary<int, UserData> _cacheUserData = new Dictionary<int, UserData>();

        public UserData GetUserDataById(int id)
        {
            UserData user = null;

            if(!_cacheUserData.TryGetValue(id, out user))
            {
                user = _userRepository.GetUserDataById(id);
                _cacheUserData.Add(id, user);
            }
            else
            {
                Console.WriteLine("Getting user by cache ...");
            }
            return user;
        }

        public void InsertUserData(UserData userData)
        {
           _userRepository.InsertUserData(userData);
           _cacheUserData.Add(userData.Id, userData);
        }

        public void RemoveUserData(int id)
        {
            _userRepository.RemoveUserData(id);
            _cacheUserData.Remove(id);
        }
    }
}
