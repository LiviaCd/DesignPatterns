using Proxy.Core;
using Proxy.VirtualProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProtectedProxy
{
    public class ProtectedRepository : IUserRepository
    {
        private readonly VirtualProxyRepository _proxyRepository;
        private readonly UserRepository _userRepository;
        private string _password;
        public ProtectedRepository(UserRepository userRepository, string password)
        {
            _proxyRepository = new VirtualProxyRepository(userRepository);
            _password = password;
        }
         
        public UserData GetUserDataById(int id)
        {
            if (SecurityLevel.Authentication(_password))
            {
                Console.WriteLine("Access permited");
                return _proxyRepository.GetUserDataById(id);
            }
            else
            {
                Console.WriteLine("Access denied");
                return null;
            }  
        }

        public void InsertUserData(UserData userData)
        {
            if (SecurityLevel.Authentication(_password))
            {
                Console.WriteLine("Access permited");
                _proxyRepository.InsertUserData(userData);
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }

        public void RemoveUserData(int id)
        {
            if (SecurityLevel.Authentication(_password))
            {
                Console.WriteLine("Access permited");
                _proxyRepository.RemoveUserData(id);
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }
    }
}
