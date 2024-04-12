using TwixWhite.Models.CityModels;

namespace TwixWhite.Clients.CityClient
{
    internal interface ICityCilent
    {
        public List<CityModel> getAll();

        public bool addCity(CityModel city);

        public bool deleteCityById(int id);

        public bool deleteCity(CityModel city);
    }
}
