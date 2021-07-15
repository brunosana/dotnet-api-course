using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using Project1.Domain.Resources;

namespace Project1.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;
            new AddNotifications<Email>(this)
                .IfNotEmail(email => email.Address, Message.Invalid.ToFormat("Email Address"));
        }
        public string Address { get; private set; }
    }
}
