using Project1.Domain.Arguments.Platform;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Domain.Interfaces.Services
{
    public interface IServicePlatform
    {
        CreatePlatformResponse Create(CreatePlatformRequest request);
    }
}
