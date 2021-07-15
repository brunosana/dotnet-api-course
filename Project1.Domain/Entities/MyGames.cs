using System;

namespace Project1.Domain.Entities
{
    public class MyGame
    {
        public Guid Id { get; set; }

        public GamePlatform GamePlatform { get; set; }
        public bool Like { get; set; }
        public bool Sell { get; set; }
    }
}
