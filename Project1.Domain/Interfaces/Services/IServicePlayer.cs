using Project1.Domain.Arguments.Player;

namespace Project1.Domain.Interfaces.Services
{
    public interface IServicePlayer
    {
        AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request);
        CreatePlayerResponse Create(CreatePlayerRequest request);
    }
}
