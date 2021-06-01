using UrbanRankingAPI.Models.DynamoDB;
using UrbanRankingAPI.AddLogic;
using UrbanRankingAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UrbanRankingAPI.Authentication;


namespace UrbanRankingAPI.Controllers
{
    [Route("api/[controller]")] 
    [ApiKey] //restricting access to this controller bc of manipulations with user's data
    [ApiController]
    public class UsersController :Controller
    {
        private readonly ICityRepository _cityRepository;
        private readonly AddLogicMethods _addLogicMethods;

        public UsersController(ICityRepository cityRepository,
            AddLogicMethods addLogicMethods)
        {
            _cityRepository = cityRepository;
            _addLogicMethods = addLogicMethods;
        }

        [HttpGet("{ChatId}")]
        public async Task<IEnumerable<CityDynamoDBModel>> GetCities([FromRoute] int ChatId)
        {
            return await _cityRepository.Get(ChatId);
        }

        [HttpGet("actions/{purpose}")]
        public async Task<IEnumerable<Subscription>> GetUsersChatId(string purpose)
        {
            return await _cityRepository.GetUsersChatId(purpose);
        }

        [HttpPost]
        public async Task<CityDynamoDBModel> PostCities([FromBody] CityDynamoDBModel city)
        {
            bool IsACity = _addLogicMethods.CheckingIfACity(city.cityname);

            if (IsACity)
            {
                await _cityRepository.Create(city);
                return city;
            }
            else
            {
                return null;
            }
        }

        [HttpPost("actions")]
        public async Task<Subscription> PostChatId([FromBody] Subscription ChatId)
        {
            await _cityRepository.CreateChatId(ChatId);
            return ChatId;
        }

        //delete a saved city
        [HttpDelete("{ChatId}/{CityName}")]
        public async Task<ActionResult> Delete([FromRoute] int ChatId, string CityName)
        {
            await _cityRepository.Delete(ChatId, CityName);

            return NoContent();
        }

        //delete all saved cities
        [HttpDelete("{ChatId}/deleteall")]
        public async Task<ActionResult> DeleteAll([FromRoute] int ChatId)
        {
            await _cityRepository.DeleteAll(ChatId);

            return NoContent();
        }

        //unsubscribe 
        [HttpDelete("subscription/{ChatId}/delete")]
        public async Task<ActionResult> DeleteSubscription([FromRoute] int ChatId)
        {
            await _cityRepository.DeleteSubscription(ChatId);

            return NoContent();
        }
    }
}
