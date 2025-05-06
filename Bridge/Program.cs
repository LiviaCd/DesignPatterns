using Bridge.Mailbox;
using Bridge.Notification;

class Program
{
    static void Main(string[] args)
    {
        ViewMailbox mailbox = new LongViewMailbox();
        mailbox.Notification = new EmailNotification(1, "test@gmail.com", "test2@mail.ru", "body ...");

        mailbox.DisplayNotification();
    }
}