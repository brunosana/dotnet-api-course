using Project1.Domain.Arguments.Player;
using System;

namespace Project1.Domain.Interfaces.Repositories
{
    public interface IRepositoryPlayer
    {
        AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request);
        Guid Create(CreatePlayerRequest request);
    }
}
