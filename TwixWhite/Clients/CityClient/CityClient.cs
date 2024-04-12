using Bill.Code.Twix.Controller.Rpc.Proto.City;
using Google.Protobuf.WellKnownTypes;
using TwixWhite.Models.CityModels;
using static Bill.Code.Twix.Controller.Rpc.Proto.City.CityController;

namespace TwixWhite.Clients.CityClient
{
    internal class CityClient : ICityCilent
    {
        private CityControllerClient client;

        public CityClient(CityControllerClient client)
        {
            this.client = client;
        }

        public bool addCity(CityModel city)
        {
            CityModelGdto gdto = new CityModelGdto
            {
                Id = city.Id,
                Name = city.Name
            };

            return client.addCity(gdto).Result;
        }

        public bool deleteCity(CityModel city)
        {
            CityModelGdto gdto = new CityModelGdto
            {
                Id = city.Id,
                Name = city.Name
            };

            return client.deleteCity(gdto).Result;
        }

        public bool deleteCityById(int id)
        {
            Int Vid = new Int
            {
                Value = id
            };

            return client.deleteCityById(Vid).Result;
        }

        public List<CityModel> getAll()
        {
            Empty empty = new Empty();
            return client.getAllCity(empty).CityList
                .Select(cg =>
                {
                    CityModel model = new CityModel
                    {
                        Id = cg.Id,
                        Name = cg.Name,
                    };
                    return model;
                })
                .ToList();
        }
    }
}
