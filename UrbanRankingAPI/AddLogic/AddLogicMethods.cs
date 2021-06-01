using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace UrbanRankingAPI.AddLogic
{
    public class AddLogicMethods
    {
        public string GettingWikiId (string cityName)
        {
            string WikiDataID;
            
            switch (cityName.ToLower())
            {
                case "aarhus":
                    WikiDataID = "Q25319";
                    break;
                case "almaty":
                    WikiDataID = "Q35493";
                    break;
                case "amsterdam":
                    WikiDataID = "Q727";
                    break;
                case "andorra":
                    WikiDataID = "Q1863";
                    break;
                case "athens":
                    WikiDataID = "Q1524";
                    break;
                case "atlanta":
                    WikiDataID = "Q23556";
                    break;
                case "auckland":
                    WikiDataID = "Q37100";
                    break;
                case "austin":
                    WikiDataID = "Q16559";
                    break;
                case "baku":
                    WikiDataID = "Q9248";
                    break;
                case "baltimore":
                    WikiDataID = "Q5092";
                    break;
                case "bangkok":
                    WikiDataID = "Q1861";
                    break;
                case "barcelona":
                    WikiDataID = "Q1492";
                    break;
                case "beijing":
                    WikiDataID = "Q956";
                    break;
                case "beirut":
                    WikiDataID = "Q3820";
                    break;
                case "belgrade":
                    WikiDataID = "Q3711";
                    break;
                case "bilbao":
                    WikiDataID = "Q8692"; 
                    break;
                case "bergen":
                    WikiDataID = "Q26793"; 
                    break;
                case "anchorage":
                    WikiDataID = "Q39450"; 
                    break;
                case "bogota":
                    WikiDataID = "Q2841";
                    break;
                case "bologna":
                    WikiDataID = "Q1891";
                    break;
                case "bordeaux":
                    WikiDataID = "Q1479"; 
                    break;
                case "boston":
                    WikiDataID = "Q100";
                    break;
                case "bratislava":
                    WikiDataID = "Q1780";
                    break;
                case "brisbane":
                    WikiDataID = "Q34932";
                    break;
                case "brno":
                    WikiDataID = "Q14960";
                    break;
                case "calgary":
                    WikiDataID = "Q36312"; 
                    break;
                case "bucharest":
                    WikiDataID = "Q19660";
                    break;
                case "budapest":
                    WikiDataID = "Q1781";
                    break;
                case "cairo":
                    WikiDataID = "Q85";
                    break;
                case "cardiff":
                    WikiDataID = "Q10690";
                    break;
                case "charlotte":
                    WikiDataID = "Q16565";
                    break;
                case "chicago":
                    WikiDataID = "Q1297";
                    break;
                case "chisinau":
                    WikiDataID = "Q21197";
                    break;
                case "cincinnati":
                    WikiDataID = "Q43196";
                    break;
                case "cleveland":
                    WikiDataID = "Q37320";
                    break;
                case "cologne":
                    WikiDataID = "Q365";
                    break;
                case "columbus":
                    WikiDataID = "Q16567";
                    break;
                case "chennai":
                    WikiDataID = "Q1352"; 
                    break;
                case "dallas":
                    WikiDataID = "Q16557";
                    break;
                case "delhi":
                    WikiDataID = "Q987";
                    break;
                case "denver":
                    WikiDataID = "Q16554";
                    break;
                case "detroit":
                    WikiDataID = "Q12439";
                    break;
                case "florianopolis":
                    WikiDataID = "Q132997"; 
                    break;
                case "dubai":
                    WikiDataID = "Q612";
                    break;
                case "cork":
                    WikiDataID = "Q36647"; 
                    break;
                case "dusseldorf":
                    WikiDataID = "Q1718";
                    break;
                case "edinburgh":
                    WikiDataID = "Q23436";
                    break;
                case "eindhoven":
                    WikiDataID = "Q9832"; 
                    break;
                case "frankfurt":
                    WikiDataID = "Q1794";
                    break;
                case "gdansk":
                    WikiDataID = "Q1792";
                    break;
                case "florence":
                    WikiDataID = "Q2044";  
                    break;
                case "doha":
                    WikiDataID = "Q3861"; 
                    break;
                case "grenoble":
                    WikiDataID = "Q1289"; 
                    break;
                case "gothenburg":
                    WikiDataID = "Q25287";
                    break;
                case "guadalajara":
                    WikiDataID = "Q9022";
                    break;
                case "kingston":
                    WikiDataID = "Q34692"; 
                    break;
                case "hannover":
                    WikiDataID = "Q1715";
                    break;
                case "havana":
                    WikiDataID = "Q1563";
                    break;
                case "helsinki":
                    WikiDataID = "Q1757";
                    break;
                case "honolulu":
                    WikiDataID = "Q18094";
                    break;
                case "houston":
                    WikiDataID = "Q16555";
                    break;
                case "indianapolis":
                    WikiDataID = "Q6346";
                    break;
                case "innsbruck":
                    WikiDataID = "Q1735";
                    break;
                case "istanbul":
                    WikiDataID = "Q406";
                    break;
                case "jakarta":
                    WikiDataID = "Q3630";
                    break;
                case "johannesburg":
                    WikiDataID = "Q34647";
                    break;
                case "fukuoka":
                    WikiDataID = "Q26600"; 
                    break;
                case "kiev":
                    WikiDataID = "Q1899";
                    break;
                case "kyiv":
                    WikiDataID = "Q1899";
                    break;
                case "krakow":
                    WikiDataID = "Q31487";
                    break;
                case "lima":
                    WikiDataID = "Q2868"; 
                    break;
                case "madison":
                    WikiDataID = "Q43788"; 
                    break;
                case "nantes":
                    WikiDataID = "Q12191"; 
                    break;
                case "lille":
                    WikiDataID = "Q648"; 
                    break;
                case "nicosia":
                    WikiDataID = "Q3856"; 
                    break;
                case "liverpool":
                    WikiDataID = "Q24826";
                    break;
                case "ljubljana":
                    WikiDataID = "Q437";
                    break;
                case "london":
                    WikiDataID = "Q84";
                    break;
                case "lviv":
                    WikiDataID = "Q36036";
                    break;
                case "turku":
                    WikiDataID = "Q38511";
                    break;
                case "madrid":
                    WikiDataID = "Q2807";
                    break;
                case "malaga":
                    WikiDataID = "Q8851";
                    break;
                case "malmo":
                    WikiDataID = "Q2211";
                    break;
                case "manchester":
                    WikiDataID = "Q18125";
                    break;
                case "montevideo":
                    WikiDataID = "Q1335"; 
                    break;
                case "marseille":
                    WikiDataID = "Q23482";
                    break;
                case "medellin":
                    WikiDataID = "Q48278";
                    break;
                case "melbourne":
                    WikiDataID = "Q3141";
                    break;
                case "miami":
                    WikiDataID = "Q8652";
                    break;
                case "milan":
                    WikiDataID = "Q490";
                    break;
                case "minsk":
                    WikiDataID = "Q2280";
                    break;
                case "montreal":
                    WikiDataID = "Q340";
                    break;
                case "moscow":
                    WikiDataID = "Q649";
                    break;
                case "mumbai":
                    WikiDataID = "Q1156";
                    break;
                case "munich":
                    WikiDataID = "Q1726";
                    break;
                case "nairobi":
                    WikiDataID = "Q3870";
                    break;
                case "naples":
                    WikiDataID = "Q2634";
                    break;
                case "nashville":
                    WikiDataID = "Q23197";
                    break;
                case "orlando":
                    WikiDataID = "Q49233";
                    break;
                case "casablanca":
                    WikiDataID = "Q7903"; 
                    break;
                case "oslo":
                    WikiDataID = "Q585";
                    break;
                case "ottawa":
                    WikiDataID = "Q1930";
                    break;
                case "panama":
                    WikiDataID = "Q3306";
                    break;
                case "paris":
                    WikiDataID = "Q90";
                    break;
                case "philadelphia":
                    WikiDataID = "Q1345";
                    break;
                case "pittsburgh":
                    WikiDataID = "Q1342";
                    break;
                case "porto":
                    WikiDataID = "Q36433";
                    break;
                case "tehran":
                    WikiDataID = "Q3616"; 
                    break;
                case "quebec":
                    WikiDataID = "Q2145";
                    break;
                case "riga":
                    WikiDataID = "Q1773";
                    break;
                case "rome":
                    WikiDataID = "Q220";
                    break;
                case "rotterdam":
                    WikiDataID = "Q34370";
                    break;
                case "sarajevo":
                    WikiDataID = "Q11194";
                    break;
                case "seattle":
                    WikiDataID = "Q5083";
                    break;
                case "seoul":
                    WikiDataID = "Q8684";
                    break;
                case "santiago":
                    WikiDataID = "Q2887"; 
                    break;
                case "shanghai":
                    WikiDataID = "Q8686"; 
                    break;
                case "reykjavik":
                    WikiDataID = "Q1764"; 
                    break;
                case "sofia":
                    WikiDataID = "Q472";
                    break;
                case "uppsala":
                    WikiDataID = "Q25286"; 
                    break;
                case "taipei":
                    WikiDataID = "Q1867"; 
                    break;
                case "sydney":
                    WikiDataID = "Q3130";
                    break;
                case "tallinn":
                    WikiDataID = "Q1770";
                    break;
                case "thessaloniki":
                    WikiDataID = "Q17151"; 
                    break;
                case "tokyo":
                    WikiDataID = "Q1490";
                    break;
                case "toronto":
                    WikiDataID = "Q172";
                    break;
                case "tunis":
                    WikiDataID = "Q3572";
                    break;
                case "turin":
                    WikiDataID = "Q495";
                    break;
                case "utrecht":
                    WikiDataID = "Q803";
                    break;
                case "valencia":
                    WikiDataID = "Q8818";
                    break;
                case "vancouver":
                    WikiDataID = "Q24639";
                    break;
                case "vienna":
                    WikiDataID = "Q1741";
                    break;
                case "vilnius":
                    WikiDataID = "Q216";
                    break;
                case "skopje":
                    WikiDataID = "Q384"; 
                    break;
                case "wellington":
                    WikiDataID = "Q23661";
                    break;
                case "winnipeg":
                    WikiDataID = "Q2135";
                    break;
                case "perth":
                    WikiDataID = "Q3183"; 
                    break;
                case "valletta":
                    WikiDataID = "Q23800"; 
                    break;
                case "zagreb":
                    WikiDataID = "Q1435";
                    break;
                case "zurich":
                    WikiDataID = "Q72";
                    break;
                default:
                    WikiDataID = ""; 
                    break;
            }

            return WikiDataID;
        }
        public string DeletingHtmlTags (string htmlSummary)
        {
            HtmlDocument htmlDoc = new();

            htmlDoc.LoadHtml(htmlSummary);
            string result = htmlDoc.DocumentNode.InnerText;
            
            result = result.Replace("\n", " ");
            result = result.Replace("\u0026", "and");
            result = result.Replace("\u00A0", " ");

            string SpacesPattern = @"\s+"; 
            string SpacesTarget = " ";
            Regex SpacesRegex = new(SpacesPattern);

            result = SpacesRegex.Replace(result, SpacesTarget);

            return result;
        }
        public bool CheckingIfACity (string input)
        {
            bool IsACity;

            switch (input.ToLower())
            {
                case "aarhus":
                    IsACity = true;
                    break;
                case "almaty":
                    IsACity = true;
                    break;
                case "amsterdam":
                    IsACity = true;
                    break;
                case "andorra":
                    IsACity = true;
                    break;
                case "athens":
                    IsACity = true;
                    break;
                case "atlanta":
                    IsACity = true;
                    break;
                case "auckland":
                    IsACity = true;
                    break;
                case "austin":
                    IsACity = true;
                    break;
                case "baku":
                    IsACity = true;
                    break;
                case "baltimore":
                    IsACity = true;
                    break;
                case "bangkok":
                    IsACity = true;
                    break;
                case "barcelona":
                    IsACity = true;
                    break;
                case "beijing":
                    IsACity = true;
                    break;
                case "beirut":
                    IsACity = true;
                    break;
                case "belgrade":
                    IsACity = true;
                    break;
                case "bilbao":
                    IsACity = true;
                    break;
                case "bergen":
                    IsACity = true;
                    break;
                case "anchorage":
                    IsACity = true;
                    break;
                case "bogota":
                    IsACity = true;
                    break;
                case "bologna":
                    IsACity = true;
                    break;
                case "bordeaux":
                    IsACity = true;
                    break;
                case "boston":
                    IsACity = true;
                    break;
                case "bratislava":
                    IsACity = true;
                    break;
                case "brisbane":
                    IsACity = true;
                    break;
                case "brno":
                    IsACity = true;
                    break;
                case "calgary":
                    IsACity = true;
                    break;
                case "bucharest":
                    IsACity = true;
                    break;
                case "budapest":
                    IsACity = true;
                    break;
                case "cairo":
                    IsACity = true;
                    break;
                case "cardiff":
                    IsACity = true;
                    break;
                case "charlotte":
                    IsACity = true;
                    break;
                case "chicago":
                    IsACity = true;
                    break;
                case "chisinau":
                    IsACity = true;
                    break;
                case "cincinnati":
                    IsACity = true;
                    break;
                case "cleveland":
                    IsACity = true;
                    break;
                case "cologne":
                    IsACity = true;
                    break;
                case "columbus":
                    IsACity = true;
                    break;
                case "chennai":
                    IsACity = true;
                    break;
                case "dallas":
                    IsACity = true;
                    break;
                case "delhi":
                    IsACity = true;
                    break;
                case "denver":
                    IsACity = true;
                    break;
                case "detroit":
                    IsACity = true;
                    break;
                case "florianopolis":
                    IsACity = true;
                    break;
                case "dubai":
                    IsACity = true;
                    break;
                case "cork":
                    IsACity = true;
                    break;
                case "dusseldorf":
                    IsACity = true;
                    break;
                case "edinburgh":
                    IsACity = true;
                    break;
                case "eindhoven":
                    IsACity = true;
                    break;
                case "frankfurt":
                    IsACity = true;
                    break;
                case "gdansk":
                    IsACity = true;
                    break;
                case "florence":
                    IsACity = true;
                    break;
                case "doha":
                    IsACity = true;
                    break;
                case "grenoble":
                    IsACity = true;
                    break;
                case "gothenburg":
                    IsACity = true;
                    break;
                case "guadalajara":
                    IsACity = true;
                    break;
                case "kingston":
                    IsACity = true;
                    break;
                case "hannover":
                    IsACity = true;
                    break;
                case "havana":
                    IsACity = true;
                    break;
                case "helsinki":
                    IsACity = true;
                    break;
                case "honolulu":
                    IsACity = true;
                    break;
                case "houston":
                    IsACity = true;
                    break;
                case "indianapolis":
                    IsACity = true;
                    break;
                case "innsbruck":
                    IsACity = true;
                    break;
                case "istanbul":
                    IsACity = true;
                    break;
                case "jakarta":
                    IsACity = true;
                    break;
                case "johannesburg":
                    IsACity = true;
                    break;
                case "fukuoka":
                    IsACity = true;
                    break;
                case "kiev":
                    IsACity = true;
                    break;
                case "kyiv":
                    IsACity = true;
                    break;
                case "krakow":
                    IsACity = true;
                    break;
                case "lima":
                    IsACity = true;
                    break;
                case "madison":
                    IsACity = true;
                    break;
                case "nantes":
                    IsACity = true;
                    break;
                case "lille":
                    IsACity = true;
                    break;
                case "nicosia":
                    IsACity = true;
                    break;
                case "liverpool":
                    IsACity = true;
                    break;
                case "ljubljana":
                    IsACity = true;
                    break;
                case "london":
                    IsACity = true;
                    break;
                case "lviv":
                    IsACity = true;
                    break;
                case "turku":
                    IsACity = true;
                    break;
                case "madrid":
                    IsACity = true;
                    break;
                case "malaga":
                    IsACity = true;
                    break;
                case "malmo":
                    IsACity = true;
                    break;
                case "manchester":
                    IsACity = true;
                    break;
                case "montevideo":
                    IsACity = true;
                    break;
                case "marseille":
                    IsACity = true;
                    break;
                case "medellin":
                    IsACity = true;
                    break;
                case "melbourne":
                    IsACity = true;
                    break;
                case "miami":
                    IsACity = true;
                    break;
                case "milan":
                    IsACity = true;
                    break;
                case "minsk":
                    IsACity = true;
                    break;
                case "montreal":
                    IsACity = true;
                    break;
                case "moscow":
                    IsACity = true;
                    break;
                case "mumbai":
                    IsACity = true;
                    break;
                case "munich":
                    IsACity = true;
                    break;
                case "nairobi":
                    IsACity = true;
                    break;
                case "naples":
                    IsACity = true;
                    break;
                case "nashville":
                    IsACity = true;
                    break;
                case "orlando":
                    IsACity = true;
                    break;
                case "casablanca":
                    IsACity = true;
                    break;
                case "oslo":
                    IsACity = true;
                    break;
                case "ottawa":
                    IsACity = true;
                    break;
                case "panama":
                    IsACity = true;
                    break;
                case "paris":
                    IsACity = true;
                    break;
                case "philadelphia":
                    IsACity = true;
                    break;
                case "pittsburgh":
                    IsACity = true;
                    break;
                case "porto":
                    IsACity = true;
                    break;
                case "tehran":
                    IsACity = true;
                    break;
                case "quebec":
                    IsACity = true;
                    break;
                case "riga":
                    IsACity = true;
                    break;
                case "rome":
                    IsACity = true;
                    break;
                case "rotterdam":
                    IsACity = true;
                    break;
                case "sarajevo":
                    IsACity = true;
                    break;
                case "seattle":
                    IsACity = true;
                    break;
                case "seoul":
                    IsACity = true;
                    break;
                case "santiago":
                    IsACity = true;
                    break;
                case "shanghai":
                    IsACity = true;
                    break;
                case "reykjavik":
                    IsACity = true;
                    break;
                case "sofia":
                    IsACity = true;
                    break;
                case "uppsala":
                    IsACity = true;
                    break;
                case "taipei":
                    IsACity = true;
                    break;
                case "sydney":
                    IsACity = true;
                    break;
                case "tallinn":
                    IsACity = true;
                    break;
                case "thessaloniki":
                    IsACity = true;
                    break;
                case "tokyo":
                    IsACity = true;
                    break;
                case "toronto":
                    IsACity = true;
                    break;
                case "tunis":
                    IsACity = true;
                    break;
                case "turin":
                    IsACity = true;
                    break;
                case "utrecht":
                    IsACity = true;
                    break;
                case "valencia":
                    IsACity = true;
                    break;
                case "vancouver":
                    IsACity = true;
                    break;
                case "vienna":
                    IsACity = true;
                    break;
                case "vilnius":
                    IsACity = true;
                    break;
                case "skopje":
                    IsACity = true;
                    break;
                case "wellington":
                    IsACity = true;
                    break;
                case "winnipeg":
                    IsACity = true;
                    break;
                case "perth":
                    IsACity = true;
                    break;
                case "valletta":
                    IsACity = true;
                    break;
                case "zagreb":
                    IsACity = true;
                    break;
                case "zurich":
                    IsACity = true;
                    break;
                default:
                    IsACity = false; 
                    break;
            }

            return IsACity;
        }
    }
}
