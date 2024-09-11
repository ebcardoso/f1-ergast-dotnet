using Newtonsoft.Json;
using System.Xml;

namespace ErgastF1.DTO
{
    public class RaceResponse
    {
        [JsonProperty("MRData", NullValueHandling = NullValueHandling.Ignore)]
        public RaceDTO Data;
    }

	public class RaceDTO : PaginationDTO
	{
        [JsonProperty("RaceTable", NullValueHandling = NullValueHandling.Ignore)]
        public RaceTable RaceTable;
    }

    public class RaceTable
    {
        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public string Season;

        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public string Round;

        [JsonProperty("Races", NullValueHandling = NullValueHandling.Ignore)]
        public List<Race> Races;
    }

	public class Race
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

        [JsonProperty("FirstPractice", NullValueHandling = NullValueHandling.Ignore)]
        public PracticeF1 FirstPractice;

        [JsonProperty("SecondPractice", NullValueHandling = NullValueHandling.Ignore)]
        public PracticeF1 SecondPractice;

        [JsonProperty("ThirdPractice", NullValueHandling = NullValueHandling.Ignore)]
        public PracticeF1 ThirdPractice;

        [JsonProperty("Qualifying", NullValueHandling = NullValueHandling.Ignore)]
        public PracticeF1 Qualifying;
    }

    public class PracticeF1
    {
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date;

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time;
    }
}
