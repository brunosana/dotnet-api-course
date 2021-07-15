using Project1.Domain.Interfaces.Arguments;
using System;

namespace Project1.Domain.Arguments.Platform
{
    public class CreatePlatformResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
