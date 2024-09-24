using Newtonsoft.Json;

namespace ErgastF1.DTO
{
    public class CircuitDTO : PaginationDTO
    {   
        [JsonProperty("CircuitTable", NullValueHandling = NullValueHandling.Ignore)]
        public CircuitTable Content;
    }

    public class CircuitTable
    {
        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public string Season;

        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public string Round;

        [JsonProperty("circuitId", NullValueHandling = NullValueHandling.Ignore)]
        public string CircuitId;

        [JsonProperty("Circuits", NullValueHandling = NullValueHandling.Ignore)]
        public List<Circuit> Circuits;
    }

    public class Circuit
    {
        [JsonProperty("circuitId", NullValueHandling = NullValueHandling.Ignore)]
        public string CircuitId;

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url;

        [JsonProperty("circuitName", NullValueHandling = NullValueHandling.Ignore)]
        public string CircuitName;

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public CircuitLocation Location;
    }

    public class CircuitLocation
    {
        [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
        public string Lat;

        [JsonProperty("long", NullValueHandling = NullValueHandling.Ignore)]
        public string Long;

        [JsonProperty("locality", NullValueHandling = NullValueHandling.Ignore)]
        public string Locality;

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country;
    }
}
