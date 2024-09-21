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

        [JsonProperty("QualifyingResults", NullValueHandling = NullValueHandling.Ignore)]
        public List<QualifyingResults> QualifyingResults;

        [JsonProperty("Results", NullValueHandling = NullValueHandling.Ignore)]
        public List<Result> Results;

        [JsonProperty("Laps", NullValueHandling = NullValueHandling.Ignore)]
        public List<Lap> Laps;

        [JsonProperty("Stop", NullValueHandling = NullValueHandling.Ignore)]
        public string Stop;

        [JsonProperty("Pitstops", NullValueHandling = NullValueHandling.Ignore)]
        public List<Pitstop> Pitstops;
    }

    public class PracticeF1
    {
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date;

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time;
    }

    public class Result
    {
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number;

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public string Position;

        [JsonProperty("positionText", NullValueHandling = NullValueHandling.Ignore)]
        public string PositionText;

        [JsonProperty("points", NullValueHandling = NullValueHandling.Ignore)]
        public string Points;

        [JsonProperty("Driver", NullValueHandling = NullValueHandling.Ignore)]
        public Driver Driver;

        [JsonProperty("Constructor", NullValueHandling = NullValueHandling.Ignore)]
        public Constructor Constructor;

        [JsonProperty("grid", NullValueHandling = NullValueHandling.Ignore)]
        public string Grid;

        [JsonProperty("laps", NullValueHandling = NullValueHandling.Ignore)]
        public string Laps;

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status;

        [JsonProperty("Time", NullValueHandling = NullValueHandling.Ignore)]
        public ResultTime Time;

        [JsonProperty("FastestLap", NullValueHandling = NullValueHandling.Ignore)]
        public ResultFastestLap FastestLap;
    }

    public class ResultTime
    {
        [JsonProperty("millis", NullValueHandling = NullValueHandling.Ignore)]
        public string Millis;

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time;
    }

    public class ResultFastestLap
    {
        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public string Rank;

        [JsonProperty("lap", NullValueHandling = NullValueHandling.Ignore)]
        public string Lap;

        [JsonProperty("Time", NullValueHandling = NullValueHandling.Ignore)]
        public ResultTime Time;

        [JsonProperty("AverageSpeed", NullValueHandling = NullValueHandling.Ignore)]
        public ResultAverageSpeed AverageSpeed;
    }

    public class ResultAverageSpeed
    {
        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
        public string Units;

        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public string Speed;
    }
}
