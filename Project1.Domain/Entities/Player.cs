using Project1.Domain.Enum;
using Project1.Domain.ValueObjects;
using System;

namespace Project1.Domain.Entities
{
    public class Player
    {
        public Player(string password, Email email)
        {
            if (string.IsNullOrEmpty(email.Address))
            {
                throw new Exception("Missing Email");
            }
            if(string.IsNullOrEmpty(password))
            Password = password;
            Email = email;
        }

        public Guid Id { get; set; }

        public Name Name { get; set; }
        public Email Email { get; set; }
        public string Password { get; private set; }
        public EnumPlayerStatus status { get; set; }
    }
}
