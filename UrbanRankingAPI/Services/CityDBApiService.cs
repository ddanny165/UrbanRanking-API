using System.Threading.Tasks;
using System.Net.Http;
using UrbanRankingAPI.Models;
using UrbanRankingAPI.AddLogic;
using System.Text.Json;

namespace UrbanRankingAPI.Services
{
    public class CityDBApiService :ICityDBApiService
    {
        private readonly HttpClient _httpClient;

        public CityDBApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CityBasicInfo> GetCityBasicInfo(string WikiDataID)
        {
            var response = await _httpClient.GetAsync($"geo/cities/{WikiDataID}?x-rapidapi-key={Constants.GeoDbApiKey}");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<CityApiGeoDB>(responseStream);

            CityBasicInfo CityInstance = new();

            CityInstance.CityName = responseObject.data.city;
            CityInstance.CountryName = responseObject.data.country;
            CityInstance.CountryCode = responseObject.data.countryCode;
            CityInstance.CityPopulation = responseObject.data.population;

            string continent = responseObject.data.timezone;
            int index = continent.IndexOf("_");
            continent = continent.Substring(0, index);

            CityInstance.Continent = continent;

            return CityInstance;
        }
    }
}
