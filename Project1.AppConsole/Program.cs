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
            var request = new CreatePlayerRequest(
                "Bruno",
                "Santana Andrade",
                "bruno@bruno.com",
                "123456789"
            );
            var response = service.Create(request);
            Console.ReadKey();
        }
    }
}
