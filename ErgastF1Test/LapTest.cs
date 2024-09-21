using ErgastF1.Services;

namespace ErgastF1Test
{
    public class LapTest
    {
        [Fact]
        public async Task ListLapTimesTest()
        {
            LapServices lapServices = new LapServices();
            var response = await lapServices.ListLapTimes(2024, 1, 1);

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
                    Assert.NotNull(race.Laps);
                    foreach(var lap in race.Laps)
                    {
                        Assert.NotNull(lap);
                        Assert.NotNull(lap.Number);
                        Assert.NotNull(lap.Timings);
                        foreach(var timing in lap.Timings)
                        {
                            Assert.NotNull(timing);
                            Assert.NotNull(timing.DriverId);
                            Assert.NotNull(timing.Position);
                            Assert.NotNull(timing.Time);
                        }
                    }
                }
        }
    }
}
