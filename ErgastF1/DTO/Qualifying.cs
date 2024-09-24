using Newtonsoft.Json;

namespace ErgastF1.DTO
{
    public class QualifyingDTO : PaginationDTO
    {
        [JsonProperty("RaceTable", NullValueHandling = NullValueHandling.Ignore)]
        public RaceTable Content;
    }

    public class QualifyingResults
    {
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number;

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public string Position;

        [JsonProperty("Driver", NullValueHandling = NullValueHandling.Ignore)]
        public Driver Driver;

        [JsonProperty("Constructor", NullValueHandling = NullValueHandling.Ignore)]
        public Constructor Constructor;

        [JsonProperty("Q1", NullValueHandling = NullValueHandling.Ignore)]
        public string Q1;

        [JsonProperty("Q2", NullValueHandling = NullValueHandling.Ignore)]
        public string Q2;

        [JsonProperty("Q3", NullValueHandling = NullValueHandling.Ignore)]
        public string Q3;
    }
}
