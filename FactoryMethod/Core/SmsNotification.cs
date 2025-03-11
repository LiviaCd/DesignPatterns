using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Core
{
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Send sms: {message}");
        }
    }
}
