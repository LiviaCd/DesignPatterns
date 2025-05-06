using Bridge.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Mailbox
{
    public class ShortViewMailbox : ViewMailbox
    {
        public override void DisplayNotification()
        {
            Console.WriteLine($"Id: {Notification.GetId()}");
            Console.WriteLine($"Destination: {Notification.GetDestination()}");
            Console.WriteLine($"Source: {Notification.GetSource()}");
        }
    }
}
