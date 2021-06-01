namespace UrbanRankingAPI.Models
{
    public class CityApiGeoDB
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public int id { get; set; }
        public string wikiDataId { get; set; }
        public string type { get; set; }
        public string city { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string region { get; set; }
        public string regionCode { get; set; }
        public int elevationMeters { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public int population { get; set; }
        public string timezone { get; set; }
        public object distance { get; set; }
        public bool deleted { get; set; }
    }

}
