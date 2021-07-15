using System;

namespace Project1.Domain.Entities
{
    public class GamePlatform
    {
        public Guid Id { get; set; }

        public Game Game { get; set; }
        public Platform Platform { get; set; }
        public DateTime Created_At { get; set; }

    }
}
