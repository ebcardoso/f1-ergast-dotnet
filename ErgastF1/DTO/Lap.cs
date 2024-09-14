using Newtonsoft.Json;

namespace ErgastF1.DTO
{
    public class LapResponse
    {
        [JsonProperty("MRData", NullValueHandling = NullValueHandling.Ignore)]
        public LapDTO Data;
    }

    public class LapDTO : PaginationDTO
    {
        [JsonProperty("RaceTable", NullValueHandling = NullValueHandling.Ignore)]
        public RaceTable RaceTable;
    }

    public class Lap
    {
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number;

        [JsonProperty("Timings", NullValueHandling = NullValueHandling.Ignore)]
        public List<Timing> Timings;
    }

    public class Timing
    {
        [JsonProperty("driverId", NullValueHandling = NullValueHandling.Ignore)]
        public string DriverId;

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public string Position;

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time;
    }
}
