using Newtonsoft.Json;

namespace ErgastF1.DTO
{
    public class FinishingStatusResponse
    {
        [JsonProperty("MRData", NullValueHandling = NullValueHandling.Ignore)]
        public FinishingStatusDTO Data;
    }

    public class FinishingStatusDTO : PaginationDTO
    {
        [JsonProperty("StatusTable", NullValueHandling = NullValueHandling.Ignore)]
        public StatusTable StatusTable;
    }

    public class StatusTable
    {
        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public string Season;

        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public string Round;

        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public List<FinishingStatus> Status;
    }

    public class FinishingStatus
    {
        [JsonProperty("statusId", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusId;

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public string Count;

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status;
    }
}
