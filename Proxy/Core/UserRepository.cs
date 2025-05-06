using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Core
{
    public class UserRepository : IUserRepository
    {
        private static List<UserData> _dbUsers = new List<UserData>
        {
            new UserData(1, "Ion Popescu", "ion.popescu@gmail.com"),
            new UserData(2, "Maxim Maximov", "maxim.maximov@gmail.com"),
            new UserData(3, "Radu Andronic", "radu.andronic@gmail.com"),

        };

        public UserData GetUserDataById(int id)
        {
            Console.WriteLine("Getting user by id ...");
            Thread.Sleep(2000);

            return _dbUsers.FirstOrDefault(x => x.Id == id);
        }

        public void InsertUserData(UserData userData)
        {
            Console.WriteLine("Inserting user");
            Thread.Sleep(2000);
            _dbUsers.Add(userData);
        }

        public void RemoveUserData(int id)
        {
            var user = _dbUsers.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                Console.WriteLine("Removing user");
                Thread.Sleep(2000);

                _dbUsers.Remove(user);
            }
        }
    }
}
