using ErgastF1.Services;

namespace ErgastF1Test
{
    public class Pitstop
    {
        [Fact]
        public async Task ListByRaceTest()
        {
            PitstopServices pitstopServices = new PitstopServices();
            var response = await pitstopServices.ListByRace(2024, 1);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.RaceTable);
                Assert.NotNull(response.RaceTable.Season);
                Assert.NotNull(response.RaceTable.Round);
                Assert.NotNull(response.RaceTable.Races);
                foreach(var race in response.RaceTable.Races)
                {
                    Assert.NotNull(race);
                    Assert.NotNull(race.Season);
                    Assert.NotNull(race.Round);
                    Assert.NotNull(race.Url);
                    Assert.NotNull(race.RaceName);
                    Assert.NotNull(race.Circuit);
                        Assert.NotNull(race.Circuit.CircuitId);
                        Assert.NotNull(race.Circuit.Url);
                        Assert.NotNull(race.Circuit.CircuitName);
                        Assert.NotNull(race.Circuit.Location);
                            Assert.NotNull(race.Circuit.Location.Lat);
                            Assert.NotNull(race.Circuit.Location.Long);
                            Assert.NotNull(race.Circuit.Location.Locality);
                            Assert.NotNull(race.Circuit.Location.Country);
                    Assert.NotNull(race.Date);
                    Assert.NotNull(race.Time);
                    Assert.NotNull(race.Pitstops);
                    foreach(var pitstops in race.Pitstops)
                    {
                        Assert.NotNull(pitstops);
                        Assert.NotNull(pitstops.DriverId);
                        Assert.NotNull(pitstops.Lap);
                        Assert.NotNull(pitstops.Stop);
                        Assert.NotNull(pitstops.Time);
                        Assert.NotNull(pitstops.Duration);
                    }
                }
        }
    
        [Fact]
        public async Task ListByNumberTest()
        {
            PitstopServices pitstopServices = new PitstopServices();
            var response = await pitstopServices.ListByNumber(2024, 1, 1);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.RaceTable);
                Assert.NotNull(response.RaceTable.Season);
                Assert.NotNull(response.RaceTable.Round);
                Assert.NotNull(response.RaceTable.Races);
                foreach(var race in response.RaceTable.Races)
                {
                    Assert.NotNull(race);
                    Assert.NotNull(race.Season);
                    Assert.NotNull(race.Round);
                    Assert.NotNull(race.Url);
                    Assert.NotNull(race.RaceName);
                    Assert.NotNull(race.Circuit);
                        Assert.NotNull(race.Circuit.CircuitId);
                        Assert.NotNull(race.Circuit.Url);
                        Assert.NotNull(race.Circuit.CircuitName);
                        Assert.NotNull(race.Circuit.Location);
                            Assert.NotNull(race.Circuit.Location.Lat);
                            Assert.NotNull(race.Circuit.Location.Long);
                            Assert.NotNull(race.Circuit.Location.Locality);
                            Assert.NotNull(race.Circuit.Location.Country);
                    Assert.NotNull(race.Date);
                    Assert.NotNull(race.Time);
                    Assert.NotNull(race.Pitstops);
                    foreach(var pitstops in race.Pitstops)
                    {
                        Assert.NotNull(pitstops);
                        Assert.NotNull(pitstops.DriverId);
                        Assert.NotNull(pitstops.Lap);
                        Assert.NotNull(pitstops.Stop);
                        Assert.NotNull(pitstops.Time);
                        Assert.NotNull(pitstops.Duration);
                    }
                }
        }
    }
}
