using Project1.Domain.Interfaces.Arguments;
using System;

namespace Project1.Domain.Arguments.Player
{
    public class CreatePlayerResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
    }
}
