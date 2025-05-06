using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProtectedProxy
{
    public class SecurityLevel
    {
        public static readonly string truePassword = "Secret123"; 

        public static bool Authentication(string password)
        {
            return password == truePassword;
        }
    }

}
