using Newtonsoft.Json;

namespace ErgastF1.DTO
{
    public class PitstopResponse
    {
        [JsonProperty("MRData", NullValueHandling = NullValueHandling.Ignore)]
        public PitstopDTO Data;
    }

    public class PitstopDTO : PaginationDTO
    {
        [JsonProperty("RaceTable", NullValueHandling = NullValueHandling.Ignore)]
        public RaceTable RaceTable;
    }

    public class Pitstop
    {
        [JsonProperty("driverId", NullValueHandling = NullValueHandling.Ignore)]
        public string DriverId;

        [JsonProperty("lap", NullValueHandling = NullValueHandling.Ignore)]
        public string Lap;

        [JsonProperty("stop", NullValueHandling = NullValueHandling.Ignore)]
        public string Stop;

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time;

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string Duration;
    }
}
