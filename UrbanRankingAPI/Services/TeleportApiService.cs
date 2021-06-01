using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using UrbanRankingAPI.Models;
using System.Text.Json;

namespace UrbanRankingAPI.Services
{
    public class TeleportApiService :ITeleportApiService
    {
        private readonly HttpClient _httpClient;

        public TeleportApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CityReview>> GetCityReview(string CityName)
        {
            var response = await _httpClient.GetAsync($"urban_areas/slug:{CityName}/scores/");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<CityApiTeleport>(responseStream);

            return responseObject.categories.Select(i => new CityReview
            {
                Score = i.score_out_of_10,
                Name = i.name
            });
        }

        public async Task<string> GetCitySummary(string CityName)
        {
            var response = await _httpClient.GetAsync($"urban_areas/slug:{CityName}/scores/");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var responseObject = await JsonSerializer.DeserializeAsync<CityApiTeleport>(responseStream);

            return responseObject.summary;
        }
    }
}
