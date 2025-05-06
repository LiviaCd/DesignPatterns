using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Core
{
    public class UserData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserData()
        {
            
        }
        public UserData(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
