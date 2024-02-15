using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcClient; 

namespace gRpcClient
{
    public class Program
    {
        static async Task Main(string[] args) // Add async modifier
        {
            string serviceEndpoint = "http://localhost:5001";
            var channel = GrpcChannel.ForAddress(serviceEndpoint);
            var client = new Greeter.GreeterClient(channel); 

            HelloRequest helloRequest = new HelloRequest
            {
                Name = "John Doe",
                MyInt = 42,
                MyString = "Hello gRPC!",
                MyTimestamp = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.UtcNow),
                MyGuid = Guid.NewGuid().ToString(),
                MyStringList = { "apple", "banana", "orange" }
            };
            var response = await client.SayHelloAsync(helloRequest);

            Console.WriteLine($"Response obtained from the service {response.Message}");
            Console.WriteLine($"Response obtained from the service {response.MyInt}");
            Console.WriteLine($"Response obtained from the service {response.MyString}");
            Console.WriteLine($"Response obtained from the service {response.MyTimestamp}");
            Console.WriteLine($"Response obtained from the service {response.MyGuid}");
            Console.WriteLine($"Response obtained from the service {response.MyStringList}");

            Console.ReadLine();
        }
    }
}
