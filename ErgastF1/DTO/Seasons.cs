using Newtonsoft.Json;

namespace ErgastF1.DTO
{
    public class SeasonResponse
    {
        [JsonProperty("MRData", NullValueHandling = NullValueHandling.Ignore)]
        public SeasonDTO Data;
    }

    public class SeasonDTO : PaginationDTO
    {
        [JsonProperty("DriverTable", NullValueHandling = NullValueHandling.Ignore)]
        public SeasonTable SeasonTable;
    }

    public class SeasonTable
    {
        [JsonProperty("Seasons", NullValueHandling = NullValueHandling.Ignore)]
        public List<Season> Seasons;
    }

    public class Season
    {
        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public string SeasonYear;

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url;
    }
}
