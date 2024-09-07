using Newtonsoft.Json;

namespace ErgastF1.DTO
{
    public class QualifyingResponse
    {
        [JsonProperty("MRData", NullValueHandling = NullValueHandling.Ignore)]
        public QualifyingDTO Data;
    }

    public class QualifyingDTO : PaginationDTO
    {
        [JsonProperty("RaceTable", NullValueHandling = NullValueHandling.Ignore)]
        public QualifyingRaceTable RaceTable;
    }

    public class QualifyingRaceTable
    {
        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public string Season;

        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public string Round;

        [JsonProperty("Seasons", NullValueHandling = NullValueHandling.Ignore)]
        public List<QualifyingRaces> Races;
    }

    public class QualifyingRaces
    {
        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public string Season;

        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public string Round;

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url;

        [JsonProperty("raceName", NullValueHandling = NullValueHandling.Ignore)]
        public string RaceName;

        [JsonProperty("Circuit", NullValueHandling = NullValueHandling.Ignore)]
        public Circuit Circuit;

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date;

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time;

        [JsonProperty("QualifyingResults", NullValueHandling = NullValueHandling.Ignore)]
        public QualifyingResults QualifyingResults;
    }
    public class QualifyingResults
    {
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number;

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public string Position;

        [JsonProperty("Driver", NullValueHandling = NullValueHandling.Ignore)]
        public string Driver;

        [JsonProperty("Constructor", NullValueHandling = NullValueHandling.Ignore)]
        public string Constructor;

        [JsonProperty("Q1", NullValueHandling = NullValueHandling.Ignore)]
        public string Q1;

        [JsonProperty("Q2", NullValueHandling = NullValueHandling.Ignore)]
        public string Q2;

        [JsonProperty("Q3", NullValueHandling = NullValueHandling.Ignore)]
        public string Q3;
    }
}
