using Project1.Domain.Arguments.Player;
using Project1.Domain.Services;
using System;

namespace Project1.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            var service = new ServicePlayer();
            Console.WriteLine("Service instance created");
            AuthenticatePlayerRequest request = new AuthenticatePlayerRequest();
            Console.WriteLine("Request created");
            var response = service.Authenticate(request);
            Console.ReadKey();
        }
    }
}
