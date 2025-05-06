using Bridge.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Mailbox
{
    public abstract class ViewMailbox
    {
        public INotification Notification {  get; set; }

        public abstract void DisplayNotification();
    }
}
