using Newtonsoft.Json;

namespace ErgastF1.DTO
{
    public class StandingDTO : PaginationDTO
    {
        [JsonProperty("StandingsTable", NullValueHandling = NullValueHandling.Ignore)]
        public StandingsTable Content;
    }

    public class StandingsTable
    {
        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public string Season;

        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public string Round;

        [JsonProperty("driverId", NullValueHandling = NullValueHandling.Ignore)]
        public string DriverId;

        [JsonProperty("constructorId", NullValueHandling = NullValueHandling.Ignore)]
        public string ConstructorId;

        [JsonProperty("StandingsLists", NullValueHandling = NullValueHandling.Ignore)]
        public List<StandingsLists> StandingsLists;
    }

    public class StandingsLists
    {
        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public string Season;

        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public string Round;

        [JsonProperty("DriverStandings", NullValueHandling = NullValueHandling.Ignore)]
        public List<DriverStandings> DriverStandings;

        [JsonProperty("ConstructorStandings", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConstructorStandings> ConstructorStandings;
    }

    public class DriverStandings
    {
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public string Position;

        [JsonProperty("positionText", NullValueHandling = NullValueHandling.Ignore)]
        public string PositionText;

        [JsonProperty("points", NullValueHandling = NullValueHandling.Ignore)]
        public string Points;

        [JsonProperty("wins", NullValueHandling = NullValueHandling.Ignore)]
        public string Wins;

        [JsonProperty("Driver", NullValueHandling = NullValueHandling.Ignore)]
        public Driver Driver;

        [JsonProperty("Constructors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Constructor> Constructors;
    }

    public class ConstructorStandings
    {
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public string Position;

        [JsonProperty("positionText", NullValueHandling = NullValueHandling.Ignore)]
        public string PositionText;

        [JsonProperty("points", NullValueHandling = NullValueHandling.Ignore)]
        public string Points;

        [JsonProperty("wins", NullValueHandling = NullValueHandling.Ignore)]
        public string Wins;

        [JsonProperty("Constructor", NullValueHandling = NullValueHandling.Ignore)]
        public Constructor Constructor;
    }
}
