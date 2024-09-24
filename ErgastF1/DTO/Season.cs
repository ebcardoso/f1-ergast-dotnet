using Newtonsoft.Json;

namespace ErgastF1.DTO
{
    public class SeasonDTO : PaginationDTO
    {
        [JsonProperty("SeasonTable", NullValueHandling = NullValueHandling.Ignore)]
        public SeasonTable Content;
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
