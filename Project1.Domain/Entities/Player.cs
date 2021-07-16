using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using Project1.Domain.Enum;
using Project1.Domain.Resources;
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
                .IfNullOrInvalidLength(player => player.Password, 6, 32, Message.RequiredBeetwen.ToFormat("Password", 6, 32));
        }

        public Player(Name name, Email email, string password)
        {
            
            Name = name;
            Email = email;
            Password = password;

            new AddNotifications<Player>(this)
                .IfNullOrInvalidLength(player => player.Password, 6, 32, Message.RequiredBeetwen.ToFormat("Password", 6, 32));
            AddNotifications(Name, Email);
            Id = Guid.NewGuid();
            Status = EnumPlayerStatus.Waiting;
        }

        public Guid Id { get; private set; }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
        public EnumPlayerStatus Status { get; private set; }
    }
}
