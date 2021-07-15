using Project1.Domain.Arguments.Player;
using Project1.Domain.Entities;
using Project1.Domain.Interfaces.Repositories;
using Project1.Domain.Interfaces.Services;
using Project1.Domain.ValueObjects;
using System;

namespace Project1.Domain.Services
{
    public class ServicePlayer : IServicePlayer
    {
        private readonly IRepositoryPlayer _repositoryPlayer;
        public ServicePlayer() { }
        public ServicePlayer(IRepositoryPlayer repositoryPlayer)
        {
            _repositoryPlayer = repositoryPlayer;
        }
        public AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request)
        {
            var response =  _repositoryPlayer.Authenticate(request);
            return response;
        }

        private bool IsEmail(string email)
        {
            return false;
        }

        public CreatePlayerResponse Create(CreatePlayerRequest request)
        {
            Guid Id = _repositoryPlayer.Create(request);
            return new CreatePlayerResponse() { Id = Id, Message = "Successfully player created." };
        }
    }
}
