using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using Project1.Domain.Arguments.Player;
using Project1.Domain.Entities;
using Project1.Domain.Interfaces.Repositories;
using Project1.Domain.Interfaces.Services;
using Project1.Domain.Resources;
using Project1.Domain.ValueObjects;
using System;

namespace Project1.Domain.Services
{
    public class ServicePlayer : Notifiable, IServicePlayer
    {
        private readonly IRepositoryPlayer _repositoryPlayer;
        public ServicePlayer() { }
        public ServicePlayer(IRepositoryPlayer repositoryPlayer)
        {
            _repositoryPlayer = repositoryPlayer;
        }
        public AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request)
        {
            if(request == null)
            {
                AddNotification("AuthenticatePlayerRequest", Message.Required.ToFormat("AuthenticatePlayerRequest"));
            }
            Email email = new Email(request.Email);
            Player player = new Player(email, request.Password);
            AddNotifications(player, email);
            if (player.IsInvalid())
            {
                return null;
            }
            if (this.IsInvalid())
            {
                return null;
            }
            //var response = _repositoryPlayer.Authenticate(player.Email.Address, player.Password);
            //return response;
            return null;
        }

        public CreatePlayerResponse Create(CreatePlayerRequest request)
        {
            var email = new Email(request.Email);
            var name = new Name(request.FirstName, request.LastName);
            Player player = new Player(name, email, request.Password);

            if (this.IsInvalid())
            {
                return null;
            }
            Guid Id = _repositoryPlayer.Create(request);
            return new CreatePlayerResponse() { Id = Id, Message = "Successfully player created." };
        }
    }
}
