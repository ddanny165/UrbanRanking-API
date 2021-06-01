using UrbanRankingAPI.Models;
using UrbanRankingAPI.Models.DynamoDB;
using UrbanRankingAPI.Services;
using UrbanRankingAPI.AddLogic;
using UrbanRankingAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;


namespace UrbanRankingAPI.Controllers
{
    [Route("api/[controller]")] //the path that the controller will end
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ITeleportApiService _teleportService;
        private readonly ICityDBApiService _geodbService;
        private readonly ICityRepository _cityRepository;
        private readonly AddLogicMethods _addLogicMethods;

        public CitiesController(ITeleportApiService teleportService,
            ICityDBApiService citydbService, ICityRepository cityRepository, 
            AddLogicMethods addLogicMethods)
        {
            _teleportService = teleportService;
            _geodbService = citydbService;
            _cityRepository = cityRepository;
            _addLogicMethods = addLogicMethods;
        }

        //third party api's calling
        [HttpGet("geodb/{CityName}")]
        public async Task<CityBasicInfo> GetCityBasicInfo(string CityName)
        {
            try
            {
                string WikiId = _addLogicMethods.GettingWikiId(CityName);

                var cities = await _geodbService.GetCityBasicInfo(WikiId);
                return cities;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
                return null;
            }
        }

        [HttpGet("teleport/{CityName}")]
        public async Task<IEnumerable<CityReview>> GetCityReview(string CityName)
        {
            try
            {
                var cities = await _teleportService.GetCityReview(CityName);
                return cities;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
                return Enumerable.Empty<CityReview>();
            }
        }

        [HttpGet("teleport/{CityName}/summary")]
        public async Task<string> GetCitySummary(string CityName)
        {
            try
            {
                var cities = await _teleportService.GetCitySummary(CityName);

                string result = _addLogicMethods.DeletingHtmlTags(cities);

                CitySummary citysummary = new()
                {
                    Summary = result
                };

                var JsonSummary = JsonSerializer.Serialize(citysummary);

                return JsonSummary;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
                return null;
            }
        }

        //getting data from db, which is available for everybody
        [HttpGet("getavailable/{letter}")]
        public async Task<IEnumerable<CitiesByLetter>> GetCitiesByLetter(string letter)
        {
            return await _cityRepository.GetCitiesByLetter(letter);
        }
        
        [HttpGet("getbest/{category}")]
        public async Task<IEnumerable<GetByCategory>> GetByCategory([FromRoute] string category)
        {
            return await _cityRepository.GetByCategory(category);
        }
    }
}
