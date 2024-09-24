using ErgastF1.Services;

namespace ErgastF1Test
{
    public class ResultTest
    {
        [Fact]
        public async Task MostRecentTest()
        {
            ResultServices resultServices = new ResultServices();
            var response = await resultServices.MostRecent();

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Season);
                Assert.NotNull(response.Content.Round);
                Assert.NotNull(response.Content.Races);
                foreach(var race in response.Content.Races)
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
                    Assert.NotNull(race.Results);
                    foreach(var result in race.Results)
                    {
                        Assert.NotNull(result);
                        Assert.NotNull(result.Number);
                        Assert.NotNull(result.Position);
                        Assert.NotNull(result.PositionText);
                        Assert.NotNull(result.Points);
                        Assert.NotNull(result.Driver);
                            Assert.NotNull(result.Driver.DriverId);
                            Assert.NotNull(result.Driver.Url);
                            Assert.NotNull(result.Driver.GivenName);
                            Assert.NotNull(result.Driver.FamilyName);
                            Assert.NotNull(result.Driver.DateOfBirth);
                            Assert.NotNull(result.Driver.Nationality);
                        Assert.NotNull(result.Constructor);
                            Assert.NotNull(result.Constructor.ConstructorId);
                            Assert.NotNull(result.Constructor.Url);
                            Assert.NotNull(result.Constructor.Name);
                            Assert.NotNull(result.Constructor.Nationality);
                        Assert.NotNull(result.Grid);
                        Assert.NotNull(result.Laps);
                        Assert.NotNull(result.Status);
                        Assert.NotNull(result.FastestLap);
                            Assert.NotNull(result.FastestLap.Rank);
                            Assert.NotNull(result.FastestLap.Lap);
                            Assert.NotNull(result.FastestLap.Time);
                                Assert.NotNull(result.FastestLap.Time.Time);
                            Assert.NotNull(result.FastestLap.AverageSpeed);
                                Assert.NotNull(result.FastestLap.AverageSpeed.Units);
                                Assert.NotNull(result.FastestLap.AverageSpeed.Speed);                    
                    }
                }
        }

        [Fact]
        public async Task ListByRaceTest()
        {
            ResultServices resultServices = new ResultServices();
            var response = await resultServices.ListByRace(2024, 1);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Season);
                Assert.NotNull(response.Content.Round);
                Assert.NotNull(response.Content.Races);
                foreach(var race in response.Content.Races)
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
                    Assert.NotNull(race.Results);
                    foreach(var result in race.Results)
                    {
                        Assert.NotNull(result);
                        Assert.NotNull(result.Number);
                        Assert.NotNull(result.Position);
                        Assert.NotNull(result.PositionText);
                        Assert.NotNull(result.Points);
                        Assert.NotNull(result.Driver);
                            Assert.NotNull(result.Driver.DriverId);
                            Assert.NotNull(result.Driver.Url);
                            Assert.NotNull(result.Driver.GivenName);
                            Assert.NotNull(result.Driver.FamilyName);
                            Assert.NotNull(result.Driver.DateOfBirth);
                            Assert.NotNull(result.Driver.Nationality);
                        Assert.NotNull(result.Constructor);
                            Assert.NotNull(result.Constructor.ConstructorId);
                            Assert.NotNull(result.Constructor.Url);
                            Assert.NotNull(result.Constructor.Name);
                            Assert.NotNull(result.Constructor.Nationality);
                        Assert.NotNull(result.Grid);
                        Assert.NotNull(result.Laps);
                        Assert.NotNull(result.Status);
                        Assert.NotNull(result.FastestLap);
                            Assert.NotNull(result.FastestLap.Rank);
                            Assert.NotNull(result.FastestLap.Lap);
                            Assert.NotNull(result.FastestLap.Time);
                                Assert.NotNull(result.FastestLap.Time.Time);
                            Assert.NotNull(result.FastestLap.AverageSpeed);
                                Assert.NotNull(result.FastestLap.AverageSpeed.Units);
                                Assert.NotNull(result.FastestLap.AverageSpeed.Speed);                    
                    }
                }
        }
    }
}
