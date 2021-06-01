using System.Threading.Tasks;
using UrbanRankingAPI.Models;

namespace UrbanRankingAPI.Services
{
    public interface ICityDBApiService
    {
        Task<CityBasicInfo> GetCityBasicInfo(string WikiDataID);
    }
}
