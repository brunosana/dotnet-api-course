using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using Project1.Domain.Resources;

namespace Project1.Domain.ValueObjects
{
    public class Name : Notifiable
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            new AddNotifications<Name>(this)
                .IfNullOrEmpty(name => name.FirstName, Message.Required.ToFormat("First Name"))
                .IfNullOrEmpty(name => name.LastName, Message.Required.ToFormat("LastName"));
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
