using Project1.Domain.Interfaces.Arguments;

namespace Project1.Domain.Arguments.Player
{
    public class AuthenticatePlayerResponse : IResponse
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
    }
}
