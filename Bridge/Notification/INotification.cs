using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Notification
{
    public interface INotification
    {
        public int GetId();
        public string GetDestination();
        public string GetSource();
        public string GetBody();
    }
}
