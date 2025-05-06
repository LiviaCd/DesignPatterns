using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Notification
{
    public class SmsNotification : INotification
    {
        private int _id;
        private string _photoTo;
        private string _photoFrom;
        private string _body;
        public SmsNotification(int id, string photoTo, string photoFrom, string body)
        {
            _id = id;
            _photoTo = photoTo;
            _photoFrom = photoFrom;
            _body = body;
        }

        public string GetDestination()
        {
            return _photoTo;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetSource()
        {
            return _photoFrom;
        }
        public string GetBody()
        {
            return _body;
        }
    }
}
