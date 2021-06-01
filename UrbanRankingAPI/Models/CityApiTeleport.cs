namespace UrbanRankingAPI.Models
{
    public class CityApiTeleport
    {
        public _Links _links { get; set; }
        public Category[] categories { get; set; }
        public string summary { get; set; }
        public float teleport_city_score { get; set; }
    }

    public class _Links
    {
        public Cury[] curies { get; set; }
    }

    public class Cury
    {
        public string href { get; set; }
        public string name { get; set; }
    }

    public class Category
    {
        public string color { get; set; }
        public string name { get; set; }
        public float score_out_of_10 { get; set; }
    }
}
