using Grpc.Net.Client;
using TwixWhite.Clients.CityClient;
using static Bill.Code.Twix.Controller.Rpc.Proto.City.CityController;

GrpcChannel channel = GrpcChannel.ForAddress("http://localhost:8543");
CityControllerClient cityControllerClient = new CityControllerClient(channel);
CityClient cityClient = new CityClient(cityControllerClient);

cityClient.getAll().ForEach(c => Console.WriteLine(c.Name));
