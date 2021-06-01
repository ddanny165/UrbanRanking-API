using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrbanRankingAPI.Models.DynamoDB;
using Amazon.DynamoDBv2.DataModel;


namespace UrbanRankingAPI.Repository
{
    public class CityRepository : ICityRepository 
    {
        private readonly IDynamoDBContext _dynamoDBcontext;
        public CityRepository(IDynamoDBContext city)
        {
            _dynamoDBcontext = city;
        }

        public async Task<IEnumerable<CityDynamoDBModel>> Get(int chatid)
        {
            return await _dynamoDBcontext
                .QueryAsync<CityDynamoDBModel>(chatid)
                .GetRemainingAsync(); //getting all the items inside this particular query
        }

        public async Task<IEnumerable<GetByCategory>> GetByCategory(string category)
        {
            return await _dynamoDBcontext.
                QueryAsync<GetByCategory>(category).
                GetRemainingAsync();
        }

        public async Task<IEnumerable<CitiesByLetter>> GetCitiesByLetter(string letter)
        {
            return await _dynamoDBcontext.
                QueryAsync<CitiesByLetter>(letter).
                GetRemainingAsync();
        }
        public async Task<IEnumerable<Subscription>> GetUsersChatId(string purpose)
        {
            return await _dynamoDBcontext.
                QueryAsync<Subscription>(purpose).
                GetRemainingAsync();
        }

        public async Task<CityDynamoDBModel> Create(CityDynamoDBModel city)
        {
            await _dynamoDBcontext.SaveAsync(city);
            return city;
        }

        public async Task<Subscription> CreateChatId(Subscription subscription)
        {
            await _dynamoDBcontext.SaveAsync(subscription);
            return subscription;
        }

        public async Task<ActionResult> Delete(int chatid, string cityname)
        {
            var cityToDelete = await _dynamoDBcontext.LoadAsync<CityDynamoDBModel>(chatid, cityname);

            if (cityToDelete == null)
            {
                return null;
            }
            await _dynamoDBcontext.DeleteAsync(cityToDelete);
            return null;
        }

        public async Task<ActionResult> DeleteAll(int chatid)
        {
            var cityToDelete = await _dynamoDBcontext
                .QueryAsync<CityDynamoDBModel>(chatid)
                .GetRemainingAsync();

            if (cityToDelete == null)
            {
                return null;
            }

            foreach (var CityData in cityToDelete)
            {
                await _dynamoDBcontext.DeleteAsync(CityData);
            }

            return null;
        }

        public async Task<ActionResult> DeleteSubscription(int chatid)
        {
            var userToDelete = await _dynamoDBcontext.LoadAsync<Subscription>("subscribe", chatid);

            if (userToDelete == null)
            {
                return null;
            }

           await _dynamoDBcontext.DeleteAsync(userToDelete);
            
           return null;
        }
    }
}
