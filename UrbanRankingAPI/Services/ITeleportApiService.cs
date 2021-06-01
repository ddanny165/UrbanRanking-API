using System.Collections.Generic;
using System.Threading.Tasks;
using UrbanRankingAPI.Models;


namespace UrbanRankingAPI.Services
{
    public interface ITeleportApiService
    {
        Task<IEnumerable<CityReview>> GetCityReview(string cityName);
        Task<string> GetCitySummary(string cityName); 
    }
}
