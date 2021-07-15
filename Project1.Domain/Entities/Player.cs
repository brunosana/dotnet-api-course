using prmToolkit.NotificationPattern;
using Project1.Domain.Enum;
using Project1.Domain.ValueObjects;
using System;

namespace Project1.Domain.Entities
{
    public class Player : Notifiable
    {
        public Player(Email email, string password)
        {
            Email = email;
            Password = password;

            new AddNotifications<Player>(this)
                .IfNullOrInvalidLength(player => player.Password, 6, 32, "Required password beetwen 6 and 32 characters.");
        }

        public Guid Id { get; private set; }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
        public EnumPlayerStatus status { get; private set; }
    }
}
