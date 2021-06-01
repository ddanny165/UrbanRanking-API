using Microsoft.AspNetCore.Mvc;

namespace UrbanRankingAPI.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : Controller
    {
        //welcome page
        [HttpGet]
        public string WelcomePage()
        {
            return "Coursework Web Api. Danylo Moskaliuk IT-04\n\n\n\n" +
                "Available endpoints for all users:\n\n\napi/cities/teleport/{CityName} - getting city ratings according to teleport.org\n\n" +
                "api/cities/teleport/{CityName}/summary - getting the summary on selected city from teleport.org\n\n" +
                "api/cities/getavailable/{letter} - get available cities that work for all the endpoints above sorted according\n" +
                "to their first letters\n\napi/cities/getbest/{CategoryName} - get the best cities for some categories. Available categories " +
                "for the previous \nendpoint are businessfreedom, costofliving, housing, leisure&culture, safety, taxation, travelconnectivity.\n\n\n\n" +
                "api/users controller is only available with api key, because of the manipulations with user's data through telegram bot @UrbanRankingBot.";
        }
    }
}
