using FactoryMethod.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public abstract class NotificationFactory
    {
        private static readonly Dictionary<NotificationType, Func<INotification>> _instance = new Dictionary<NotificationType, Func<INotification>>();
        
        static NotificationFactory()
        {
            _instance[NotificationType.Email] = () => new EmailNotification();
            _instance[NotificationType.Sms] = () => new SmsNotification();
        }
        public static INotification Create(NotificationType type)
        {
            Func<INotification> creator;
            _instance.TryGetValue(type, out creator);

            if(creator == null) 
                throw new Exception("Unsupport type");

            INotification notification = creator();

            return notification;
        }

        
    }
}
