using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UrbanRankingAPI.Models.DynamoDB;

namespace UrbanRankingAPI.Repository
{
    public interface ICityRepository
    {
        //get(get)
        Task<IEnumerable<CityDynamoDBModel>> Get(int chatid);
        Task<IEnumerable<GetByCategory>> GetByCategory(string category);
        Task<IEnumerable<CitiesByLetter>> GetCitiesByLetter(string letter);
        Task<IEnumerable<Subscription>> GetUsersChatId(string purpose);

        //create(post)
        Task<CityDynamoDBModel> Create(CityDynamoDBModel city);
        Task<Subscription> CreateChatId(Subscription subscription);

        //delete(delete)
        Task<ActionResult> Delete(int chatid, string cityname);
        Task<ActionResult> DeleteAll(int chatid);
        Task<ActionResult> DeleteSubscription(int chatid);
    }
}
