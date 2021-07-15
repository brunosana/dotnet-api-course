using Project1.Domain.Interfaces.Arguments;
using Project1.Domain.ValueObjects;

namespace Project1.Domain.Arguments.Player
{
    public class CreatePlayerRequest : IRequest
    {
        public Name Name { get; set; }
        public Email Email { get; set; }
        public string Password { get; private set; }
    }
}
