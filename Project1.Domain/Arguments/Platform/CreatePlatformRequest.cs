using Project1.Domain.Interfaces.Arguments;

namespace Project1.Domain.Arguments.Platform
{
    public class CreatePlatformRequest : IRequest
    {
        public string Name { get; set; }
    }
}
