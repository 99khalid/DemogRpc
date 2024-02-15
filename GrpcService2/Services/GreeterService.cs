using Grpc.Core;
using GrpcService2;
using System.Drawing;

namespace GrpcService2.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)

        {

            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name,
                MyInt = request.MyInt,
                MyString = request.MyString,
                MyTimestamp = request.MyTimestamp,
                MyGuid = request.MyGuid,
                MyStringList = { request.MyStringList }
            }) ;
        }
    }
}