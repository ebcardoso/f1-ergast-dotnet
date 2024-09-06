using Newtonsoft.Json;

namespace ErgastF1.DTO
{
    public class PaginationDTO
    {
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit;

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset;

        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public string Total;

        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        public string Series;

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url;

        [JsonProperty("xmlns", NullValueHandling = NullValueHandling.Ignore)]
        public string Xmlns;
    }
}
