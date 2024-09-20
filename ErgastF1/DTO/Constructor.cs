using Newtonsoft.Json;

namespace ErgastF1.DTO
{
    public class ConstructorResponse
    {
        [JsonProperty("MRData", NullValueHandling = NullValueHandling.Ignore)]
        public ConstructorDTO Data;
    }

    public class ConstructorDTO : PaginationDTO
    {
        [JsonProperty("ConstructorTable", NullValueHandling = NullValueHandling.Ignore)]
        public ConstructorTable ConstructorTable;
    }

    public class ConstructorTable
    {
        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public string Season;

        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public string Round;

        [JsonProperty("constructorId", NullValueHandling = NullValueHandling.Ignore)]
        public string ConstructorId;

        [JsonProperty("Constructors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Constructor> Constructors;
    }

    public class Constructor
    {
        [JsonProperty("constructorId", NullValueHandling = NullValueHandling.Ignore)]
        public string ConstructorId;

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url;

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name;

        [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
        public string Nationality;
    }
}
