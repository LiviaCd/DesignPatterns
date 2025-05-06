using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Notification
{
    public class EmailNotification : INotification
    {
        private int _id;
        private string _emailTo;
        private string _emailFrom;
        private string _body;

        public EmailNotification(int id, string emailTo, string emailFrom, string body)
        {
            _id = id;
            _emailTo = emailTo;
            _emailFrom = emailFrom;
            _body = body;
        }

        public string GetDestination()
        {
            return _emailTo;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetSource()
        {
            return _emailFrom;
        }

        public string GetBody()
        {
            return _body;
        }
    }
}
