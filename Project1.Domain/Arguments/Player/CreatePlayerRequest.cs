using Project1.Domain.Interfaces.Arguments;
using Project1.Domain.ValueObjects;

namespace Project1.Domain.Arguments.Player
{
    public class CreatePlayerRequest : IRequest
    {
        public CreatePlayerRequest(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
