using FactoryMethod.Core;
using FactoryMethod.Factory;
class Program
{
    static void Main(string[] args)
    {
        INotification email = NotificationFactory.Create(NotificationType.Email);
        INotification sms = NotificationFactory.Create(NotificationType.Sms);
        INotification email2 = NotificationFactory.Create(NotificationType.Email);

        email.Send("message 1");
        sms.Send("message 2");
        email2.Send("message 3");
    }
}