using Newtonsoft.Json;

namespace ErgastF1.DTO
{
    public class DriverResponse
    {
        [JsonProperty("MRData", NullValueHandling = NullValueHandling.Ignore)]
        public DriverDTO Data;
    }

    public class DriverDTO : PaginationDTO
    {
        [JsonProperty("DriverTable", NullValueHandling = NullValueHandling.Ignore)]
        public DriverTable DriverTable;
    }

    public class DriverTable
    {
        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public string Season;

        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public string Round;

        [JsonProperty("driverId", NullValueHandling = NullValueHandling.Ignore)]
        public string DriverId;

        [JsonProperty("Drivers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Driver> Drivers;
    }

    public class Driver
    {
        [JsonProperty("driverId", NullValueHandling = NullValueHandling.Ignore)]
        public string DriverId;

        [JsonProperty("permanentNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PermanentNumber;

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code;

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url;

        [JsonProperty("givenName", NullValueHandling = NullValueHandling.Ignore)]
        public string GivenName;

        [JsonProperty("FamilyName", NullValueHandling = NullValueHandling.Ignore)]
        public string FamilyName;

        [JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfBirth;

        [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
        public string Nationality;
    }
}
