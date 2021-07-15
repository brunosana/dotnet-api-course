using Project1.Domain.Interfaces.Arguments;
using Project1.Domain.ValueObjects;

namespace Project1.Domain.Arguments.Player
{
    public class CreatePlayerRequest : IRequest
    {
        public CreatePlayerRequest(string name, string email, string password)
        {

        }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
